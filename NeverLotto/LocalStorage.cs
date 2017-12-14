#region
using System;
using System.Deployment.Application;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

#endregion

namespace NeverLotto
{
    public class LocalStorage
    {
        public static string StorageDirectory
        {
            get
            {
                return (ApplicationDeployment.IsNetworkDeployed)
                           ? ApplicationDeployment.CurrentDeployment.DataDirectory + "\\"
                           : Environment.CurrentDirectory + "\\";
            }
        }

        public static string GetPath(string fileName)
        {
            return StorageDirectory + fileName;
        }

        public static string ToFullName(string fileName)
        {
            return Path.GetDirectoryName(fileName).Length == 0 ? GetPath(fileName) : fileName;
        }

        public static void WriteAllLines(string fileName, string[] lines)
        {
            File.WriteAllLines(ToFullName(fileName), lines);
        }

        public static string[] ReadAllLines(string fileName)
        {
            return File.ReadAllLines(ToFullName(fileName));
        }

        public static void WriteAllText(string fileName, string contents)
        {
            File.WriteAllText(ToFullName(fileName), contents);
        }

        public static string ReadAllText(string fileName)
        {
            return File.ReadAllText(ToFullName(fileName));
        }

        public static void WriteAllBytes(string fileName, byte[] bytes)
        {
            File.WriteAllBytes(ToFullName(fileName), bytes);
        }

        public static byte[] ReadAllBytes(string fileName)
        {
            return File.ReadAllBytes(ToFullName(fileName));
        }

        public static bool Exists(string fileName)
        {
            return File.Exists(ToFullName(fileName));
        }

        public static void DeleteAllFiles()
        {
            var files = Directory.GetFiles(StorageDirectory);
            Array.ForEach(files, File.Delete);
        }

        public static bool DeleteFile(string fileName)
        {
            if (Exists(fileName))
            {
                try
                {
                    File.Delete(ToFullName(fileName));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
                return false;
        }

        public static string SerializeToString<T>(T @object) where T : class
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof (T));
                serializer.WriteObject(stream, @object);

                string text = Encoding.UTF8.GetString(stream.ToArray());

                stream.Close();

                return text;
            }
        }

        public static void SerializeToFile<T>(string fileName, T @object) where T : class
        {
            var bytes = SerializeToString(@object);
            WriteAllText(fileName, bytes);
        }

        public static T DeserializeFromString<T>(string text) where T : class
        {
            var bytes = Encoding.UTF8.GetBytes(text);

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof (T));
                var @object = (T) serializer.ReadObject(stream);

                stream.Close();

                return @object;
            }
        }

        public static T DeserializeFromFile<T>(string fileName) where T : class
        {
            var text = ReadAllText(fileName);
            return DeserializeFromString<T>(text);
        }

        public static string[] SearchFiles(string searchPattern)
        {
            return Directory.GetFiles(StorageDirectory, searchPattern, SearchOption.TopDirectoryOnly);
        }
    }
}