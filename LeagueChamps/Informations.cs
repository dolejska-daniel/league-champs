using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueChamps
{
    public class Informations
    {
        private mainForm form;
        private settingsForm settings;

        public Informations(mainForm form, settingsForm settings)
        {
            this.form = form;
            this.settings = settings;
        }

        public void ActQ(string val)
        {
            string[] value = this.form.questionOverviewValue.Text.Split('/');
            this.form.questionOverviewValue.Text = val + "/" + value[1];
        }

        public void NumQ(string val)
        {
            string[] value = this.form.questionOverviewValue.Text.Split('/');
            this.form.questionOverviewValue.Text = value[0] + "/" + val;
        }

        public void ActLifes(string val)
        {
            string[] value = this.form.lifesValue.Text.Split('/');
            this.form.lifesValue.Text = val + "/" + value[1];
        }

        public void NumLifes(string val)
        {
            string[] value = this.form.lifesValue.Text.Split('/');
            this.form.lifesValue.Text = value[0] + "/" + val;
        }

        public void AnsState(string val)
        {
            this.form.answerStateValue.Text = val;
        }

        public void TimeLimit(string val)
        {
            this.form.timeLimitValue.Text = val + "s";
        }
    }
}
