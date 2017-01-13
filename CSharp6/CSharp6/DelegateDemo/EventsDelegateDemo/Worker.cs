namespace CSharp6.DelegateDemo.EventsDelegateDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Clock c = new Clock();
            DigitalClock dc = new DigitalClock();
            dc.Subscribe(c);
            var log = new Log();
            log.Subscribe(c);
            c.Run();
        }
    }
}
