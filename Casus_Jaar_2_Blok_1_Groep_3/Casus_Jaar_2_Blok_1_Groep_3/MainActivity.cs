using Android.App;
using Android.Widget;
using Android.OS;

namespace Casus_Jaar_2_Blok_1_Groep_3
{
    [Activity(Label = "Casus_Jaar_2_Blok_1_Groep_3", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button btnMenuNetflix;
        private Button btnMenuZiggo;
        private Button btnMenuYoutube;
        private Button btnMenuInstellingen;
        private Button btnTerugInst;
        private Button btnAccToevoegen;
        private Button btnAccVerwijderen;
        private Button btnTaalVeranderen;
        private string huidigeTaal;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main); //LayoutMenu);
            huidigeTaal = "Nederlands";
            openMenu();
        }

        private void openMenu()
        {
            btnMenuNetflix = FindViewById<Button>(Resource.Id.btnNetflix);
            btnMenuNetflix.Click += delegate
            {
                string program = "Netflix";
                openProgram(program);
            };

            btnMenuYoutube = FindViewById<Button>(Resource.Id.btnYoutube);
            btnMenuYoutube.Click += delegate
            {
                string program = "Youtube";
                openProgram(program);
            };

            btnMenuZiggo = FindViewById<Button>(Resource.Id.btnZiggo);
            btnMenuZiggo.Click += delegate
            {
                string program = "Ziggo";
                openProgram(program);
            };

            btnMenuInstellingen = FindViewById<Button>(Resource.Id.btnInstellingen);
            btnMenuInstellingen.Click += delegate
            {
                openInstellingen();
            };
        }

        private void openProgram(string program)
        {
            SetContentView(Resource.Layout.LayoutOpenProgram);
            Button btnTerugOP = FindViewById<Button>(Resource.Id.btnTerugOpenProgram);
            btnTerugOP.Click += delegate
            {
                SetContentView(Resource.Layout.main);
                openMenu();
            };
        }
        
        private void openInstellingen()
        {
            SetContentView(Resource.Layout.LayoutInstellingen);
            btnTerugInst = FindViewById<Button>(Resource.Id.btnInstellingenTerug);
            btnTerugInst.Click += delegate
            {
                SetContentView(Resource.Layout.main);
                openMenu();
            };

            btnAccToevoegen = FindViewById<Button>(Resource.Id.btnAccountToevoegen);
            btnAccToevoegen.Click += delegate
            {

            };

            btnAccVerwijderen = FindViewById<Button>(Resource.Id.btnAccountVerwijderen);
            btnAccVerwijderen.Click += delegate
            {

            };

            btnTaalVeranderen = FindViewById<Button>(Resource.Id.btnTaalVeranderen);
            btnTaalVeranderen.Click += delegate
            {
                if (huidigeTaal == "Nederlands")
                {
                    huidigeTaal = "Engels";
                }
                else
                {
                    if (huidigeTaal == "Engels")
                    {
                        huidigeTaal = "Nederlands";
                    }
                }
            };



        }
    }
}

