using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Adventure_Game.By_Joel_schl
{
    public partial class AdventureGameForm : Form
    {
        int page = 1;
        public AdventureGameForm()
        {
            InitializeComponent();
            // QuestionButton.Enabled = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //StartButtonClickLabel.Text = ".";
            //StartButtonClickLabel.Enabled = false;
            //StartButton.Enabled = false;
            //QuestionButton.Enabled = true;
        }

        private void Option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 7;

            }
            else if (page == 2)
            {
                page = 2;
            }
            else if (page == 3)
            {
                page = 3;
            }
            else if (page == 4)
            {
                page = 4;
            }
            else if (page == 5)
            {
                page = 5;
            }
            else if (page == 6)
            {
                page = 6;
            }
            else if (page == 7)
            {
                page = 16;
            }
            else if (page == 8)
            {
                
            }
            else if (page == 9)
            {
                page = 9;
            }
            else if (page == 10)
            {
                page = 10;
            }
            else if (page == 11)
            {
                page = 11;
            }
            else if (page == 12)
            {
                page = 12;
            }
            else if (page == 13)
            {
                page = 13;
            }
            else if (page == 14)
            {
                page = 14;
            }
            else if (page == 15)
            {
                page = 15;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                page = 17;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }
            switch (page)
            {
                case 1:
                    OutputLabel.Text = "You are a green slime going to the local convience stores nearby";
                    Option1Label.Text = "Go to the 1st store";
                    Option2Label.Text = "Go to the 2nd store";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    OutputLabel.Text = "You slide infront of the 1st store";
                    Option1Label.Text = "Do you slide underneath the door?";
                    Option2Label.Text = "Do you wait for someone to open the door?";
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    OutputLabel.Text = "You try sliding underneath but the bottom of the door is the most foul disguisting place you have ever seen, you slide underneath and become filthy";
                    Option1Label.Text = "be dirty";
                    Option2Label.Text = "Don't be dirty";
                    break;
                case 17:
                    break;
                case 18:
                    OutputLabel.Text = "Your slimy geletin of a body starts to break into small hardened chunks and you dry up. (until the next rainy day)";
                    Option1Label.Text = "Click me";
                    Option2Label.Text = "_";
                    break;
                case 19:
                    OutputLabel.Text = "Play Again?";
                    Option1Label.Text = "Yes";
                    Option2Label.Text = "No";
                    break;
                case 20:
                    OutputLabel.Text = "Ok";
                    Option1Label.Text = "Click me Again";
                    Option2Label.Text = "Changed my mind (Closes Game)";
                    break;
                case 21:
                    OutputLabel.Text = "You stand there as more slimes and regular everyday humans enter the store stepping over you trying not to make a mess";
                    Option1Label.Text = "Keep Waiting";
                    Option2Label.Text = "Leave";
                    break;
                
                
            }
        }

        private void Option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 1;

            }
            else if (page == 2)
            {
                page = 2;
            }
            else if (page == 3)
            {
                page = 3;
            }
            else if (page == 4)
            {
                page = 4;
            }
            else if (page == 5)
            {
                page = 5;
            }
            else if (page == 6)
            {
                page = 6;
            }
            else if (page == 7)
            {
                Random random = new Random();
                int chance = random.Next(1, 101);
                if (chance < 60)
                {
                    page = 8;
                }
                else
                {
                    page = 21;
                }
            }
            else if (page == 8)
            {
                page = 8;
            }
            else if (page == 9)
            {
                page = 9;
            }
            else if (page == 10)
            {
                page = 10;
            }
            else if (page == 11)
            {
                page = 11;
            }
            else if (page == 12)
            {
                page = 12;
            }
            else if (page == 13)
            {
                page = 13;
            }
            else if (page == 14)
            {
                page = 14;
            }
            else if (page == 15)
            {
                page = 15;
            }
            else if (page == 16)
            {
                page = 16;
            }
            else if (page == 17)
            {
                page = 17;
            }
            else if (page == 18)
            {
                page = 18;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 0;
            }
           
            switch (page)
            {
                case 1:
                    OutputLabel.Text = "You go to the 2nd store which has its door hung open";
                    Option1Label.Text = "Talk to the store clerk";
                    Option2Label.Text = "Don't talk to the store clerk";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:

                    break;
                case 20:
                    OutputLabel.Text = "Ok Bye";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                case 21:

                    break;
                
            }
        }
    }
}
