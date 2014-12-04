using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueChamps
{
    class Questions
    {
        private mainForm form;
        private settingsForm settings;

        public Questions(mainForm form, settingsForm settings)
        {
            this.form = form;
            this.settings = settings;
        }

        public string[,] Q = new string[3, 50];
        public string Question()
        {
            #region QUESTIONS
            //Q[0-2, 0-49]
            //level1
            Q[0, 0]  = "0Riot Girl";
            Q[0, 1]  = "0Viscero";
            Q[0, 2]  = "0Medieval";
            Q[0, 3]  = "0Surprise Party";
            Q[0, 4]  = "0Dragon Fist";
            Q[0, 5]  = "0Valkyrie";
            Q[0, 6]  = "0Sailor";
            Q[0, 7]  = "0Astronaut";
            Q[0, 8]  = "0Spell Thief";
            Q[0, 9]  = "0Battle Bunny";
            Q[0, 10] = "0Forsaken";
            Q[0, 11] = "0Asylum";
            Q[0, 12] = "0Pre-Void";
            Q[0, 13] = "0Prestigious";
            Q[0, 14] = "0Jack of Hearts";
            Q[0, 15] = "0Big Bad";
            Q[0, 16] = "0Tyrant";
            Q[0, 17] = "0Shockblade";
            Q[0, 18] = "0Scorched Earth";
            Q[0, 19] = "0Volcanic";
            Q[0, 20] = "0Undertaker";
            Q[0, 21] = "0Cottontail";
            Q[0, 22] = "0Blight Crystal";
            Q[0, 23] = "0Rune Wars";
            Q[0, 24] = "0Demolisher";
            Q[0, 25] = "0Surgeon";
            Q[0, 26] = "0Headless";
            Q[0, 27] = "0Jailbreak";
            Q[0, 28] = "0Gatekeeper";
            Q[0, 29] = "0Fisherman";
            Q[0, 30] = "0Explorer";
            Q[0, 31] = "0Gentleman";
            Q[0, 32] = "0Siren";
            Q[0, 33] = "0Red Baron";
            Q[0, 34] = "0Sherwood Forest";
            Q[0, 35] = "0Dark Valkyrie";
            Q[0, 36] = "0Nurse";
            Q[0, 37] = "0Sheriff";
            Q[0, 38] = "0Sakura";
            Q[0, 39] = "0Boom Boom";
            Q[0, 40] = "0Djinn";
            Q[0, 41] = "0Bladecraft";
            Q[0, 42] = "0Astro";
            Q[0, 43] = "0Thunder Lord";
            Q[0, 44] = "0Special Weapon";
            Q[0, 45] = "1in the Jungle";
            Q[0, 46] = "0Frozen Terror";
            Q[0, 47] = "0Nightblade";
            Q[0, 48] = "0Unchained";
            Q[0, 49] = "0Death Blossom";
            //level2
            Q[1, 0]  = "0Noxus Hunter";
            Q[1, 1]  = "0Spooky";
            Q[1, 2]  = "0Hillbilly";
            Q[1, 3]  = "0Frost Queen";
            Q[1, 4]  = "0Monarch";
            Q[1, 5]  = "0Riot K-9";
            Q[1, 6]  = "0Gangster";
            Q[1, 7]  = "0Karate";
            Q[1, 8]  = "0Black Belt";
            Q[1, 9]  = "0Tribal";
            Q[1, 10] = "0Recon";
            Q[1, 11] = "0Deep One";
            Q[1, 12] = "0Fullmachine";
            Q[1, 13] = "0Major";
            Q[1, 14] = "0Wildfire";
            Q[1, 15] = "0Battle Regalia";
            Q[1, 16] = "0Bonecaw";
            Q[1, 17] = "0Marble";
            Q[1, 18] = "0Totemic";
            Q[1, 19] = "0Surfer";
            Q[1, 20] = "0Sorceress";
            Q[1, 21] = "0Ghost Bride";
            Q[1, 22] = "0Atlantean";
            Q[1, 23] = "0Debonair";
            Q[1, 24] = "0Koi";
            Q[1, 25] = "0Aether Wing";
            Q[1, 26] = "0Darkrider";
            Q[1, 27] = "0Aristocrat";
            Q[1, 28] = "0Midnight";
            Q[1, 29] = "0Little Knight";
            Q[1, 30] = "0Nightraven";
            Q[1, 31] = "0Grim Reaper";
            Q[1, 32] = "0High Command";
            Q[1, 33] = "0Foxfire";
            Q[1, 34] = "0Baron Von";
            Q[1, 35] = "0Mad Hatter";
            Q[1, 36] = "0French Maid";
            Q[1, 37] = "0Arcade";
            Q[1, 38] = "0Earthrune";
            Q[1, 39] = "0Deep Terror";
            Q[1, 40] = "0Renegade";
            Q[1, 41] = "0Neon Strike";
            Q[1, 42] = "0Count";
            Q[1, 43] = "0Woad King";
            Q[1, 44] = "0Apocalyptic";
            Q[1, 45] = "0Temple";
            Q[1, 46] = "0Ninja";
            Q[1, 47] = "0Darkflame";
            Q[1, 48] = "0Lumberack";
            Q[1, 49] = "0Arclight";
            //level3
            Q[2, 0]  = "0Runeguard";
            Q[2, 1]  = "1Bot";
            Q[2, 2]  = "0Runeborn";
            Q[2, 3]  = "0Prototype";
            Q[2, 4]  = "0Viking";
            Q[2, 5]  = "1Greybeard";
            Q[2, 6]  = "0Augmented";
            Q[2, 7]  = "0Dragon Trainer";
            Q[2, 8]  = "0Aviator";
            Q[2, 9]  = "0Spectral";
            Q[2, 10] = "0Huntress";
            Q[2, 11] = "0Fire Fang";
            Q[2, 12] = "0Warlord";
            Q[2, 13] = "0Phoenix";
            Q[2, 14] = "0Jade Fang";
            Q[2, 15] = "0Urfrider";
            Q[2, 16] = "0Deadly";
            Q[2, 17] = "0Junkyard";
            Q[2, 18] = "0Outback";
            Q[2, 19] = "0Mecha";
            Q[2, 20] = "0i";
            Q[2, 21] = "0Minuteman";
            Q[2, 22] = "0Gladiator";
            Q[2, 23] = "1in Wonderland";
            Q[2, 24] = "0Dynasty";
            Q[2, 25] = "0Frosted";
            Q[2, 26] = "0Charred";
            Q[2, 27] = "0Grungy";
            Q[2, 28] = "0Vindicator";
            Q[2, 29] = "0Marquis";
            Q[2, 30] = "0Statue of";
            Q[2, 31] = "0High Noon";
            Q[2, 32] = "0Ravager";
            Q[2, 33] = "0Loch Ness";
            Q[2, 34] = "0Redeemed";
            Q[2, 35] = "0Executioner";
            Q[2, 36] = "0Reaper";
            Q[2, 37] = "0Super";
            Q[2, 38] = "0Overlord";
            Q[2, 39] = "0Prestigious";
            Q[2, 40] = "0Jade Dragon";
            Q[2, 41] = "0Pirate";
            Q[2, 42] = "0Sewn Chaos";
            Q[2, 43] = "0Silverfang";
            Q[2, 44] = "0Primal";
            Q[2, 45] = "0Shadow Prince";
            Q[2, 46] = "0Ionia";
            Q[2, 47] = "0Chrome";
            Q[2, 48] = "0Groovy";
            Q[2, 49] = "0Guerilla";
            #endregion

            return Q[this.settings.difficultyRate, this.settings.actualQuestion - 1];
        }

        public void SetBef(string name)
        {
            this.form.beforeNameLabel.Text = name;
        }

        public void SetAft(string name)
        {
            this.form.afterNameLabel.Text = name;
        }

        public void CleanBef()
        {
            this.form.beforeNameLabel.Text = "";
        }

        public void CleanAft()
        {
            this.form.afterNameLabel.Text = "";
        }
    }
}
