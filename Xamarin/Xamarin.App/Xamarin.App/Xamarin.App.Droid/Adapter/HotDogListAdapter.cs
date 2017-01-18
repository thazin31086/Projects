using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using Xamarin.App.Droid.Utility;

namespace Xamarin.App.Droid.Adapter
{
    public class HotDogListAdapter : BaseAdapter<HotDog>
    {
        List<HotDog> items;
        Activity context;

        public HotDogListAdapter(Activity context, List<HotDog> items):base()
        {
            this.context = context;
            this.items = items;
        }
        public override HotDog this[int position]
        {
            get
            {
                return items[position];
            }
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];


            var imageBitmap = ImageHelper.GetImageBitmapFromUrl("http://gillcleerenpluralsight.blob.core.windows.net/files/" + item.ImagePath + ".jpg");

            if (convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(Resource.Layout.HotDogMenuView, null);
            }

            convertView.FindViewById<TextView>(Resource.Id.HotDogNameTextView).Text = item.Name;
            convertView.FindViewById<TextView>(Resource.Id.ShortDescriptionTextView).Text = item.ShortDescription;
            convertView.FindViewById<TextView>(Resource.Id.PriceTextView).Text = "$ " + item.Price;
            convertView.FindViewById<ImageView>(Resource.Id.HotDogImageView).SetImageBitmap(imageBitmap);
            


            return convertView;
        }
    }
}