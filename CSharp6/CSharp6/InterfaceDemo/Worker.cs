namespace CSharp6.InterfaceDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Document doc1 = new Document();
            doc1.Reformat();
            doc1.Read("myfile");
            doc1.Speak();

            IStorable doc2 = new Document();
            doc2.Read("myFile");
            doc2.Write("myFile");

            ISpeak doc3 = new Document();
            doc3.Speak();

            Document doc4 = new Memo();
            doc4.Reformat();
            doc4.Read("MyFile");

            Memo doc5 = new Memo();
            doc5.Read("myfile");
            doc5.Reformat();
            doc5.MemoTo = "Jasmine";
        }
    }
}
