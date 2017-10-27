using Android.App;
using Android.Widget;
using Android.OS;

namespace Casus_Jaar_2_Blok_1_Groep_3
{
    [Activity(Label = "Casus_Jaar_2_Blok_1_Groep_3", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.LayoutMenu);

            btnMenuNetflix = FindViewById<Button>(Resource.Id.btnNetflix);
            btnMenuNetflix.Click += delegate
            {
                openNetflixMenu();   
            };

            btnMenuYoutube = FindViewById<Button>(Resource.Id.btnYoutube);
            btnMenuYoutube.Click += delegate
            {
                openYoutubeMenu();
            };

            btnMenuZiggo = FindViewById<Button>(Resource.Id.btnNetflix);
            btnMenuZiggo.Click += delegate
            {
                openZiggoMenu();
            };

            btnMenuInstellingen = FindViewById<Button>(Resource.Id.btnInstellingen);
            {

            };
        }
        private void openNetFlixMenu()
        {
            SetContentView(Resource.Layout.LayoutNetflixMenu);
        }

        private void openYoutubeMenu()
        {
            SetContentView(Resource.Layout.LayoutYoutubeMenu);
        }

        private void openZiggoMenu()
        {
            SetContentView(Resource.Layout.LayoutZiggoMenu);
        }
    }
}

