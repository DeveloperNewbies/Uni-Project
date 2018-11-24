using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Uni_GoyGoy
{
    public class UI
    {
        /* UI Decleration */
        RelativeLayout main_rl;
        RelativeLayout[] rl_ui;
        RelativeLayout rl_btns;

        Button[] btns;

        int button_padleft = 10;
        int button_padbot = 10;
        int buttons_height = 80;
        int buttons_width;

        public UI()
        {

            rlUI_Init();

            btns = new Button[5];
            btns_Init();


            /***** Initialize Ui for First use *****/
            Login_UI();
            ringTrack_UI();
            hashtagNews();
            studyExams();
            confessions();
            complaints();

        }


        /*********** UI Initialize **********/

        private void rlUI_Init()
        {
            /* rl_ui[0] = Login UI - 
             * rl_ui[1] = ring UI - 
             * rl_ui[2] = hastags UI - 
             * rl_ui[3] = studyexams UI - 
             * rl_ui[4] = hastags UI - 
             * rl_ui[5] = studyexams UI*/


            main_rl = new RelativeLayout();
            rl_ui = new RelativeLayout[6];
            for (int i = 0; i < rl_ui.GetLength(0); i++)
            {
                rl_ui[i] = new RelativeLayout();
                rl_ui[i].WidthRequest = Ekran.Android_Width;
                rl_ui[i].HeightRequest = Ekran.Android_Height;
            }



            rl_btns = new RelativeLayout();
            rl_btns.HeightRequest = 100;


        }

        /*********** end of UI Initialize **********/


        /*********** UI Buttons Initialize **********/

        private void btns_Init()
        {

            buttons_width = ((int)Ekran.Android_Width - (button_padleft * (btns.GetLength(0) + 1))) / btns.GetLength(0);

            Console.WriteLine("width: " + buttons_width);

            for (int i = 0; i < btns.GetLength(0); i++)
            {
                btns[i] = new Button
                {
                    Text = "Holy Fuck! İt Works! " + i,
                    FontSize = 13,
                    BackgroundColor = Color.Green,
                    TextColor = Color.Goldenrod,
                    WidthRequest = buttons_width,
                    HeightRequest = buttons_height
                };
            }

            btns[0].Clicked += UI_btn0Clicked;
            btns[1].Clicked += UI_btn1Clicked;
            btns[2].Clicked += UI_btn2Clicked;
            btns[3].Clicked += UI_btn3Clicked;
            btns[4].Clicked += UI_btn4Clicked;

            for (int i = 0; i < btns.GetLength(0); i++)
            {
                int c = buttons_width * i;
                int v = (i+1) * button_padleft;
                int k = buttons_height + button_padbot;

                rl_btns.Children.Add(btns[i],
                Constraint.RelativeToParent((x) => { return c + v; }),
                Constraint.RelativeToParent((x) => { return x.Height - k ; }));

                
            }


            /*for (int i = 0; i < rl_ui.GetLength(0); i++)
            {
                
                rl_ui[i].Children.Add(rl_btns,
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return x.Height - 100; }));

            }
            */

            main_rl.Children.Add(rl_ui[0],
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return 0; }));
            main_rl.Children.Add(rl_btns,
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return x.Height - 100; }));

        }

        private void UI_btn0Clicked(object sender, EventArgs e)
        {
            getLogin_UI();
        }
        private void UI_btn1Clicked(object sender, EventArgs e)
        {
            getRing_UI();
        }
        private void UI_btn2Clicked(object sender, EventArgs e)
        {
            getHashtagNews_UI();
        }
        private void UI_btn3Clicked(object sender, EventArgs e)
        {
            getConfessions_UI();
        }
        private void UI_btn4Clicked(object sender, EventArgs e)
        {
            getComplaints_UI();
        }

        /*********** End of UI Buttons Initialize **********/

        public RelativeLayout getScreen()
        {
            return main_rl;
        }


        /*********************** Giriş Sistemi Arayüzü ***************************/
        private void Login_UI()
        {
            
        }


        public void getLogin_UI()
        {
            rl_ui[0].BackgroundColor = Color.Red;
            main_rl.Children.RemoveAt(1);
            main_rl.Children.RemoveAt(0);
            main_rl.Children.Add(rl_ui[0], 
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return 0; }));
            main_rl.Children.Add(rl_btns,
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return x.Height - 100; }));
        }

        /***********************    Giriş Sistemi Arayüzü Sonu       ***************************/


        /*********************** Ring Takip Sistemi Arayüzü ***************************/

        private void ringTrack_UI()
        {

            

        }

        public void getRing_UI()
        {
            rl_ui[1].BackgroundColor = Color.Yellow;
            main_rl.Children.RemoveAt(1);
            main_rl.Children.RemoveAt(0);
            main_rl.Children.Add(rl_ui[1],
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return 0; }));
            main_rl.Children.Add(rl_btns,
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return x.Height - 100; }));
        }

        /***********************    Ring Takip Sistemi Arayüzü Sonu       ***************************/

        /*********************** Gündem Sistemi Arayüzü ***************************/
        private void hashtagNews()
        {

        }

        public void getHashtagNews_UI()
        {
            rl_ui[2].BackgroundColor = Color.Green;
            main_rl.Children.RemoveAt(1);
            main_rl.Children.RemoveAt(0);
            main_rl.Children.Add(rl_ui[2],
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return 0; }));
            main_rl.Children.Add(rl_btns,
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return x.Height - 100; }));
        }


        /***********************    Gündem Sistemi Arayüzü Sonu       ***************************/


        /*********************** Ders Notu Sistemi Arayüzü ***************************/
        private void studyExams()
        {

        }

        public void getStudyExams_UI()
        {
            rl_ui[3].BackgroundColor = Color.DarkBlue;
            main_rl.Children.RemoveAt(1);
            main_rl.Children.RemoveAt(0);
            main_rl.Children.Add(rl_ui[3],
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return 0; }));
            main_rl.Children.Add(rl_btns,
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return x.Height - 100; }));
        }

        /***********************    Ders Notu Paylaşım Sistemi Arayüzü Sonu       ***************************/


        /*********************** İtiraf Sistemi Arayüzü ***************************/
        private void confessions()
        {

        }

        public void getConfessions_UI()
        {
            rl_ui[4].BackgroundColor = Color.Purple;
            main_rl.Children.RemoveAt(1);
            main_rl.Children.RemoveAt(0);
            main_rl.Children.Add(rl_ui[4],
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return 0; }));
            main_rl.Children.Add(rl_btns,
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return x.Height - 100; }));
        }

        /***********************    İtiraf Sistemi Arayüzü Sonu       ***************************/


        /*********************** Şikayet Sistemi Arayüzü ***************************/
        private void complaints()
        {

        }

        public void getComplaints_UI()
        {
            rl_ui[5].BackgroundColor = Color.Orange;
            main_rl.Children.RemoveAt(1);
            main_rl.Children.RemoveAt(0);
            main_rl.Children.Add(rl_ui[5],
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return 0; }));
            main_rl.Children.Add(rl_btns,
                Constraint.RelativeToParent((x) => { return 0; }),
                Constraint.RelativeToParent((x) => { return x.Height - 100; }));
        }

        /***********************    Şikayet Sistemi Arayüzü Sonu       ***************************/
    }
}
