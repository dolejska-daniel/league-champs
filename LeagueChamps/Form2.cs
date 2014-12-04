using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueChamps
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        //Nastavení globální obtížnosti
        public int difficultyRate = 0;

        //Nastavení počtu otázek
        public int questionRate = 0;
        public int numOfQuestions = 0;

        //Nastavení aktuální otázky
        public int actualQuestion = 0;

        //Nastavení počtu životů
        public int numOfLifes = 0;
        public int actNumOfLifes = 0;
        
        //Nastavení časového limitu
        public int time = 0;

        //Nastavení ukončení kola
        public bool roundEnd = false;

        //Nastavení výhry
        public bool gameWon = false;

        //Změna nastavení obtížnosti
        public void difficultyRateChange(object sender, EventArgs e)
        {
            switch (difficultyBar.Value)
            {
                case 0: difficultyValue.Text = "0%";
                        questionBar.Minimum = 0;
                        questionBar.Value = 0;
                        questionValue.Text = "10";
                        questionRate = 0;
                        difficultyRate = 0;
                        break;
                case 1: difficultyValue.Text = "50%";
                        questionBar.Minimum = 1;
                        questionBar.Value = 1;
                        questionValue.Text = "20";
                        questionRate = 1;
                        difficultyRate = 1;
                        break;
                case 2: difficultyValue.Text = "100%";
                        questionBar.Minimum = 2;
                        questionBar.Value = 2;
                        questionValue.Text = "30";
                        questionRate = 2;
                        difficultyRate = 2;
                        break;
                default: difficultyValue.Text = "0%";
                         questionBar.Minimum = 0;
                         questionBar.Value = 0;
                         questionValue.Text = "10";
                         questionRate = 0;
                         difficultyRate = 0;
                         break;
            }
        }

        //Změna nastavení počtu otázek
        public void questionRateChange(object sender, EventArgs e)
        {
            switch (questionBar.Value)
            {
                case 0: questionValue.Text = "10";
                        questionRate = 0;
                        break;
                case 1: questionValue.Text = "20";
                        questionRate = 1;
                        break;
                case 2: questionValue.Text = "30";
                        questionRate = 2;
                        break;
                case 3: questionValue.Text = "50";
                        questionRate = 3;
                        break;
                default: questionValue.Text = "10";
                         questionRate = 0;
                         break;
            }
        }
    }
}
