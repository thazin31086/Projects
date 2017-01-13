using System;
using System.Threading;

namespace CSharp6.DelegateDemo.EventsDelegateDemo
{
    public class Clock
    {
        private int sec;

        public delegate void SecondChangedHandler(object clock, TimeInfoEventArg timeInfo);

        public event SecondChangedHandler SecondChanged;


        public void Run()
        {
            for (;;)
            {
                Thread.Sleep(100);
                if (DateTime.Now.Second != sec)
                {
                    TimeInfoEventArg ta = new TimeInfoEventArg(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    if (SecondChanged != null) //haven't register
                    {
                        SecondChanged(this, ta);
                    }
                }
            }
        }
    }

}
