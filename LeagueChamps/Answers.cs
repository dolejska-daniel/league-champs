using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueChamps
{
    class Answers
    {
        private mainForm form;
        private settingsForm settings;

        public Answers(mainForm form, settingsForm settings)
        {
            this.form = form;
            this.settings = settings;
        }

        public string[,] A = new string[3, 50];
        public string Answer()
        {
            #region ANSWERS
            //A[0-2, 0-49]
            //level1
            A[0, 0] = "Tristana";
            A[0, 1] = "Xin Zhao";
            A[0, 2] = "Twitch";
            A[0, 3] = "Fiddlesticks";
            A[0, 4] = "Lee Sin";
            A[0, 5] = "Leona";
            A[0, 6] = "Gangplank";
            A[0, 7] = "Teemo";
            A[0, 8] = "Lux";
            A[0, 9] = "Riven";
            A[0, 10] = "Olaf";
            A[0, 11] = "Shaco";
            A[0, 12] = "Kassadin";
            A[0, 13] = "LeBlanc";
            A[0, 14] = "Twisted Fate";
            A[0, 15] = "Warwick";
            A[0, 16] = "Swain";
            A[0, 17] = "Zed";
            A[0, 18] = "Xerath";
            A[0, 19] = "Wukong";
            A[0, 20] = "Yoric";
            A[0, 21] = "Teemo";
            A[0, 22] = "Varus";
            A[0, 23] = "Renekton";
            A[0, 24] = "Nunu";
            A[0, 25] = "Shen";
            A[0, 26] = "Hecarim";
            A[0, 27] = "Graves";
            A[0, 28] = "Galio";
            A[0, 29] = "Fizz";
            A[0, 30] = "Ezreal";
            A[0, 31] = "Cho'Gath";
            A[0, 32] = "Cassiopeia";
            A[0, 33] = "Corki";
            A[0, 34] = "Ashe";
            A[0, 35] = "Diana";
            A[0, 36] = "Akali";
            A[0, 37] = "Caitlyn";
            A[0, 38] = "Karma";
            A[0, 39] = "Blitzcrank";
            A[0, 40] = "Malzahar";
            A[0, 41] = "Oriana";
            A[0, 42] = "Nautilus";
            A[0, 43] = "Volibear";
            A[0, 44] = "Zac";
            A[0, 45] = "Rumble";
            A[0, 46] = "Nocturne";
            A[0, 47] = "Irelia";
            A[0, 48] = "Alistar";
            A[0, 49] = "Elise";
            //level2
            A[1, 0] = "Anivia";
            A[1, 1] = "Gangplank";
            A[1, 2] = "Gragas";
            A[1, 3] = "Janna";
            A[1, 4] = "Kog'Maw";
            A[1, 5] = "Nasus";
            A[1, 6] = "Twitch";
            A[1, 7] = "Kennen";
            A[1, 8] = "Udyr";
            A[1, 9] = "Ryze";
            A[1, 10] = "Teemo";
            A[1, 11] = "Kassadin";
            A[1, 12] = "Viktor";
            A[1, 13] = "Ziggs";
            A[1, 14] = "Zyra";
            A[1, 15] = "Poppy";
            A[1, 16] = "Shyvana";
            A[1, 17] = "Malphite";
            A[1, 18] = "Maokai";
            A[1, 19] = "Singed";
            A[1, 20] = "Lux";
            A[1, 21] = "Morgana";
            A[1, 22] = "Fizz";
            A[1, 23] = "Jayce";
            A[1, 24] = "Nami";
            A[1, 25] = "Kayle";
            A[1, 26] = "Sejuani";
            A[1, 27] = "Vayne";
            A[1, 28] = "Ahri";
            A[1, 29] = "Amumu";
            A[1, 30] = "Fiora";
            A[1, 31] = "Karthus";
            A[1, 32] = "Katarina";
            A[1, 33] = "Ahri";
            A[1, 34] = "Veigar";
            A[1, 35] = "Shaco";
            A[1, 36] = "Nidalee";
            A[1, 37] = "Sona";
            A[1, 38] = "Xerath";
            A[1, 39] = "Thresh";
            A[1, 40] = "Talon";
            A[1, 41] = "Vi";
            A[1, 42] = "Vladimir";
            A[1, 43] = "Darius";
            A[1, 44] = "Brand";
            A[1, 45] = "Jax";
            A[1, 46] = "Rammus";
            A[1, 47] = "Shyvana";
            A[1, 48] = "Sion";
            A[1, 49] = "Varus";
            //level3
            A[2, 0] = "Volibear";
            A[2, 1] = "Nunu";
            A[2, 2] = "Xerath";
            A[2, 3] = "Viktor";
            A[2, 4] = "Tryndamere";
            A[2, 5] = "Veigar";
            A[2, 6] = "Singed";
            A[2, 7] = "Lulu";
            A[2, 8] = "Irelia";
            A[2, 9] = "Fiddlesticks";
            A[2, 10] = "Sivir";
            A[2, 11] = "Warwick";
            A[2, 12] = "Shen";
            A[2, 13] = "Quinn";
            A[2, 14] = "Cassiopeia";
            A[2, 15] = "Corki";
            A[2, 16] = "Kennen";
            A[2, 17] = "Trundle";
            A[2, 18] = "Renekton";
            A[2, 19] = "Kha'Zix";
            A[2, 20] = "Blitzcrank";
            A[2, 21] = "Gangplank";
            A[2, 22] = "Draven";
            A[2, 23] = "Annie";
            A[2, 24] = "Ahri";
            A[2, 25] = "Ezreal";
            A[2, 26] = "Maokai";
            A[2, 27] = "Nunu";
            A[2, 28] = "Vayne";
            A[2, 29] = "Vladimir";
            A[2, 30] = "Karthus";
            A[2, 31] = "Twisted Fate";
            A[2, 32] = "Nocturne";
            A[2, 33] = "Cho'Gath";
            A[2, 34] = "Riven";
            A[2, 35] = "Mundo";
            A[2, 36] = "Hecarim";
            A[2, 37] = "Teemo";
            A[2, 38] = "Malzahar";
            A[2, 39] = "LeBlanc";
            A[2, 40] = "Wukong";
            A[2, 41] = "Ryze";
            A[2, 42] = "Oriana";
            A[2, 43] = "Akali";
            A[2, 44] = "Udyr";
            A[2, 45] = "Malzahar";
            A[2, 46] = "Master";
            A[2, 47] = "Rammus";
            A[2, 48] = "Zilean";
            A[2, 49] = "Tristana";
            #endregion

            return A[this.settings.difficultyRate,this.settings.actualQuestion - 1];
        }

        public void Clean()
        {
            this.form.answerField.Text = "";
        }

        public string Read()
        {
            return this.form.answerField.Text;
        }

        public void Disable()
        {
            this.form.answerField.Enabled = false;
            this.form.answerButton.Enabled = false;
        }

        public void Enable()
        {
            this.form.answerField.Enabled = true;
            this.form.answerButton.Enabled = true;
        }

        public void RestartDisable()
        {
            this.form.restartButton.Enabled = false;
        }

        public void RestartEnable()
        {
            this.form.restartButton.Enabled = true;
        }

        public void NextDisable()
        {
            this.form.nextQButton.Enabled = false;
        }

        public void NextEnable()
        {
            this.form.nextQButton.Enabled = true;
        }
    }
}
