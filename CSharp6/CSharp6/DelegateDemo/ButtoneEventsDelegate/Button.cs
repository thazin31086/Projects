using System;

namespace CSharp6.DelegateDemo.ButtoneEventsDelegate
{
    public class Button
    {
        private int count;

        public void Subscribe(Control c)
        {
            c.clickcount += ClickCount;
        }
        void ClickCount() {
            Console.WriteLine("Buton Click " + count++); 
        }

    }
}
