using static System.Console;


namespace CSharp6.DelegateDemo.EventsDelegateDemo
{
    public class Log
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += LogTime;
        }

        public void LogTime(object o, TimeInfoEventArg t)
        {
            WriteLine($"Logging : Hour: {t.Hour.ToString()}, Min : {t.Min.ToString()}, Sec : {t.Sec.ToString()}");
        }
    }
}
