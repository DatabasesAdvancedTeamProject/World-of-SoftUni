using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfSoftuniRPG.Core;
using System.Media;


namespace WorldOfSoftuniRPG.Forms
{
    using WorldOfSoftuniRPG.Models.Fields;
    using WorldOfSoftuniRPG.Models.Players;
    using WorldOfSoftuniRPG.Utilities;

    public partial class Frm_Menu : Form
    {
        private SoundPlayer menuPlayer = new SoundPlayer();
        public Frm_Menu()
        {
            this.InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.bt_StartGame.Visible = false;
            this.bt_Exit.Visible = false;

            Image image =
                Image.FromFile(
                    @"../../Forms/Resources/tumblr_ni186jsRPw1skb54qo1_500.gif");
            this.pictureBox1.Image = image;
            this.pictureBox1.Height = image.Height;
            this.pictureBox1.Width = image.Width;
            this.menuPlayer = new SoundPlayer(@"../../Forms/Resources/menu.wav");
            this.menuPlayer.Play();
        }

        private void bt_StartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            var heroSelection = new Frm_HeroSelection();
            heroSelection.Closed += (s, args) => this.Close();
            heroSelection.Show();

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic_NewGame_MouseHover(object sender, EventArgs e)
        {
            this.pic_NewGame.Visible = false;
            this.bt_StartGame.Visible = true;
        }

        private void pic_Exit_MouseHover(object sender, EventArgs e)
        {
            this.pic_Exit.Visible = false;
            this.bt_Exit.Visible = true;
        }

        private void bt_StartGame_MouseLeave(object sender, EventArgs e)
        {
            this.bt_StartGame.Visible = false;
            this.pic_NewGame.Visible = true;
        }

        private void bt_Exit_MouseLeave(object sender, EventArgs e)
        {
            this.bt_Exit.Visible = false;
            this.pic_Exit.Visible = true;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Game game = new Game();
            game.Stop();
        }

        private void bt_LoadGame_Click(object sender, EventArgs e)
        {
            if (!LoadGame.LoadHero())
            {
                MessageBox.Show(@"          You dont have Character !
                        Click on ""NEW GAME"" to create your first!");
            }
            else
            {
                this.Close();
                var game = new Game();
                game.Start();
                Frm_HeroSelection.DrawSoftUni();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("-------------------Welcome to our game \"World of SofrUni\".-------------------");
                Console.WriteLine();
                Console.WriteLine(new string(Constants.LineSeparator, 79));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have create new hero Mage.");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(new string(Constants.LineSeparator, 79));
                Console.WriteLine("1.To continue playing please enter command \"help\" to show you all command.");
                Console.WriteLine(new string(Constants.LineSeparator, 79));
                Console.WriteLine("2.To EXIT and SAVE the game enter command \"exit\".");
                Console.WriteLine(new string(Constants.LineSeparator, 79));
                Console.WriteLine("3.To SAVE and continue playing the game enter command \"save\"");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void pic_LoadGame_MouseHover(object sender, EventArgs e)
        {
            this.bt_LoadGame.Visible = true;
            this.pic_LoadGame.Visible = false;
        }

        private void bt_LoadGame_MouseLeave(object sender, EventArgs e)
        {
            this.bt_LoadGame.Visible = false;
            this.pic_LoadGame.Visible = true;
        }
    }
}
