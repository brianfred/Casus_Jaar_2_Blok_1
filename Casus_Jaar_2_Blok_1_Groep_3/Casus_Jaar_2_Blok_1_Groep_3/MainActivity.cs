using Android.App;
using Android.Widget;
using Android.OS;

namespace Casus_Jaar_2_Blok_1_Groep_3
{
    [Activity(Label = "Casus_Jaar_2_Blok_1_Groep_3", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button btnZoeken;
        private Button btnZoekenZoeken;
        private TextView txtSearch;
        private EditText etZoekveld;
        private Button btnMenuNetflix;
        private Button btnMenuZiggo;
        private Button btnMenuYoutube;
        private Button btnMenuInstellingen;
        private Button btnTerugInst;
        private Button btnAccToevoegen;
        private Button btnAccVerwijderen;
        private Button btnTaalVeranderen;
        private Button btnFavorieten;
        private Button btnMenuFav;
        private Button btnInstellingenFav;
        private Button btnMenuAccT;
        private Button btnInloggen;
        private Button btnInstellingenAccT;
        private Button btnInstMenu;
        private Button btnNetflixFavorieten1;
        private Button btnNetflixFavorieten2;
        private Button btnNetflixFavorieten3;
        private Button btnNetflixFavorieten4;
        private Button btnYoutubeFavorieten1;
        private Button btnYoutubeFavorieten2;
        private Button btnYoutubeFavorieten3;
        private Button btnYoutubeFavorieten4;
        private Button btnZiggoFavorieten1;
        private Button btnZiggoFavorieten2;
        private Button btnZiggoFavorieten3;
        private Button btnZiggoFavorieten4;
        private Button btnLogoAccount;
        private Button btnMenuAccV;
        private Button btnInstellingenAccV;
        private Button btnNetflixAccV;
        private Button btnYoutubeAccV;
        private Button btnZiggoAccV;
        private TextView txtNetflixAcc;
        private TextView txtYoutubeAcc;
        private TextView txtZiggoAcc;
        private TextView txtOpenProgram;
        private EditText etUsername;
        private EditText etPassword;
        private string huidigeTaal;
        private string NetflixUsername;
        private string NetflixPassword;
        private string YoutubeUsername;
        private string YoutubePassword;
        private string ZiggoUsername;
        private string ZiggoPassword;
        private string LogoAccountMaken;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main); //LayoutMenu);
            huidigeTaal = "Nederlands";
            NetflixUsername = "Geen Account";
            YoutubeUsername = "Geen Account";
            ZiggoUsername = "Geen Account";
            NetflixPassword = "";
            ZiggoPassword = "";
            YoutubePassword = "";
            LogoAccountMaken = "Netflix";
            OpenMenu();
        }

        private void OpenMenu()
        {
            SetContentView(Resource.Layout.main);
            string program = "";
            string komtVanProgram = "Menu";
            btnMenuNetflix = FindViewById<Button>(Resource.Id.btnNetflix);
            btnMenuNetflix.Click += delegate
            {
                program = "Netflix";
                OpenProgram(program, komtVanProgram);
            };

            btnMenuYoutube = FindViewById<Button>(Resource.Id.btnYoutube);
            btnMenuYoutube.Click += delegate
            {
                program = "Youtube";
                OpenProgram(program, komtVanProgram);
            };

            btnMenuZiggo = FindViewById<Button>(Resource.Id.btnZiggo);
            btnMenuZiggo.Click += delegate
            {
                program = "Ziggo";
                OpenProgram(program, komtVanProgram);
            };

            btnMenuInstellingen = FindViewById<Button>(Resource.Id.btnInstellingen);
            btnMenuInstellingen.Click += delegate
            {
                string PaginaVandaan = "Menu";
                OpenInstellingen(PaginaVandaan);
            };
        }

        private void OpenProgram(string program, string komtVanProgram)
        {
            SetContentView(Resource.Layout.LayoutOpenProgram);
            TextView txtOpenProgram = FindViewById<TextView>(Resource.Id.txtOpenProgram);
            txtOpenProgram.Text = string.Format("U gaat nu naar {0}", program);
            Button btnTerugOP = FindViewById<Button>(Resource.Id.btnTerugOpenProgram);
            btnTerugOP.Click += delegate
            {
                if (komtVanProgram == "Menu")
                {
                    OpenMenu();
                }
                if (komtVanProgram == "Favorieten")
                {
                    Favorieten();
                }
            };
        }
        
        private void OpenInstellingen(string PaginaVandaan)
        {
            SetContentView(Resource.Layout.LayoutInstellingen);
            btnTerugInst = FindViewById<Button>(Resource.Id.btnInstellingenTerug);
            btnTerugInst.Click += delegate
            {
                if (PaginaVandaan == "Menu")
                {
                    OpenMenu();
                }

                if (PaginaVandaan == "Fav")
                {
                    Favorieten();
                }

                if (PaginaVandaan == "AccT")
                {
                    AccToevoegen();
                }

                if (PaginaVandaan == "AccV")
                {
                    AccVerwijderen();
                }
                    
            };

            btnAccToevoegen = FindViewById<Button>(Resource.Id.btnAccountToevoegen);
            btnAccToevoegen.Click += delegate
            {
                AccToevoegen();
            };

            btnAccVerwijderen = FindViewById<Button>(Resource.Id.btnAccountVerwijderen);
            btnAccVerwijderen.Click += delegate
            {
                AccVerwijderen();
            };
            btnTaalVeranderen = FindViewById<Button>(Resource.Id.btnTaalVeranderen);
            if (huidigeTaal == "Nederlands")
            {
                btnTaalVeranderen.Text = string.Format("Taal: {0}", huidigeTaal);
            }
            
            if (huidigeTaal == "English")
            {
                btnTaalVeranderen.Text = string.Format("Language: {0}", huidigeTaal);
            }
            btnTaalVeranderen.Click += delegate
            {
                if (huidigeTaal == "Nederlands")
                {
                    huidigeTaal = "English";
                    btnTaalVeranderen.Text = string.Format("Language: {0}", huidigeTaal);
                }
                else
                {
                    if (huidigeTaal == "English")
                    {
                        huidigeTaal = "Nederlands";
                        btnTaalVeranderen.Text = string.Format("Taal: {0}", huidigeTaal);
                    }
                }
                
            };
            btnFavorieten = FindViewById <Button>(Resource.Id.btnFavorieten);
            btnFavorieten.Click += delegate
            {
                Favorieten();
            };

            btnInstMenu = FindViewById<Button>(Resource.Id.btnInstMenu);
            btnInstMenu.Click += delegate
            {
                OpenMenu();
            };

        }
        private void AccToevoegen()
        {
            SetContentView(Resource.Layout.LayoutAccountToevoegen);
            btnInstellingenAccT = FindViewById<Button>(Resource.Id.btnInstellingenAccT);
            btnMenuAccT = FindViewById<Button>(Resource.Id.btnTerugNaarMenuAccT);
            btnLogoAccount = FindViewById<Button>(Resource.Id.btnLogoAccount);
            etUsername = FindViewById<EditText>(Resource.Id.etUsername);
            etPassword = FindViewById<EditText>(Resource.Id.etPassword);
            btnInloggen = FindViewById<Button>(Resource.Id.btnInloggen);
            etUsername.Text = "Username";
            etPassword.Text = "Password";
            btnLogoAccount.Text = string.Format("{0}", LogoAccountMaken);
            btnInstellingenAccT.Click += delegate
            {
                string PaginaVandaan = "AccT";
                OpenInstellingen(PaginaVandaan);
            };

            btnMenuAccT.Click += delegate
            {
                OpenMenu();
            };

            btnLogoAccount.Click += delegate
            {
                if (LogoAccountMaken == "Netflix")
                {
                    LogoAccountMaken = "Youtube";
                }
                else
                {
                    if (LogoAccountMaken == "Youtube")
                    {
                        LogoAccountMaken = "Ziggo";
                    }
                    else
                    {
                        if (LogoAccountMaken == "Ziggo")
                        {
                            LogoAccountMaken = "Netflix";
                        }
                    }
                }
                btnLogoAccount.Text = string.Format("{0}", LogoAccountMaken);
                
            };

            btnInloggen.Click += delegate
            {
                if (etUsername.Text != "" && etUsername.Text != "Username" && etPassword.Text != "" && etPassword.Text != "Password")
                {
                        if (LogoAccountMaken == "Youtube")
                        {
                            YoutubeUsername = etUsername.Text;
                            YoutubePassword = etPassword.Text;
                        }

                        if (LogoAccountMaken == "Netflix")
                        {
                            NetflixUsername = etUsername.Text;
                            NetflixPassword = etPassword.Text;
                        }

                        if (LogoAccountMaken == "Ziggo")
                        {
                            ZiggoUsername = etUsername.Text;
                            ZiggoPassword = etPassword.Text;
                        
                        }
                }
                AccToevoegen();
            };

            





        }

        private void AccVerwijderen()
        {
            SetContentView(Resource.Layout.LayoutAccountVerwijderen);
            btnInstellingenAccV = FindViewById<Button>(Resource.Id.btnInstellingenAccV);
            btnMenuAccV = FindViewById<Button>(Resource.Id.btnMenuAccV);
            btnNetflixAccV = FindViewById<Button>(Resource.Id.btnNetflixAccountVerwijderen);
            btnYoutubeAccV = FindViewById<Button>(Resource.Id.btnYoutubeAccountVerwijderen);
            btnZiggoAccV = FindViewById<Button>(Resource.Id.btnZiggoAccountVerwijderen);
            txtNetflixAcc = FindViewById<TextView>(Resource.Id.txtNetflixAccountVerwijderen);
            txtYoutubeAcc = FindViewById<TextView>(Resource.Id.txtYoutubeAccountVerwijderen);
            txtZiggoAcc = FindViewById<TextView>(Resource.Id.txtZiggoAccountVerwijderen);
            txtNetflixAcc.Text = string.Format("{0}", NetflixUsername);
            txtZiggoAcc.Text = string.Format("{0}", ZiggoUsername);
            txtYoutubeAcc.Text = string.Format("{0}", YoutubeUsername);

            btnInstellingenAccV.Click += delegate
            {
                string PaginaVandaan = "AccV";
                OpenInstellingen(PaginaVandaan);
            };

            btnMenuAccV.Click += delegate
            {
                OpenMenu();
            };

            btnNetflixAccV.Click += delegate
            {
                NetflixUsername = "Geen Account";
                NetflixPassword = "";
                txtNetflixAcc.Text = string.Format("{0}", NetflixUsername);
            };

            btnYoutubeAccV.Click += delegate
            {
                YoutubeUsername = "Geen Account";
                YoutubePassword = "";
                txtYoutubeAcc.Text = string.Format("{0}", YoutubeUsername);
            };

            btnZiggoAccV.Click += delegate
            {
                ZiggoUsername = "Geen Account";
                ZiggoPassword = "";
                txtZiggoAcc.Text = string.Format("{0}", ZiggoUsername);
            };

        }

        private void Favorieten()
        {
            SetContentView(Resource.Layout.LayoutFavorieten);
            btnMenuFav = FindViewById<Button>(Resource.Id.btnMenuFav);
            btnMenuFav.Click += delegate
            {
                OpenMenu();
            };

            btnInstellingenFav = FindViewById<Button>(Resource.Id.btnInstellingenFav);
            btnInstellingenFav.Click += delegate
            {
                string paginavandaan = "Fav";
                OpenInstellingen(paginavandaan);
            };

            btnNetflixFavorieten1 = FindViewById<Button>(Resource.Id.btnNetflixFavorieten1);
            btnNetflixFavorieten2 = FindViewById<Button>(Resource.Id.btnNetflixFavorieten2);
            btnNetflixFavorieten3 = FindViewById<Button>(Resource.Id.btnNetflixFavorieten3);
            btnNetflixFavorieten4 = FindViewById<Button>(Resource.Id.btnNetflixFavorieten4);
            btnZiggoFavorieten1 = FindViewById<Button>(Resource.Id.btnZiggoFavorieten1);
            btnZiggoFavorieten2 = FindViewById<Button>(Resource.Id.btnZiggoFavorieten2);
            btnZiggoFavorieten3 = FindViewById<Button>(Resource.Id.btnZiggoFavorieten3);
            btnZiggoFavorieten4 = FindViewById<Button>(Resource.Id.btnZiggoFavorieten4);
            btnYoutubeFavorieten1 = FindViewById<Button>(Resource.Id.btnYoutubeFavorieten1);
            btnYoutubeFavorieten2 = FindViewById<Button>(Resource.Id.btnYoutubeFavorieten2);
            btnYoutubeFavorieten3 = FindViewById<Button>(Resource.Id.btnYoutubeFavorieten3);
            btnYoutubeFavorieten4 = FindViewById<Button>(Resource.Id.btnYoutubeFavorieten4);
            string program = "";
            string komtVanProgram = "Favorieten";
            btnNetflixFavorieten1.Click += delegate
            {
                program = "Netflix Fav 1";
                OpenProgram(program, komtVanProgram);
            };
            btnNetflixFavorieten2.Click += delegate
            {
                program = "Netflix Fav 2";
                OpenProgram(program, komtVanProgram);
            };
            btnNetflixFavorieten3.Click += delegate
            {
                program = "Netflix Fav 3";
                OpenProgram(program, komtVanProgram);
            };
            btnNetflixFavorieten4.Click += delegate
            {
                program = "Netflix Fav 4";
                OpenProgram(program, komtVanProgram);
            };

            btnYoutubeFavorieten1.Click += delegate
            {
                program = "Youtube Fav 1";
                OpenProgram(program, komtVanProgram);
            };
            btnYoutubeFavorieten2.Click += delegate
            {
                program = "Youtube Fav 2";
                OpenProgram(program, komtVanProgram);
            };
            btnYoutubeFavorieten3.Click += delegate
            {
                program = "Youtube Fav 3";
                OpenProgram(program, komtVanProgram);
            };
            btnYoutubeFavorieten4.Click += delegate
            {
                program = "Youtube Fav 4";
                OpenProgram(program, komtVanProgram);
            };
            btnZiggoFavorieten1.Click += delegate
            {
                program = "Ziggo Go Fav 1";
                OpenProgram(program, komtVanProgram);
            };
            btnZiggoFavorieten2.Click += delegate
            {
                program = "Ziggo Go Fav 2";
                OpenProgram(program, komtVanProgram);
            };
            btnZiggoFavorieten3.Click += delegate
            {
                program = "Ziggo Go Fav 3";
                OpenProgram(program, komtVanProgram);
            };
            btnZiggoFavorieten4.Click += delegate
            {
                program = "Ziggo Go Fav 4";
                OpenProgram(program, komtVanProgram);
            };
        }
    }
}

