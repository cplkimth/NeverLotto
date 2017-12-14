namespace NeverLotto.Engine
{
    public class Bar
    {
        public Bar(int index, int value, string name)
        {
            Index = index;
            Value = value;
            Name = name;
        }

        public int Index { get; set; }

        public int Count { get; set; }
        
        public int Value { get; set; }
        
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1}) : {2}", Name, Value, Count);
        }
    }
}