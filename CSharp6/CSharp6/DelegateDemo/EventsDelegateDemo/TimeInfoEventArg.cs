namespace CSharp6.DelegateDemo.EventsDelegateDemo
{
    public class TimeInfoEventArg
    {
        public int Hour { get; set; }
        public int Min { get; set; }

        public int Sec { get; set; }

        public TimeInfoEventArg(int h, int m, int s)
        {
            Hour = h;
            Min = m;
            Sec = s;
        }
    }
}
