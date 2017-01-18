using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.App.Service;
using Xamarin.App.Droid.Adapter;

namespace Xamarin.App.Droid
{
    [Activity(Label = "HotDogMenuActivity", MainLauncher =true)]
    public class HotDogMenuActivity : Activity
    {
        private ListView hotDogListView;
        private List<HotDog> allHotDogs;
        private HotDogDataService hotDogDataService;

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.HotDogMenuView);

            //Find Control
            hotDogListView = FindViewById<ListView>(Resource.Id.hotDogListView);

            //Get List from dataservice
            hotDogDataService = new HotDogDataService();
            allHotDogs = hotDogDataService.GetAllHotDogs();

            //Bind it to listview
            hotDogListView.Adapter = new HotDogListAdapter(this, allHotDogs);
        }
    }
}