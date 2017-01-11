using static System.Console;

namespace CSharp6.AbstractDemo
{
    public abstract class Control
    {
        protected int xPos;
        protected int yPos;

        public Control(int xpos, int ypos)
        {
            xPos = xpos;
            yPos = ypos;
        }

        public virtual void Clear()
        {
            WriteLine("Clear Control");
        }

        public abstract void Draw();
    }
}
