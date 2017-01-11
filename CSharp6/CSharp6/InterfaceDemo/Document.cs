using static System.Console;

namespace CSharp6.InterfaceDemo
{
    public class Document: IStorable, ISpeak
    {
        public double DurationOfSpeech
        {
            get
            {
                return 42;
            }
        }

        public void Read(string filename)
        {
            WriteLine($"Reading from {filename}");

        }

        public void Write(string filename)
        {
            WriteLine($"Write from {filename}");         
        }


        public void Reformat()
        {
            WriteLine("Reformatting");
        }

        public void Speak()
        {
            WriteLine($"Speaking");
        }
    }
}
