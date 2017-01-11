using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.AbstractDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            List<Control> controls = new List<Control>();
            Button button1 = new Button(0, 100, "Add");
            ListBox list = new ListBox(100, 300, new List<string>());
            Button button2 = new Button(0, 100, "Cancel");

            controls.Add(button1);
            controls.Add(button2);
            controls.Add(list);

            foreach (Control item in controls)
            {
                item.Draw();
            }
        }
    }
}
