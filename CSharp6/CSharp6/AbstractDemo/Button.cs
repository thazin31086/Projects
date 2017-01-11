using static System.Console;


namespace CSharp6.AbstractDemo
{
    public class Button : Control
    {

        private string text;

        public Button(int xpos, int ypos, string text)
            :base(xpos,ypos)
        {
            this.text = text;
        }

        public override void Draw()
        {
            WriteLine($"Draw Button : {text}" );
        }
    }
}
