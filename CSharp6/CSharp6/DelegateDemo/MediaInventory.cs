using static System.Console;
namespace CSharp6.DelegateDemo
{
    public class MediaInventory
    {
        public delegate bool TestMedia();
        public void TestResult(TestMedia mediaDelegate) {
            if (mediaDelegate())
            {
                WriteLine("Work. Add");
            }
            else
            {
                WriteLine("Media Failed");
            }
        }   
    }
}
