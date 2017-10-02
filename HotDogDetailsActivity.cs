
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RaysHotdogs.Core.Model;
using RaysHotdogs.Core.Services;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RaysHotDogs
{
    [Activity(Label = "Hot dog detail", MainLauncher = true)]
    public class HotDogDetailsActivity : Activity
    {
        private ImageView hotDogImageView;
        private TextView hotDogNameTExtView;
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
            HotDogDataService dataService = new HotDogDataService();
            selectedHotDog = dataService.GetHotDogByID(1);


            FindViews();
            BindData();
        }
        private void FindViews()
        {
            hotDogImageView = FindViewById<ImageView>(Resource.Id.hotDogImageView);
            hotDogNameTExtView = FindViewById<TextView>(Resource.Id.hotDogNameTExtView);
            shortDescriptionTextView = FindViewById<TextView>(Resource.Id.shortDescriptionTextView);
            descriptionTextView = FindViewById<TextView>(Resource.Id.descriptionTextView);
            priceTextView = FindViewById<TextView>(Resource.Id.priceTextView);
            amountEditText = FindViewById<TextView>(Resource.Id.amountEditText);
            cancelButton = FindViewById<TextView>(Resource.Id.cancelButton);
            orderButton = FindViewById<TextView>(Resource.Id.orderButton);

        }

        private void BindData()
        {
            hotDogNameTExtView.Text = selectedHotDog.name;
            shortDescriptionTextView.Text = selectedHotDog.ShortDescription;
            descriptionTextView.Text = selectedHotDog.Description;
            priceTextView.Text = "Price:" + selectedHotDog.Price;


        }







    }
}
