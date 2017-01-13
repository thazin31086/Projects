namespace CSharp6.DelegateDemo.EventsDelegateDemo
{
    using static System.Console;
    public class DigitalClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += NewTime;
        }

        public void NewTime(object o, TimeInfoEventArg t)
        {
            WriteLine($"Hour: {t.Hour.ToString()}, Min : {t.Min.ToString()}, Sec : {t.Sec.ToString()}");
        }

    }
}
