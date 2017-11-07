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
        private Button btnFavorieten;
        private string huidigeTaal;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main); //LayoutMenu);
            huidigeTaal = "Nederlands";
            OpenMenu();
        }

        private void OpenMenu()
        {
            btnMenuNetflix = FindViewById<Button>(Resource.Id.btnNetflix);
            btnMenuNetflix.Click += delegate
            {
                string program = "Netflix";
                OpenProgram(program);
            };

            btnMenuYoutube = FindViewById<Button>(Resource.Id.btnYoutube);
            btnMenuYoutube.Click += delegate
            {
                string program = "Youtube";
                OpenProgram(program);
            };

            btnMenuZiggo = FindViewById<Button>(Resource.Id.btnZiggo);
            btnMenuZiggo.Click += delegate
            {
                string program = "Ziggo";
                OpenProgram(program);
            };

            btnMenuInstellingen = FindViewById<Button>(Resource.Id.btnInstellingen);
            btnMenuInstellingen.Click += delegate
            {
                OpenInstellingen();
            };
        }

        private void OpenProgram(string program)
        {
            SetContentView(Resource.Layout.LayoutOpenProgram);
            Button btnTerugOP = FindViewById<Button>(Resource.Id.btnTerugOpenProgram);
            btnTerugOP.Click += delegate
            {
                SetContentView(Resource.Layout.main);
                OpenMenu();
            };
        }
        
        private void OpenInstellingen()
        {
            SetContentView(Resource.Layout.LayoutInstellingen);
            btnTerugInst = FindViewById<Button>(Resource.Id.btnInstellingenTerug);
            btnTerugInst.Click += delegate
            {
                SetContentView(Resource.Layout.main);
                OpenMenu();
            };

            btnAccToevoegen = FindViewById<Button>(Resource.Id.btnAccountToevoegen);
            btnAccToevoegen.Click += delegate
            {
                SetContentView(Resource.Layout.LayoutAccountToevoegen);
                
            };

            btnAccVerwijderen = FindViewById<Button>(Resource.Id.btnAccountVerwijderen);
            btnAccVerwijderen.Click += delegate
            {
                SetContentView(Resource.Layout.LayoutAccountVerwijderen);
            };

            btnTaalVeranderen = FindViewById<Button>(Resource.Id.btnTaalVeranderen);
            btnTaalVeranderen.Click += delegate
            {
                if (huidigeTaal == "Nederlands")
                {
                    huidigeTaal = "Engels";
                    btnTaalVeranderen.Text = "Language: English";
                }
                else
                {
                    if (huidigeTaal == "Engels")
                    {
                        huidigeTaal = "Nederlands";
                        btnTaalVeranderen.Text = "Taal: Nederlands";
                    }
                }
            };
            btnFavorieten = FindViewById <Button>(Resource.Id.btnFavorieten);
            btnFavorieten.Click += delegate
            {

            };
        }
    }
}

