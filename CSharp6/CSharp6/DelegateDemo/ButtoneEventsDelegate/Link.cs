using System;

namespace CSharp6.DelegateDemo.ButtoneEventsDelegate
{
    public class Link
    {
        private int count;

        public void Subscribe(Control c)
        {
            c.clickcount += ClickCount;
        }
     
        void ClickCount()
        {
            Console.WriteLine("Link Click " + count++);
        }
    }
}
