using Android.Graphics;
using System.Net;

namespace Xamarin.App.Droid.Utility
{
    public class ImageHelper
    {
        public static Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imgBit = null;
            using (var webclient = new WebClient())
            {
                var imgByte = webclient.DownloadData(url);
                if (imgByte != null && imgByte.Length > 0)
                {
                    imgBit = BitmapFactory.DecodeByteArray(imgByte, 0, imgByte.Length);
                }
            }

            return imgBit;
        }
    }
}