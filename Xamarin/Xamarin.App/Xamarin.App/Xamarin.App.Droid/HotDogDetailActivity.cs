
using Android.App;
using Android.OS;
using Android.Widget;
using System;
using Xamarin.App.Droid.Utility;
using Xamarin.App.Service;

namespace Xamarin.App.Droid
{
    [Activity(Label = "Hot Dog Detail")]
    public class HotDogDetailActivity : Activity
    {
        private ImageView hotDogImageView;
        private TextView hotDogNameTextView;
        private TextView shortDescriptionTextView;
        private TextView descriptionTextView;
        private TextView priceTextView;
        private EditText amountEditText;
        private Button cancelButton;
        private Button orderButton;

        private HotDog selectedHotDog;
        private HotDogDataService dataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HotDogDetailView);

            dataService = new HotDogDataService();
            selectedHotDog = dataService.GetHotDogById(1);
            // Create your application here
            FindViews();
            BindData();
            HandleEvents();
        }

        private void FindViews()
        {
            hotDogImageView = FindViewById<ImageView>(Resource.Id.HotDogImageView);
            hotDogNameTextView = FindViewById<TextView>(Resource.Id.HotDogNameTextView);
            shortDescriptionTextView = FindViewById<TextView>(Resource.Id.ShortDescriptionTextView);
            descriptionTextView = FindViewById<TextView>(Resource.Id.DescriptionTextView);
            priceTextView = FindViewById<TextView>(Resource.Id.PriceTextView);
            amountEditText = FindViewById<EditText>(Resource.Id.AmountEditText);
            cancelButton = FindViewById<Button>(Resource.Id.CancelButton);
            orderButton = FindViewById<Button>(Resource.Id.OrderButton);
        }

        private void BindData()
        {
            hotDogNameTextView.Text = selectedHotDog.Name;
            shortDescriptionTextView.Text = selectedHotDog.ShortDescription;
            descriptionTextView.Text = selectedHotDog.Description;
            priceTextView.Text = $"Price: {descriptionTextView.Text}";
            var imgBitMap = ImageHelper.GetImageBitmapFromUrl("http://http://www.planwallpaper.com/static/images/image-slider-2.jpg");
            hotDogImageView.SetImageBitmap(imgBitMap);
        }

        private void HandleEvents()
        {
            orderButton.Click += OrderButton_click;
            cancelButton.Click += CancelButton_click;
        }

        private void CancelButton_click(object sender, EventArgs e)
        {
            //toDo
        }

        private void OrderButton_click(object sender, EventArgs e)
        {
            var dialog = new AlertDialog.Builder(this);
            dialog.SetTitle("Confirmation");
            dialog.SetMessage("Your hot dog has been add to your cart");
            dialog.Show();
        }
    }
}