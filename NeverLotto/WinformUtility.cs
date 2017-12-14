#region
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion

namespace NeverLotto
{
    public static class WinformUtility
    {
        #region InvokeIfNeeded
        public static void InvokeIfNeeded(this Control control, Action action)
        {
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }

        public static void InvokeIfNeeded<T>(this Control control, Action<T> action, T arg)
        {
            if (control.InvokeRequired)
                control.Invoke(action, arg);
            else
                action(arg);
        }

        public static void InvokeIfNeeded<T1, T2>(this Control control, Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            if (control.InvokeRequired)
                control.Invoke(action, arg1, arg2);
            else
                action(arg1, arg2);
        }

        public static void InvokeIfNeeded<T1, T2, T3>(this Control control, Action<T1, T2, T3> action, T1 arg1, T2 arg2,
                                                      T3 arg3)
        {
            if (control.InvokeRequired)
                control.Invoke(action, arg1, arg2, arg3);
            else
                action(arg1, arg2, arg3);
        }

        public static void InvokeIfNeeded<T1, T2, T3, T4>(this Control control, Action<T1, T2, T3, T4> action, T1 arg1,
                                                          T2 arg2, T3 arg3, T4 arg4)
        {
            if (control.InvokeRequired)
                control.Invoke(action, arg1, arg2, arg3, arg4);
            else
                action(arg1, arg2, arg3, arg4);
        }
        #endregion

        /// <summary>
        ///     레이아웃을 저장하기 위한 파일 이름을 얻는다. (부모 타입 + 컨트롤 이름) ex) MainForm.grdGrid
        /// </summary>
        /// <param name="control"> </param>
        /// <param name="useDefaultLayout"> </param>
        /// <returns> </returns>
        public static string GetLayoutFileName(this Control control, bool useDefaultLayout)
        {
            string fullName = String.Format("{0}.{1}", control.Parent.GetType().Name, control.Name);
            return String.Format(@"Saved\{0}.{1}xml", fullName, useDefaultLayout ? "default." : String.Empty);
        }

        /// <summary>
        ///     컨트롤이 포함된 최상위 컨테이너의 이름을 얻는다.
        /// </summary>
        /// <param name="control"> </param>
        /// <returns> </returns>
        public static string GetRootContainerName(this Control control)
        {
            Control item = control;

            while (true)
            {
                if (item is Form)
                    return item.GetType().Name;

                item = item.Parent;
            }
        }

        #region SuspendDrawing / ResumeDrawing
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendDrawing(this Form form)
        {
            SendMessage(form.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(this Form form)
        {
            SendMessage(form.Handle, WM_SETREDRAW, true, 0);

            form.Refresh();
        }
        #endregion

        public static void AsyncMethodExecute(object args, Action<object, DoWorkEventArgs> workAction,
                                              Action<object, RunWorkerCompletedEventArgs> completeAction, Form form)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();


            Action beginWaitingAction = () => { form.Cursor = Cursors.WaitCursor; };

            Action<object, DoWorkEventArgs> beginWaitAction = (sender, e) => form.InvokeIfNeeded(beginWaitingAction);
            Action<object, RunWorkerCompletedEventArgs> endWaitAction = (sender, e) => { form.Cursor = Cursors.Arrow; };
            backgroundWorker.DoWork += new DoWorkEventHandler(beginWaitAction);
            backgroundWorker.DoWork += new DoWorkEventHandler(workAction);

            if (completeAction != null)
                backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(completeAction);

            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(endWaitAction);

            backgroundWorker.RunWorkerAsync(args);
        }

        public static T LoadPluggableForm<T>(int companyID, string basePluggableFormName, params object[] args)
        {
            // 00001
            string downloadGroup = companyID.ToString("D5");
            // Lawffice.Plugin_00001
            string assemblyName = "Lawffice.Plugin_" + downloadGroup;
            // Lawffice.Plugin_00001.PluggableNewCaseForm
            string typeName = assemblyName + "." + basePluggableFormName;

            if (ApplicationDeployment.IsNetworkDeployed)
                ApplicationDeployment.CurrentDeployment.DownloadFileGroup(downloadGroup);

            var assembly = Assembly.Load(assemblyName);
            Type type = assembly.GetType(typeName);
            T plugin = (T) Activator.CreateInstance(type, args);

            return plugin;
        }

        public static Version GetVersion()
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            if (ApplicationDeployment.IsNetworkDeployed)
                version = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            return version;
        }

        public static string GetVersionText()
        {
            Version version = GetVersion();
            return String.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Revision);
        }

        public static string GetPublishVersionText()
        {
            Version version = null;

            try
            {
                version = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            catch
            {
                version = GetVersion();
            }

            return String.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }

        public static List<T> GetChildren<T>(Control container) where T : class
        {
            List<T> controls = new List<T>();

            GetChildrenCore(container, controls);

            return controls;
        }

        private static void GetChildrenCore<T>(Control container, List<T> controls) where T : class
        {
            var fields = container.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var field in fields)
            {
                //                if (field.FieldType.IsSubclassOf(typeof(T))) // T 가 인터페이스이면 동작하지 않음
                if (typeof (T).IsAssignableFrom(field.FieldType))
                {
                    T control = (T) field.GetValue(container);

                    // container가 ApprovalWizardForm인 경우 SnapControl이 필드로 인식됨. 이유 불상.
                    if (control != null)
                        controls.Add(control);
                }

                else if (field.FieldType.IsSubclassOf(typeof (UserControl)))
                    GetChildrenCore((UserControl) field.GetValue(container), controls);
            }
        }

        /// <summary>
        ///     컨트롤의 부모를 거슬러 올라가며 타입이 T 인 컨트롤을 찾는다.
        /// </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="from"> </param>
        /// <returns> </returns>
        public static T FindInAncestors<T>(this Control from) where T : Control
        {
            Control control = from;

            while (true)
            {
                if (control is T)
                    return (T) control;

                control = control.Parent;

                if (control == null)
                    return null;
            }
        }
    }
}