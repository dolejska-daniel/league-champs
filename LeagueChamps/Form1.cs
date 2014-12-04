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
    public partial class mainForm : Form
    {
        //Inicializace dialogu nastavení
        settingsForm settings = new settingsForm();
        //Inicializace dialogu s pomocí
        helpForm help = new helpForm();
        //Inicializace třídy /Informations
        Informations informations;
        //Inicializace třídy /Questions
        Questions questions;
        //Inicializace třídy /Answers
        Answers answers;
        //Inicializace třídy /General
        General general;

        public mainForm()
        {
            //Inicializace třídy /Informations
            informations = new Informations(this, settings);
            //Inicializace třídy /Questions
            questions = new Questions(this, settings);
            //Inicializace třídy /Answers
            answers = new Answers(this, settings);
            //Iniscializace třídy /General
            general = new General(this, settings, answers, questions, informations);

            InitializeComponent();
            general.onLoad();
            MessageBox.Show("Vítejte!\nPo spuštění programu doporučuji prohlédnout nápovědu a nastavení!\nPřeji příjemnou zábavu, KronnY");
        }

        private void openSettings(object sender, EventArgs e)
        {
            settings.ShowDialog();
            settingsOpenTimer.Enabled = true;
        }

        private void openHelp(object sender, EventArgs e)
        {
            help.ShowDialog();
            helpOpenTimer.Enabled = true;
        }

        private void answer(object sender, EventArgs e)
        {
            informations.AnsState("Probíhá kontrola");
            answers.Disable();
            answers.RestartDisable();
            answers.NextDisable();
            timer.Enabled = false;
            progressTimer.Enabled = true;
        }

        private void progressTick(object sender, EventArgs e)
        {
            programMenu.Enabled = false;
            progressBar.Increment(1);

            Random nahoda = new Random();
            if (progressBar.Value % 15 == 1)
                progressTimer.Interval = nahoda.Next(1, 51);

            if (progressBar.Value == 100)
            {
                general.answerCheck();
                progressTimer.Enabled = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            if (settings.time == 0)
            {
                timer.Enabled = false;
                informations.AnsState("Čas vypršel");
                settings.actNumOfLifes -= 1;
                informations.ActLifes(Convert.ToString(settings.actNumOfLifes));
                answers.Disable();
                this.settings.roundEnd = true;
            }
            else
            {
                settings.time -= 1;
                informations.TimeLimit(Convert.ToString(settings.time));
            }
        }

        private void settingsOpenedCheck(object sender, EventArgs e)
        {
            if (settings.Visible)
                this.Enabled = false;
            else
            {
                this.Enabled = true;
                this.Activate();
                settingsOpenTimer.Enabled = false;
            }
        }

        private void helpOpenedCheck(object sender, EventArgs e)
        {
            if (help.Visible)
                this.Enabled = false;
            else
            {
                this.Enabled = true;
                this.Activate();
                helpOpenTimer.Enabled = false;
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void StartGame(object sender, EventArgs e)
        {
            general.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            general.Restart();
        }

        private void ResetGame(object sender, EventArgs e)
        {
            general.Reset();
        }

        private void NextQGame(object sender, EventArgs e)
        {
            general.NextQuestion();
        }

        private void lifeCheck(object sender, EventArgs e)
        {
            if (settings.actNumOfLifes == 0)
            {
                informations.AnsState("Konec hry");
                startMenu.Enabled = true;
                answers.Disable();
                answers.NextDisable();
                answers.RestartEnable();
                lifeCheckTimer.Enabled = false;
                restartButton.Focus();
            }
            else if (settings.roundEnd && !settings.gameWon)
            {
                answers.NextEnable();
                nextQButton.Focus();
            }
        }

        private void answerEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                answer(sender, e);
            }
        }
    }
}