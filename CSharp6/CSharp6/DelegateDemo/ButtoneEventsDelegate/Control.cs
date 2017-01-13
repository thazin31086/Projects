namespace CSharp6.DelegateDemo.ButtoneEventsDelegate
{
    public class Control
    {     
        public delegate void ControlClickHandler();
        public event ControlClickHandler clickcount;

        public void run()
        {
            for (int i = 0; i < 20; i++)
            {
                clickcount(); 
            }
        }
    }
}
