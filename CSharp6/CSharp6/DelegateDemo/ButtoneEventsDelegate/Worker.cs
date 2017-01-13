namespace CSharp6.DelegateDemo.ButtoneEventsDelegate
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            Control c = new Control();

            Button b = new Button();
            b.Subscribe(c);

            Link l = new Link();
            l.Subscribe(c);

            c.run();
        }
    }
}
