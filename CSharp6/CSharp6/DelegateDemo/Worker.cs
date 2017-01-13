using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.DelegateDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            var mediaInventory = new MediaInventory();
            var recordPlayer = new RecordPlayer();
            var cassettePlayer = new CassettePlayer();

            MediaInventory.TestMedia recordmedia = new MediaInventory.TestMedia(recordPlayer.PlayRecord);
            MediaInventory.TestMedia cassettemedia = new MediaInventory.TestMedia(cassettePlayer.PlayRecord);
            mediaInventory.TestResult(recordmedia);
            mediaInventory.TestResult(cassettemedia);
        }
    }
}
