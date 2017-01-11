using System.Collections.Generic;
using static System.Console;

namespace CSharp6.AbstractDemo
{
    public class ListBox : Control
    {
        private List<string> list = new List<string>();
        public ListBox(int xpos, int ypos, List<string> content):
            base(xpos, ypos)
        {
            list = content;
        }
        public override void Draw()
        {
            WriteLine("Listbox drawing");
        }
    }
}
