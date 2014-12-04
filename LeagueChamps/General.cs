using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueChamps
{
    class General
    {
        private mainForm form;
        private settingsForm settings;
        private Answers answers;
        private Questions questions;
        private Informations informations;

        public General(mainForm form, settingsForm settings, Answers answers, Questions questions, Informations informations)
        {
            this.form = form;
            this.settings = settings;
            this.answers = answers;
            this.questions = questions;
            this.informations = informations;
        }

        public void Start()
        {
            this.form.startMenu.Enabled = false;
            this.form.resetMenu.Enabled = true;
            this.form.restartMenu.Enabled = true;
            this.form.infMenu.Enabled = false;
            this.form.setMenu.Enabled = false;
            this.settings.actualQuestion = 0;
            switch (this.settings.questionRate)
            {
                case 0: this.settings.numOfQuestions = 10; break;
                case 1: this.settings.numOfQuestions = 20; break;
                case 2: this.settings.numOfQuestions = 30; break;
                case 3: this.settings.numOfQuestions = 50; break;
            }
            switch (this.settings.difficultyRate)
            {
                case 0: this.settings.numOfLifes = 1; this.settings.actNumOfLifes = 1; break;
                case 1: this.settings.numOfLifes = 2; this.settings.actNumOfLifes = 2; break;
                case 2: this.settings.numOfLifes = 3; this.settings.actNumOfLifes = 3; break;
            }
            this.answers.Enable();
            this.answers.RestartDisable();
            this.answers.NextDisable();
            NextQuestion();
        }

        public void NextQuestion()
        {
            this.form.progressBar.Value = 0;
            this.settings.actualQuestion += 1;
            this.settings.time = 10;
            this.settings.roundEnd = false;
            this.answers.Clean();
            this.informations.NumQ(Convert.ToString(this.settings.numOfQuestions));
            this.informations.ActQ(Convert.ToString(this.settings.actualQuestion));
            this.informations.NumLifes(Convert.ToString(this.settings.numOfLifes));
            this.informations.ActLifes(Convert.ToString(this.settings.actNumOfLifes));
            this.informations.AnsState("Neodesláno");
            this.form.timer.Enabled = true;
            this.form.lifeCheckTimer.Enabled = true;
            this.answers.Enable();
            this.answers.RestartDisable();
            this.answers.NextDisable();
            this.informations.TimeLimit("10");
            //
            if (this.questions.Question().Substring(0, 1) == "0")
            {
                this.questions.SetBef(this.questions.Question().Substring(1, this.questions.Question().Length - 1));
                this.questions.CleanAft();
            }
            else
            {
                this.questions.SetAft(this.questions.Question().Substring(1, this.questions.Question().Length - 1));
                this.questions.CleanBef();
            }
            this.form.answerField.Focus();
        }

        public void Reset()
        {
            this.form.progressTimer.Enabled = false;
            this.form.timer.Enabled = false;
            this.form.lifeCheckTimer.Enabled = false;
            this.answers.Clean();
            this.answers.Disable();
            this.answers.NextDisable();
            this.answers.RestartDisable();
            this.questions.CleanAft();
            this.questions.CleanBef();
            this.informations.AnsState("-");
            this.form.questionOverviewValue.Text = "-/-";
            this.form.lifesValue.Text = "-/-";
            this.form.answerStateValue.Text = "-";
            this.form.timeLimitValue.Text = "-";
            this.form.infMenu.Enabled = true;
            this.form.setMenu.Enabled = true;
            this.form.startMenu.Enabled = true;
            this.form.resetMenu.Enabled = false;
            this.form.restartMenu.Enabled = false;
            this.form.progressBar.Value = 0;
            this.settings.actualQuestion = 0;
            this.settings.numOfQuestions = 0;
            this.settings.actNumOfLifes = 0;
            this.settings.numOfLifes = 0;
            this.settings.gameWon = false;
        }

        public void Restart()
        {
            Reset();
            Start();
        }

        public void onLoad()
        {
            this.answers.Disable();
            this.answers.RestartDisable();
            this.answers.NextDisable();
        }

        public void answerCheck()
        {
            if (this.answers.Read().ToUpper() == this.answers.Answer().ToUpper())
            {
                if (this.settings.actualQuestion == this.settings.numOfQuestions)
                {
                    this.informations.AnsState("Výhra");
                    this.answers.RestartEnable();
                    this.answers.NextDisable();
                    this.answers.Disable();
                    this.form.nextQButton.Focus();
                    this.settings.gameWon = true;
                }
                else
                {
                    this.informations.AnsState("Správná odpověď");
                    this.answers.NextEnable();
                    this.answers.Disable();
                    this.form.nextQButton.Focus();
                }
            }
            else
            {
                this.informations.AnsState("Chybná odpověď");
                this.form.startMenu.Enabled = true;
                this.settings.actNumOfLifes -= 1;
                informations.ActLifes(Convert.ToString(settings.actNumOfLifes));
                this.answers.RestartEnable();
                this.answers.NextDisable();
                this.answers.Disable();
                this.form.restartButton.Focus();
            }
            this.settings.roundEnd = true;
            this.form.programMenu.Enabled = true;
        }
    }
}
