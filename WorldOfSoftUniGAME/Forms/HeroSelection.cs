﻿namespace WorldOfSoftuniRPG.Forms
{
    using System;
    using System.Linq;
    using System.Media;
    using System.Windows.Forms;

    using WorldOfSoftuniRPG.Core;
    using WorldOfSoftuniRPG.Models.Fields;
    using WorldOfSoftuniRPG.Models.Players;
    using WorldOfSoftuniRPG.Utilities;

    using WorldOfSoftUniRPG.Data;
    using WorldOfSoftUniRPG.Models;

    public partial class Frm_HeroSelection : Form
    {
        private SoundPlayer music;

        public Frm_HeroSelection()
        {
            this.InitializeComponent();
        }

        public static void DrawSoftUni()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"             **       **              **  *****       ****   *****");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"              **     **   * *   ****  **  **   *     **  **  **   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"               ** * **   *   *  **    **  **   *     **  **  *****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                ** **     * *   **    **  *****       ****   **");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                 *****                        **   **         **");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                 **            *****  ******  **   **           ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                 *****   * *   **       **    **   **  **  *  **");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                    **  *   *  *****    **    **   **  * * *  **");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                 *****   * *   **       **     *****   *  **  **");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private void HeroSelection_Load(object sender, EventArgs e)
        {
            this.music = new SoundPlayer(@"../../Forms/Resources/pick.wav");
            this.music.Play();
            this.pic_Mage.Visible = false;
            this.pic_Warrior.Visible = false;
        }

        private void HeroSelection_MouseHover(object sender, EventArgs e)
        {
        }

        private void pic_Mage_Click(object sender, EventArgs e)
        {
            this.Close();
            var game = new Game();
            game.Start();
            Field.Hero = new Mage();
            NewGame.NewHero();

            DrawSoftUni();
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
            Console.WriteLine("2.To exit the game enter command \"exit\".");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void pic_Mage_MouseLeave(object sender, EventArgs e)
        {
            this.pic_MageLil.Visible = true;
            this.pic_Mage.Visible = false;
        }

        private void pic_MageLil_MouseHover(object sender, EventArgs e)
        {
            this.pic_MageLil.Visible = false;
            this.pic_Mage.Visible = true;
        }

        private void pic_Warrior_Click(object sender, EventArgs e)
        {
            this.Close();
            var game = new Game();
            game.Start();
            Field.Hero = new Warrior();
            NewGame.NewHero();

            DrawSoftUni();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------------------Welcome to our game \"World of SofrUni\".-------------------");
            Console.WriteLine();
            Console.WriteLine(new string(Constants.LineSeparator, 79));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have create new Warrior.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(new string(Constants.LineSeparator, 79));
            Console.WriteLine("1.To continue playing please enter command \"help\" to show you all command.");
            Console.WriteLine(new string(Constants.LineSeparator, 79));
            Console.WriteLine("2.To exit the game enter command \"exit\".");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void pic_Warrior_MouseLeave(object sender, EventArgs e)
        {
            this.pic_Warrior.Visible = false;
            this.pic_WarriorLil.Visible = true;
        }

        private void pic_WarriorLil_Click(object sender, EventArgs e)
        {
        }

        private void pic_WarriorLil_MouseHover(object sender, EventArgs e)
        {
            this.pic_WarriorLil.Visible = false;
            this.pic_Warrior.Visible = true;
        }
    }
}