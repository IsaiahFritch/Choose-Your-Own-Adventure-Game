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
using System.Media;

namespace Choose_Your_Own_Adventure_Game
{
    public partial class AdventureGame : Form
    {
        //global sounds
        SoundPlayer click = new SoundPlayer(Properties.Resources.Click);
        SoundPlayer heartbeat = new SoundPlayer(Properties.Resources._564013__rlkhafi__heart_beat);

        //global variables
        int page = 1;
        int animTiming = 1;
        Random ranGen = new Random();
        int chance = 1;

        string player = "name";

        int character = 0; //1 is Jon, 2 is Shimshon
        int saidNo = 0;
        int brokenArms = 0;
        int shoesTied = 0;
        int antiSocial = 0;
        int brokenLegs = 0;
        int knowsOfThief = 0;
        int hasCube = 0;
        int knowsOfCastle = 0;
        int knowsOfChurch = 0;
        int trustInnKeeper = 0;
        int bloodlust = 0;
        int caughtMurder = 0;
        int beenHere = 0;
        int knowsOfTunnels = 0;
        int hasKnife = 0;
        int hasSpoon = 0;
        int insideDateSim = 0;
        int movedOnChance = -1;

        //speech icons
        Image ICONdefaultIcon = Properties.Resources.RealDefaultIcon;
        Image ICONcharacter = Properties.Resources.CharacterJon; // make sure to switch the photo for Shimshon
        Image ICONchurchMan = Properties.Resources.ChurchBoy;
        Image ICONchurchWoman = Properties.Resources.ChurchGirl;
        Image ICONchurchLead = Properties.Resources.ChurchLead;
        Image ICONinnKeeper = Properties.Resources.InnKeeper;
        Image ICONthief = Properties.Resources.Thief;
        Image ICONcastleGuard = Properties.Resources.Guard;
        Image ICONmysteriousVoice = Properties.Resources.MysteriousVoice;
        Image ICONhomelessMan = Properties.Resources.HomelessMan;
        Image ICONIt = Properties.Resources.DateSimIt;
        Image ICONDateSimNoDio = Properties.Resources.DateSimNoDio;
        Image ICONYou = Properties.Resources.DateSimYou;

        public AdventureGame()
        {
            InitializeComponent();
            //formatting and correctly loading
            //main menu    (add scenes to the image property of mainMenuBox to display them)
            playStartButton.Parent = mainMenuBox;
            playStartButton.Location = new Point(260, 444);
            closeStartButon.Parent = mainMenuBox;
            closeStartButon.Location = new Point(260, 736);

            //parenting
            pageNumberLabel.Parent = mainUiBox;
            playAgainButton.Parent = endScreenBox;
            playAgainButton.Location = new Point(234, 195);
            endGameButton.Parent = endScreenBox;
            endGameButton.Location = new Point(234, 556);
            endScreenBox.Parent = mainUiBox;
            endScreenBox.Location = new Point(0, 0);
            deathAnimBox.Parent = mainUiBox;
            deathAnimBox.Location = new Point(0, 0);
            goodbyeMessageText.Parent = goodbyeMessageBack;
            goodbyeMessageText.Location = new Point(101, 177);
            goodbyeMessageBack.Parent = mainUiBox;
            mainUiBox.Parent = mainMenuBox;
            mainUiBox.Visible = false;
            startAnimBox.Parent = mainMenuBox;
            startAnimBox.Visible = false;
            playerNameText.Parent = mainUiBox;
            playerNameText.Location = new Point(248, 335);
            playerNameTextTip.Parent = mainUiBox;
            playerNameTextTip.Location = new Point(249, 319);
            playerNameTextJon.Parent = mainUiBox;
            playerNameTextJon.Location = new Point(419, 400);
            playerNameTextShimshon.Parent = mainUiBox;
            playerNameTextShimshon.Location = new Point(419, 400);
            outputLabel.Parent = mainUiBox;
            outputLabel.Location = new Point(167, 33);
            optionOneBlocked.Parent = mainUiBox;
            optionOneBlocked.Location = new Point(63, 614);
            optionTwoBlocked.Parent = mainUiBox;
            optionTwoBlocked.Location = new Point(396, 614);
            optionThreeBlocked.Parent = mainUiBox;
            optionThreeBlocked.Location = new Point(63, 752);
            optionFourBlocked.Parent = mainUiBox;
            optionFourBlocked.Location = new Point(396, 752);
            optionOneButton.Parent = mainUiBox;
            optionOneButton.Location = new Point(63, 614);
            optionOneButton.Enabled = false;
            optionTwoButton.Parent = mainUiBox;
            optionTwoButton.Location = new Point(396, 614);
            optionTwoButton.Enabled = false;
            optionThreeButton.Parent = mainUiBox;
            optionThreeButton.Location = new Point(63, 752);
            optionThreeButton.Enabled = false;
            optionFourButton.Parent = mainUiBox;
            optionFourButton.Location = new Point(396, 752);
            optionFourButton.Enabled = false;
            iconBox.Parent = mainUiBox;
            iconBox.Visible = false;
            iconFadeInBox.Parent = mainUiBox;
            iconFadeInBox.Visible = false;

        }


        private void playStartButton_Click(object sender, EventArgs e) //main menu
        {
            //start game
            page = 2;
            DisplayPage();
        }

        private void closeStartButon_Click(object sender, EventArgs e) //main menu
        {
            //end program
            page = 1000;
            DisplayPage();
        }

        //four buttons
        private void optionOneButton_Click(object sender, EventArgs e)
        {
            //select next page

            //if (page == 2)//testing death
            //{
            //    page = 999;
            //}

            //if (page == 2)//testing date
            //{
            //    page = 368;
            //}

            if (page == 2)
            {
                page = 3;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 28)
            {
                page = 40;
            }
            else if (page == 30)
            {
                page = 368;
            }
            else if (page == 32)
            {
                if (saidNo == 1)
                {
                    page = 34;
                }
                else
                {
                    page = 37;
                }
            }

            else if (page == 36)
            {
                page = 999;
            }
            else if (page == 41)
            {
                page = 42;
            }
            else if (page == 48)
            {
                page = 49;
            }
            else if (page == 60)
            {
                page = 63;
            }
            else if (page == 68)
            {
                page = 69;
            }
            else if (page == 70)
            {
                page = 71;
            }
            else if (page == 77)
            {
                page = 105;
            }
            else if (page == 78)
            {
                page = 91;
            }
            else if (page == 82)
            {
                page = 98;
            }
            else if (page == 90)
            {
                page = 999;
            }
            else if (page == 85)
            {
                page = 103;
            }
            else if (page == 112)
            {
                page = 113;
            }
            else if (page == 119) //This is the big page
            {
                if (brokenLegs == 1)
                {
                    page = 1256;
                }
                else if (knowsOfChurch == 1)
                {
                    page = 132;
                }
                else if (knowsOfThief == 1)
                {
                    page = 220;
                }
                else if (knowsOfCastle == 1)
                {
                    page = 250;
                }
                else if (trustInnKeeper == 1)
                {
                    page = 263;
                }
                else if (bloodlust == 1)
                {
                    page = 290;
                }
            }
            else if (page == 121)
            {
                page = 122;
            }
            else if (page == 123)
            {
                page = 119;
            }
            else if (page == 125)
            {
                page = 126;
            }
            else if (page == 134)
            {
                chance = ranGen.Next(1, 21);

                if (antiSocial == 1)
                    page = 135;
                else if (chance <= 5)
                    page = 135;
                else
                    page = 137;
            }
            else if (page == 137)
            {
                page = 198;
            }
            else if (page == 141)
            {
                page = 142;
            }
            else if (page == 146)
            {
                page = 147;
            }
            else if (page == 157)
            {
                page = 158;
            }
            else if (page == 159)
            {
                page = 164;
            }
            else if (page == 163)
            {
                page = 999;
            }
            else if (page == 166)
            {
                page = 167;
            }
            else if (page == 174)
            {
                page = 999;
            }
            else if (page == 168)
            {
                page = 170;
            }
            else if (page == 172)
            {
                page = 999;
            }
            else if (page == 193)
            {
                page = 999;
            }
            else if (page == 199)
            {
                page = 200;
            }
            else if (page == 197)
            {
                page = 198;
            }
            else if (page == 209)
            {
                page = 210;
            }
            else if (page == 213)
            {
                page = 214;
            }
            else if (page == 221)
            {
                page = 222;
            }
            else if (page == 225)
            {
                if (brokenArms == 1)
                {
                    page = 226;
                }
                else
                {
                    page = 228;
                }
            }
            else if (page == 227)
            {
                page = 999;
            }
            else if (page == 229)
            {
                page = 233;
            }
            else if (page == 234)
            {
                page = 235;
            }
            else if (page == 237)
            {
                page = 999;
            }
            else if (page == 245)
            {
                page = 999;
            }
            else if (page == 248)
            {
                page = 999;
            }
            else if (page == 252)
            {
                page = 255;
            }
            else if (page == 259)
            {
                page = 1230;
            }
            else if (page == 1231)
            {
                page = 1232;
            }
            else if (page == 1233)
            {
                page = 4;
            }
            else if (page == 1236)
            {
                page = 999;
            }
            else if (page == 1239)
            {
                page = 1240;
            }
            else if (page == 1246)
            {
                page = 4;
            }
            else if (page == 1248)
            {
                page = 1249;
            }
            else if (page == 1258)
            {
                page = 1259;
            }
            else if (page == 260)
            {
                page = 999;
            }
            else if (page == 262)
            {
                page = 999;
            }
            else if (page == 264)
            {
                page = 265;
            }
            else if (page == 268)
            {
                page = 273;
            }
            else if (page == 272)
            {
                page = 999;
            }
            else if (page == 277)
            {
                page = 999;
            }
            else if (page == 274)
            {
                page = 278;
            }
            else if (page == 279)
            {
                page = 280;
            }
            else if (page == 282)
            {
                page = 999;
            }
            else if (page == 285)
            {
                page = 999;
            }
            if (page == 289)
            {
                page = 999;
            }
            else if (page == 291)
            {
                page = 292;
            }
            else if (page == 292)
            {
                page = 999;
            }
            else if (page == 294)
            {
                page = 292;
            }
            else if (page == 296)
            {
                page = 292;
            }
            else if (page == 298)
            {
                page = 999;
            }
            else if (page == 1300)
            {
                page = 300;
            }
            else if (page == 306)
            {
                page = 307;
            }
            else if (page == 309)
            {
                page = 310;
            }
            else if (page == 313)
            {
                page = 60;
            }
            else if (page == 315)
            {
                page = 60;
            }
            else if (page == 318)
            {
                if (bloodlust == 1)
                    page = 329;
                else
                {
                    if (brokenArms == 1)
                    {
                        page = 325;
                    }
                    else
                    {
                        page = 319;
                    }
                }
            }
            else if (page == 320)
            {
                page = 321;
            }
            else if (page == 322)
            {
                page = 999;
            }
            else if (page == 324)
            {
                page = 999;
            }
            else if (page == 328)
            {
                page = 999;
            }
            else if (page == 333)
            {
                page = 999;
            }
            else if (page == 336)
            {
                if (bloodlust == 1)
                {
                    page = 337;
                }
                else if (character == 2 || antiSocial == 1)
                {
                    page = 340;
                }
                else
                {
                    page = 354;
                }
            }
            else if (page == 339)
            {
                page = 999;
            }
            else if (page == 345)
            {
                page = 346;
            }
            else if (page == 347)
            {
                page = 999;
            }
            else if (page == 349)
            {
                page = 999;
            }
            else if (page == 352)
            {
                page = 999;
            }
            else if (page == 353)
            {
                page = 999;
            }
            else if (page == 356)
            {
                page = 999;
            }
            else if (page == 359)
            {
                page = 999;
            }
            else if (page == 364)
            {
                page = 365;
            }
            else if (page == 365)
            {
                page = 999;
            }
            else if (page == 367)
            {
                page = 999;
            }
            else if (page == 369)
            {
                page = 370;
            }
            else if (page == 371)
            {
                page = 372;
            }
            else if (page == 373)
            {
                page = 999;
            }
            else if (page == 376)
            {
                page = 377;
            }
            else if (page == 377)
            {
                page = 378;
            }
            else if (page == 380)
            {
                page = 999;
            }
            else if (page == 383)
            {
                page = 999;
            }
            else if (page == 385)
            {
                page = 386;
            }
            else if (page == 388)
            {
                page = 999;
            }
            else if (page == 390)
            {
                page = 391;
            }
            else if (page == 393)
            {
                page = 394;
            }
            else if (page == 395)
            {
                page = 396;
            }
            else if (page == 398)
            {
                page = 999;
            }
            else if (page == 401)
            {
                page = 999;
            }
            else if (page == 404)
            {
                page = 999;
            }
            else if (page == 407)
            {
                page = 999;
            }

            //perform the actions on that page
            DisplayPage();
        }

        private void optionTwoButton_Click(object sender, EventArgs e)
        {
            //select next page
            if (page == 2)
            {
                page = 59;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 12)
            {
                page = 32;
            }
            else if (page == 14)
            {
                page = 11;
            }
            else if (page == 21)
            {
                page = 24;
            }
            else if (page == 32)
            {
                page = 11;
            }
            else if (page == 28)
            {
                page = 55;
            }
            else if (page == 41)
            {
                page = 47;
            }
            else if (page == 48)
            {
                page = 55;
            }
            else if (page == 60)
            {
                page = 61;
            }
            else if (page == 68)
            {
                if (saidNo == 1)
                {
                    page = 409;
                }
                else
                {
                    page = 412;
                }
            }
            else if (page == 70)
            {
                page = 67;
            }
            else if (page == 77)
            {
                page = 78;

            }
            else if (page == 78)
            {
                page = 79;
            }
            else if (page == 82)
            {
                page = 83;

            }
            else if (page == 85)
            {
                page = 86;
            }
            else if (page == 112)
            {
                page = 114;
            }
            else if (page == 119)
            {
                if (character == 1)
                {
                    page = 120;
                }
                else if (character == 2)
                {
                    page = 316;
                }
            }
            else if (page == 121)
            {
                page = 124;
            }
            else if (page == 123)
            {
                page = 124;
            }
            else if (page == 125)
            {
                page = 129;
            }
            else if (page == 134)
            {
                page = 196;
            }
            else if (page == 137)
            {
                page = 138;
            }
            else if (page == 141)
            {
                page = 194;
            }
            else if (page == 146)
            {
                page = 177;
            }
            else if (page == 157)
            {
                page = 175;
            }
            else if (page == 159)
            {
                page = 160;
            }
            else if (page == 166)
            {
                page = 173;
            }
            else if (page == 168)
            {
                page = 169;
            }
            else if (page == 197)
            {
                page = 199;
            }
            else if (page == 199)
            {
                page = 203;
            }
            else if (page == 213)
            {
                page = 215;
            }
            else if (page == 221)
            {
                page = 224;
            }
            else if (page == 229)
            {
                page = 230;
            }
            else if (page == 234)
            {
                page = 242;
            }
            else if (page == 252)
            {
                page = 257;
            }
            else if (page == 259)
            {
                page = 1237;
            }
            else if (page == 1231)
            {
                page = 1234;
            }
            else if (page == 1239)
            {
                page = 1230;
            }
            else if (page == 1248)
            {
                page = 1252;
            }
            else if (page == 1258)
            {
                page = 261;
            }
            else if (page == 264)
            {
                page = 286;
            }
            else if (page == 268)
            {
                page = 269;
            }
            else if (page == 274)
            {
                page = 275;
            }
            else if (page == 279)
            {
                page = 283;
            }
            else if (page == 291)
            {
                page = 293;
            }
            else if (page == 294)
            {
                page = 295;
            }
            else if (page == 296)
            {
                page = 297;
            }
            else if (page == 1300)
            {
                page = 301;
            }
            else if (page == 306)
            {
                page = 314;
            }
            else if (page == 309)
            {
                page = 314;
            }
            else if (page == 318)
            {
                page = 330;
            }
            else if (page == 336)
            {
                if (bloodlust == 1)
                {
                    page = 337;
                }
                else
                {
                    page = 357;
                }
            }
            else if (page == 364)
            {
                if (brokenArms == 1)
                {
                    page = 367;
                }
                else
                {
                    page = 366;
                }
            }
            else if (page == 345)
            {
                page = 348;
            }
            else if (page == 369)
            {
                page = 405;
            }
            else if (page == 371)
            {
                page = 374;
            }
            else if (page == 376)
            {
                page = 384;
            }
            else if (page == 377)
            {
                page = 381;
            }
            else if (page == 385)
            {
                page = 389;
            }
            else if (page == 390)
            {
                page = 402;
            }
            else if (page == 393)
            {
                page = 399;
            }
            else if (page == 395)
            {
                page = 396;
            }

            //perform the actions on that page
            DisplayPage();
        }

        private void optionThreeButton_Click(object sender, EventArgs e)
        {
            //select next page
            if (page == 14)
            {
                page = 15;
            }
            else if (page == 28)
            {
                if (shoesTied == 1)
                {
                    page = 31;
                }
                else
                {
                    page = 29;
                }
            }
            else if (page == 77)
            {
                page = 106;
            }
            else if (page == 28)
            {
                if (shoesTied == 1)
                {
                    page = 31;
                }
                else
                {
                    page = 29;
                }
            }
            else if (page == 119)
            {
                if (caughtMurder == 1)
                {
                    page = 299;
                }
            }
            else if (page == 166)
            {
                page = 160;
            }
            else if (page == 252)
            {
                if (knowsOfTunnels == 1)
                {
                    page = 1247;
                }
            }
            else if (page == 1300)
            {
                page = 302;
            }

            //perform the actions on that page
            DisplayPage();
        }

        private void optionFourButton_Click(object sender, EventArgs e)
        {
            //select next page
            if (page == 3)
            {
                page = 4;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 20;
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
                page = 21;
            }
            else if (page == 22)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 26;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 27;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 29)
            {
                page = 30;
            }
            else if (page == 31)
            {
                page = 119;
            }
            else if (page == 34)
            {
                page = 35;
            }
            else if (page == 35)
            {
                page = 36;
            }
            else if (page == 37)
            {
                page = 38;
            }
            else if (page == 38)
            {
                page = 39;
            }
            else if (page == 39)
            {
                page = 119;
            }
            else if (page == 40)
            {
                page = 41;
            }
            else if (page == 42)
            {
                page = 43;
            }
            else if (page == 43)
            {
                page = 44;
            }
            else if (page == 44)
            {
                if (brokenArms == 1)
                    page = 45;
                else
                    page = 46;
            }
            else if (page == 45)
            {
                page = 46;
            }
            else if (page == 46)
            {
                page = 119;
            }
            else if (page == 47)
            {
                page = 48;
            }
            else if (page == 49)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 51;
            }
            else if (page == 51)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 53;
            }
            else if (page == 53)
            {
                page = 54;
            }
            else if (page == 54)
            {
                page = 119;
            }
            else if (page == 55)
            {
                page = 56;
            }
            else if (page == 56)
            {
                page = 57;
            }
            else if (page == 57)
            {
                page = 58;
            }
            else if (page == 58)
            {
                page = 119;
            }
            else if (page == 59)
            {
                page = 60;
            }
            else if (page == 61)
            {
                page = 62;
            }
            else if (page == 62)
            {
                page = 65;
            }
            else if (page == 63)
            {
                page = 64;
            }
            else if (page == 64)
            {
                page = 65;
            }
            else if (page == 65)
            {
                page = 66;
            }
            else if (page == 66)
            {
                page = 67;
            }
            else if (page == 67)
            {
                page = 68;
            }
            else if (page == 69)
            {
                page = 70;
            }
            else if (page == 71)
            {
                page = 72;
            }
            else if (page == 72)
            {
                page = 73;
            }
            else if (page == 73)
            {
                page = 74;
            }
            else if (page == 74)
            {
                page = 75;
            }
            else if (page == 75)
            {
                page = 76;
            }
            else if (page == 76)
            {
                page = 77;
            }
            else if (page == 79)
            {
                page = 80;
            }
            else if (page == 80)
            {
                page = 81;
            }
            else if (page == 81)
            {
                page = 82;
            }
            else if (page == 83)
            {
                page = 84;
            }
            else if (page == 84)
            {
                page = 85;
            }
            else if (page == 86)
            {
                page = 87;
            }
            else if (page == 87)
            {
                page = 88;
            }
            else if (page == 88)
            {
                page = 89;
            }
            else if (page == 89)
            {
                page = 90;
            }
            else if (page == 91)
            {
                page = 92;
            }
            else if (page == 92)
            {
                page = 93;
            }
            else if (page == 93)
            {
                page = 94;
            }
            else if (page == 94)
            {
                page = 95;
            }
            else if (page == 95)
            {
                page = 96;
            }
            else if (page == 96)
            {
                page = 97;
            }
            else if (page == 97)
            {
                page = 119;
            }
            else if (page == 98)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 100;
            }
            else if (page == 100)
            {
                page = 101;
            }
            else if (page == 101)
            {
                page = 102;
            }
            else if (page == 102)
            {
                page = 119;
            }
            else if (page == 103)
            {
                page = 104;
            }
            else if (page == 104)
            {
                page = 119;
            }
            else if (page == 105)
            {
                page = 119;
            }
            else if (page == 106)
            {
                page = 107;
            }
            else if (page == 107)
            {
                page = 108;
            }
            else if (page == 108)
            {
                page = 109;
            }
            else if (page == 109)
            {
                page = 110;
            }
            else if (page == 110)
            {
                page = 111;
            }
            else if (page == 111)
            {
                page = 112;
            }
            else if (page == 113)
            {
                page = 119;
            }
            else if (page == 114)
            {
                page = 115;
            }
            else if (page == 115)
            {
                page = 116;
            }
            else if (page == 116)
            {
                page = 117;
            }
            else if (page == 117)
            {
                page = 118;
            }
            else if (page == 118)
            {
                page = 119;
            }
            else if (page == 119)
            {
                if (brokenLegs == 0)
                {
                    page = 334;
                }
            }
            else if (page == 120)
            {
                page = 121;
            }
            else if (page == 122)
            {
                page = 123;
            }
            else if (page == 123)
            {
                page = 119;
            }
            else if (page == 124)
            {
                page = 125;
            }
            else if (page == 126)
            {
                page = 127;
            }
            else if (page == 127)
            {
                page = 128;
            }
            else if (page == 128)
            {
                page = 119;
            }
            else if (page == 129)
            {
                page = 130;
            }
            else if (page == 130)
            {
                page = 131;
            }
            else if (page == 131)
            {
                page = 368;
            }
            else if (page == 132)
            {
                page = 133;
            }
            else if (page == 133)
            {
                page = 134;
            }
            else if (page == 135)
            {
                page = 136;
            }
            else if (page == 136)
            {
                page = 363;
            }
            else if (page == 138)
            {
                page = 139;
            }
            else if (page == 139)
            {
                page = 140;
            }
            else if (page == 140)
            {
                page = 141;
            }
            else if (page == 142)
            {
                page = 143;
            }
            else if (page == 143)
            {
                page = 144;
            }
            else if (page == 144)
            {
                page = 145;
            }
            else if (page == 145)
            {
                page = 146;
            }
            else if (page == 147)
            {
                page = 148;
            }
            else if (page == 148)
            {
                page = 149;
            }
            else if (page == 149)
            {
                page = 150;
            }
            else if (page == 150)
            {
                page = 151;
            }
            else if (page == 151) //TEXT RANDOM
            {
                chance = ranGen.Next(1, 11);
                if (chance == 10)
                {
                    page = 152;
                }
                else
                {
                    page = 154;
                }
            }
            else if (page == 152)
            {
                page = 153;
            }
            else if (page == 153)
            {
                page = 368;
            }
            else if (page == 154)
            {
                page = 155;
            }
            else if (page == 155)
            {
                page = 156;
            }
            else if (page == 156)
            {
                page = 157;
            }
            else if (page == 158)
            {
                page = 159;
            }
            else if (page == 160)
            {
                page = 161;
            }
            else if (page == 161)
            {
                page = 162;
            }
            else if (page == 162)
            {
                page = 163;
            }
            else if (page == 164)
            {
                page = 165;
            }
            else if (page == 165)
            {
                page = 166;
            }
            else if (page == 167)
            {
                page = 168;
            }
            else if (page == 169)
            {
                page = 171;
            }
            else if (page == 170)
            {
                page = 171;
            }
            else if (page == 171)
            {
                page = 172;
            }
            else if (page == 173)
            {
                page = 174;
            }
            else if (page == 175)
            {
                page = 176;
            }
            else if (page == 177)
            {
                page = 178;
            }
            else if (page == 178)
            {
                page = 179;
            }
            else if (page == 179)
            {
                page = 180;
            }
            else if (page == 180)
            {
                page = 181;
            }
            else if (page == 181)
            {
                page = 182;
            }
            else if (page == 182)
            {
                page = 183;
            }
            else if (page == 183)
            {
                page = 184;
            }
            else if (page == 184)
            {
                page = 185;
            }
            else if (page == 185)
            {
                page = 186;
            }
            else if (page == 186)
            {
                page = 187;
            }
            else if (page == 187)
            {
                page = 188;
            }
            else if (page == 188)
            {
                page = 189;
            }
            else if (page == 189)
            {
                page = 190;
            }
            else if (page == 190)
            {
                page = 191;
            }
            else if (page == 191)
            {
                page = 192;
            }
            else if (page == 192)
            {
                page = 193;
            }
            else if (page == 194)
            {
                page = 195;
            }
            else if (page == 195)
            {
                page = 363;
            }
            else if (page == 196)
            {
                page = 197;
            }
            else if (page == 198)
            {
                page = 363;
            }
            else if (page == 200)
            {
                page = 201;
            }
            else if (page == 201)
            {
                page = 202;
            }
            else if (page == 202)
            {
                page = 363;
            }
            else if (page == 203) //TEST RANDOM + VARIABLE TRACKING
            {
                chance = ranGen.Next(1, 6);
                if (chance == 5)
                {
                    page = 204;
                }
                else
                {
                    if (antiSocial == 1)
                    {
                        page = 204;
                    }
                    else
                    {
                        page = 207;
                    }
                }
            }
            else if (page == 204)
            {
                page = 205;
            }
            else if (page == 205)
            {
                page = 206;
            }
            else if (page == 206)
            {
                page = 368;
            }
            else if (page == 207)
            {
                page = 208;
            }
            else if (page == 208)
            {
                page = 209;
            }
            else if (page == 210)
            {
                page = 211;
            }
            else if (page == 211)
            {
                page = 212;
            }
            else if (page == 212)
            {
                page = 213;
            }
            else if (page == 214)
            {
                page = 119;
            }
            else if (page == 215)
            {
                page = 216;
            }
            else if (page == 216)
            {
                page = 217;
            }
            else if (page == 217)
            {
                page = 368;
            }
            else if (page == 218)
            {
                page = 219;
            }
            else if (page == 219)
            {
                page = 363;
            }
            else if (page == 220)
            {
                page = 221;
            }
            else if (page == 222)
            {
                page = 223;
            }
            else if (page == 223)
            {
                page = 368;
            }
            else if (page == 224)
            {
                page = 225;
            }
            else if (page == 225)
            {
                if (brokenArms == 1)
                {
                    page = 226;
                }
                else
                {
                    page = 228;
                }
            }
            else if (page == 226)
            {
                page = 227;
            }
            else if (page == 228)
            {
                page = 229;
            }
            else if (page == 230) //RANDOM CHANCE TEST
            {
                chance = ranGen.Next(1, 6);
                if (chance <= 2)
                {
                    page = 249;
                }
                else
                {
                    page = 231;
                }

            }
            else if (page == 231)
            {
                page = 232;
            }
            else if (page == 232)
            {
                page = 233;
            }
            else if (page == 233)
            {
                page = 234;
            }
            else if (page == 235)
            {
                if (hasSpoon == 1)
                {
                    page = 240;
                }
                else if (hasKnife == 1)
                {
                    page = 238;
                }
                else
                {
                    page = 236;
                }
            }
            else if (page == 236)
            {
                page = 237;
            }
            else if (page == 238)
            {
                page = 239;
            }
            else if (page == 239)
            {
                page = 245;
            }
            else if (page == 240)
            {
                page = 241;
            }
            else if (page == 241)
            {
                page = 245;
            }
            else if (page == 242)
            {
                if (antiSocial == 1)
                {
                    page = 246;
                }
                else if (hasKnife == 1 || hasSpoon == 1)
                {
                    page = 243;
                }
                else
                {
                    page = 247;
                }
            }
            else if (page == 243)
            {
                page = 244;
            }
            else if (page == 244)
            {
                page = 245;
            }
            else if (page == 246)
            {
                page = 247;
            }
            else if (page == 247)
            {
                page = 248;
            }
            else if (page == 249)
            {
                page = 232;
            }
            else if (page == 250)
            {
                page = 251;
            }
            else if (page == 251) //REMEMBER TO EDIT PAGE 253 TO FIT THE IDEA THAT PLAYER IS ANTI SOCIAL
            {
                if (antiSocial == 1)
                {
                    page = 253;
                }
                else
                {
                    page = 252;
                }
            }
            else if (page == 253)
            {
                page = 254;
            }
            else if (page == 254)
            {
                page = 119;
            }
            else if (page == 255)
            {
                page = 256;
            }
            else if (page == 256)
            {
                page = 119;
            }
            else if (page == 257)
            {
                page = 258;
            }
            else if (page == 258)
            {
                page = 259;
            }
            else if (page == 1230)
            {
                page = 1231;
            }
            else if (page == 1232)
            {
                page = 1233;
            }
            else if (page == 1233)
            {
                page = 4;
            }
            else if (page == 1234)
            {
                page = 1235;
            }
            else if (page == 1235)
            {
                page = 1236;
            }
            else if (page == 1237)
            {
                page = 1238;
            }
            else if (page == 1238)
            {
                page = 1239;
            }
            else if (page == 1239)
            {
                page = 1240;
            }
            else if (page == 1240)
            {
                page = 1241;
            }
            else if (page == 1241)
            {
                page = 1242;
            }
            else if (page == 1242)
            {
                page = 1243;
            }
            else if (page == 1243)
            {
                page = 1244;
            }
            else if (page == 1244)
            {
                page = 1245;
            }
            else if (page == 1245)
            {
                page = 1246;
            }
            else if (page == 1246)
            {
                page = 4;
            }
            else if (page == 1247)
            {
                page = 1248;
            }
            else if (page == 1249)
            {
                page = 1250;
            }
            else if (page == 1250)
            {
                page = 1251;
            }
            else if (page == 1251)
            {
                page = 119;
            }
            else if (page == 1252)
            {
                page = 1253;
            }
            else if (page == 1253)
            {
                page = 1254;
            }
            else if (page == 1254)
            {
                page = 1255;
            }
            else if (page == 1255)
            {
                page = 119;
            }
            else if (page == 1256)
            {
                page = 1257;
            }
            else if (page == 1257)
            {
                page = 1258;
            }
            else if (page == 1259)
            {
                page = 260;
            }
            else if (page == 261)
            {
                page = 262;
            }
            else if (page == 263)
            {
                page = 264;
            }
            else if (page == 265)
            {
                page = 266;
            }
            else if (page == 266)
            {
                page = 267;
            }
            else if (page == 267)
            {
                page = 268;
            }
            else if (page == 269)
            {
                page = 270;
            }
            else if (page == 270)
            {
                page = 271;
            }
            else if (page == 271)
            {
                page = 272;
            }
            else if (page == 273)
            {
                page = 274;
            }
            else if (page == 275)
            {
                page = 276;
            }
            else if (page == 276)
            {
                page = 277;
            }
            else if (page == 278)
            {
                page = 279;
            }
            else if (page == 280)
            {
                page = 281;
            }
            else if (page == 281)
            {
                page = 282;
            }
            else if (page == 283)
            {
                page = 284;
            }
            else if (page == 284)
            {
                page = 285;
            }
            else if (page == 286)
            {
                page = 287;
            }
            else if (page == 287)
            {
                page = 288;
            }
            else if (page == 288)
            {
                page = 289;
            }
            else if (page == 290)
            {
                page = 291;
            }
            else if (page == 293)
            {
                page = 294;
            }
            else if (page == 295)
            {
                page = 296;
            }
            else if (page == 297)
            {
                page = 298;
            }
            else if (page == 299)
            {
                page = 1300;
            }
            else if (page == 1300)
            {
                page = 303;
            }
            else if (page == 300)
            {
                page = 304;
            }
            else if (page == 301)
            {
                page = 304;
            }
            else if (page == 302)
            {
                page = 304;
            }
            else if (page == 303)
            {
                page = 304;
            }
            else if (page == 304)
            {
                page = 305;
            }
            else if (page == 305)
            {
                page = 306;
            }
            else if (page == 306)
            {
                page = 307;
            }
            else if (page == 307)
            {
                page = 308;
            }
            else if (page == 308)
            {
                page = 309;
            }
            else if (page == 310)
            {
                page = 311;
            }
            else if (page == 311)
            {
                page = 312;
            }
            else if (page == 312)
            {
                page = 313;
            }
            else if (page == 314)
            {
                page = 315;
            }
            else if (page == 315)
            {
                page = 60;
            }
            else if (page == 316)
            {
                page = 317;
            }
            else if (page == 317)
            {
                page = 318;
            }
            else if (page == 319)
            {
                page = 320;
            }
            else if (page == 321)
            {
                page = 322;
            }
            else if (page == 323)
            {
                page = 324;
            }
            else if (page == 325)
            {
                page = 326;
            }
            else if (page == 326)
            {
                page = 327;
            }
            else if (page == 327)
            {
                page = 328;
            }
            else if (page == 329)
            {
                page = 330;
            }
            else if (page == 330)
            {
                page = 331;
            }
            else if (page == 331)
            {
                page = 332;
            }
            else if (page == 332)
            {
                page = 333;
            }
            else if (page == 334)
            {
                page = 335;
            }
            else if (page == 335)
            {
                page = 336;
            }
            else if (page == 337)
            {
                page = 338;
            }
            else if (page == 338)
            {
                page = 339;
            }
            else if (page == 340)
            {
                page = 341;
            }
            else if (page == 341)
            {
                if (hasCube == 1)
                {
                    page = 350;
                }
                else
                {
                    page = 342;
                }
            }
            else if (page == 342)
            {
                page = 345;
            }
            else if (page == 346)
            {
                page = 347;
            }
            else if (page == 348)
            {
                page = 349;
            }
            else if (page == 350)
            {
                page = 351;
            }
            else if (page == 351)
            {
                if (character == 1)
                {
                    page = 352;
                }
                else
                {
                    page = 353;
                }
            }
            else if (page == 354)
            {
                page = 355;
            }
            else if (page == 355)
            {
                page = 356;
            }
            else if (page == 357)
            {
                page = 358;
            }
            else if (page == 358)
            {
                page = 359;
            }
            else if (page == 363)
            {
                page = 364;
            }
            else if (page == 366)
            {
                page = 119;
            }
            else if (page == 368) //Increasingly difficult to enter the date sim
            {
                //generate number and 
                //make sure that the player will always make it the first time
                chance = ranGen.Next(1, 11);
                chance = chance + movedOnChance;

                if (chance >= 10)
                {
                    page = 1368;
                }
                else
                {
                    page = 369;
                }

                //make it so the player has an increasingly small chance to get back into the date sim
                movedOnChance += 1;

                ///NOTE: never reset the value of movedOnChance, it'll reset when the player reloads the entire game
            }
            else if (page == 1368)
            {
                page = 407;
            }
            else if (page == 370)
            {
                page = 371;
            }
            else if (page == 372)
            {
                page = 373;
            }
            else if (page == 374)
            {
                page = 375;
            }
            else if (page == 375)
            {
                page = 376;
            }
            else if (page == 378)
            {
                page = 379;
            }
            else if (page == 379)
            {
                page = 380;
            }
            else if (page == 381)
            {
                page = 383;
            }
            else if (page == 382)
            {
                page = 383;
            }
            else if (page == 384)
            {
                page = 385;
            }
            else if (page == 386)
            {
                page = 387;
            }
            else if (page == 387)
            {
                page = 388;
            }
            else if (page == 389)
            {
                page = 390;
            }
            else if (page == 391)
            {
                page = 392;
            }
            else if (page == 392)
            {
                page = 393;
            }
            else if (page == 394)
            {
                page = 395;
            }
            else if (page == 396)
            {
                page = 397;
            }
            else if (page == 397)
            {
                page = 398;
            }
            else if (page == 399)
            {
                page = 400;
            }
            else if (page == 400)
            {
                page = 401;
            }
            else if (page == 402)
            {
                page = 403;
            }
            else if (page == 403)
            {
                page = 404;
            }
            else if (page == 405)
            {
                page = 406;
            }
            else if (page == 406)
            {
                page = 407;
            }
            else if (page == 409)
            {
                page = 410;
            }
            else if (page == 410)
            {
                page = 411;
            }
            else if (page == 411)
            {
                page = 415;
            }
            else if (page == 412)
            {
                page = 413;
            }
            else if (page == 413)
            {
                page = 414;
            }
            else if (page == 414)
            {
                page = 415;
            }
            else if (page == 415)
            {
                page = 119;
            }







            //perform the actions on that page
            DisplayPage();
        }

        public void DisplayPage()
        {
            //play button click
            if (insideDateSim == 0)
            {
                //play default click
                click.Play();
            }
            else
            {
                //play heart beat sound
                heartbeat.Play();
            }
            //display page
            pageNumberLabel.Text = $"page: {page}";

            switch (page)
            {
                case 2: ///
                    {
                        //transition from main menu to game
                        {
                            //hide buttons
                            playStartButton.Visible = false;
                            closeStartButon.Visible = false;

                            //start animation
                            startAnimBox.Visible = true;
                            Refresh();
                            {
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                            }

                            //Ui established
                            mainUiBox.Visible = true;
                            mainMenuBox.Image = Properties.Resources.scene;

                            //icon animation
                            iconFadeInBox.Visible = true;
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            //iconBox.Visible = true;
                            //Refresh();
                            startAnimBox.Visible = false;
                            iconFadeInBox.Visible = false;
                            //Refresh();
                        }

                        //output
                        outputLabel.Text = "Will you play as Jon or Shimshon?";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "Jon";
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Shimshon";
                        optionTwoButton.Enabled = true;
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                        iconBox.Visible = true;
                    }
                    break;

                case 3:  //name character  
                    {
                        //output
                        outputLabel.Text = "Please write your player's name in the box.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        playerNameText.Visible = true;
                        playerNameText.Enabled = true;
                        playerNameTextTip.Visible = true;
                        playerNameTextJon.Visible = true;
                        character = 1;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 4: ///icon, reset
                    {
                        //name input
                        player = playerNameText.Text;
                        if (player == "")
                        {
                            player = "Jon";
                        }
                        playerNameText.Visible = false;
                        playerNameText.Enabled = false;
                        playerNameTextTip.Visible = false;
                        playerNameTextJon.Visible = false;

                        //memory wipe
                        forgetReset();

                        //output
                        outputLabel.Text = "Mysterious Voice: Is anyone awake?";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONmysteriousVoice;
                        ICONcharacter = Properties.Resources.CharacterJon;

                        //button settings
                        optionOneButton.Text = "Yes";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "No";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 5: ///icon
                    {
                        //output
                        outputLabel.Text = $"{player}: No sir";
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 6: ///icon
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: Obviously if you can respond you are awake.";
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        saidNo = 1;
                    }
                    break;

                case 7: ///icon
                    {
                        //output
                        outputLabel.Text = $"{player}: Of course, who could sleep through that noise?";
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 8: ///icon
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: I'm just making sure you're alright.";
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 9:
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: You can't stay in this room anymore.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 10: ///icon
                    {
                        //output
                        outputLabel.Text = $"The world rattles as the echoes of bombs ring in {player}'s ears.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 11: ///scene window
                    {
                        //output
                        outputLabel.Text = $"{player} believes they are in a room of some kind.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 12:
                    {
                        //output
                        outputLabel.Text = $"{player} sees what appears to be light from a window to their left.";

                        //button settings
                        optionOneButton.Text = "Search for a door";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Approach the window";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 13:
                    {
                        //output
                        outputLabel.Text = $"It was easy to find the door, it was right behind {player}.  It took a moment of stumbling around in the dark, but they found it.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 14:
                    {
                        //output
                        outputLabel.Text = $"The door is locked, but {player} could pick it.";

                        //button settings
                        optionOneButton.Text = "Pick the lock";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Head back to room";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionThreeButton.Text = "Break down the door";
                        optionThreeBlocked.Visible = false;
                        optionThreeButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 15: ///scene hallway
                    {
                        //output
                        outputLabel.Text = $"The door stood no chance against the might of {player}, despite their weak fragile body.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 16:
                    {
                        //output
                        outputLabel.Text = $"Congratulations! {player} broke their arm and gained access to the hallways.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 17:
                    {
                        //output
                        outputLabel.Text = $"{player} will no longer be able to lockpick.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        brokenArms = 1;
                    }
                    break;

                case 18:
                    {
                        //output
                        outputLabel.Text = $"The lock stood no chance against the wit of {player}!";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 19:
                    {
                        //output
                        outputLabel.Text = "The door swings open, revealing the water-stained blue hallway.";

                        //button settings
                        optionFourButton.Text = "Next";

                    }
                    break;

                case 20:
                    {
                        //output
                        outputLabel.Text = $"{player} is met by a staircase at the end of the hallway, which weaves through a long and bendy corridor.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 21: ///scene shoes
                    {
                        //output
                        outputLabel.Text = $"{player}'s shoes are untied. Do they tie them?";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Yes";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "No";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 22: ///scene hallway
                    {
                        //output
                        outputLabel.Text = $"As {player} makes their way through the dewy hallway, the crashing of explosives continues nearby.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 23: ///scene bottom stairs
                    {
                        //output
                        outputLabel.Text = $"{player} slowly descends down a squeaking stair case, and makes their way to what appears to be a reception desk.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        shoesTied = 1;
                    }
                    break;

                case 24: ///scene hallway
                    {
                        //output
                        outputLabel.Text = $"As {player} makes their way through the dewy hallway, the crashing of explosives continues nearby.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 25: ///scene bottom stairs
                    {
                        //output
                        outputLabel.Text = $"{player} slowly descends down a squeaking stair case—being careful not to step on their laces—and makes their way to what appears to be a reception desk.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 26:
                    {
                        //output
                        outputLabel.Text = $"An older man with a well kept bushy beard waits for {player} at the front of the desk. In his hair is a small pink pin. The walls behind him are covered in menus and the artistic scribbles of his daughter.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 27:
                    {
                        //output
                        outputLabel.Text = $"As he stands there, he waves {player} over to him. He appears friendly, so they approach him.";

                        //button settings
                        optionFourButton.Text = "Next";

                    }
                    break;

                case 28: /// icon keeper, scene closer to desk
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: Bumpy start to the day! Good morning to you, my friend. Can I help you with anything?";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONinnKeeper;

                        //button settings
                        optionOneButton.Text = "'Would you mind telling me where we are?'";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "'What is that noise?'";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionThreeButton.Text = "Leave without saying a word";
                        optionThreeBlocked.Visible = false;
                        optionThreeButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 29: ///icon
                    {
                        //output
                        outputLabel.Text = $"{player} is leaving for the door, but is caught by their shoe lace. They trip over and slam their head on the base of a solid metal standing coat-hanger.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 30: ///scene
                    {
                        //output
                        outputLabel.Text = $"{player} blacks out.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Whoopsies";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 31: ///icon
                    {
                        //output
                        outputLabel.Text = $"{player} left the Inn.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;

                        //status update
                        antiSocial = 1;
                    }
                    break;

                case 32: ///scene look out window
                    {
                        //output
                        outputLabel.Text = $"{player} approaches the window. They recognize that they are on the third story.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Jump out window";
                        optionTwoButton.Text = "Head back to room";
                    }
                    break;

                case 34: ///scene impaled
                    {
                        //output
                        outputLabel.Text = $"{player} leaps through the window. As they soar majestically through the sky, they are impaled by a tall metal fence post.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 35:
                    {
                        //output
                        outputLabel.Text = $"{player} dies of blood loss.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 36:
                    {
                        //output
                        outputLabel.Text = $"Sometimes, being polite will get you further in life. Not often, though.";

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 37: ///scene shattered legs
                    {
                        //output
                        outputLabel.Text = $"{player} leaps through the window. As they land down below, they shatter both legs.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 38:
                    {
                        //output
                        outputLabel.Text = $"The pain is blocked by the adrenaline rush that {player} receives.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //Status update
                        brokenLegs = 1;
                    }
                    break;

                case 39: ///icon broken legs outside jon
                    {
                        //output
                        outputLabel.Text = $"{player} can no longer move. Take the stairs next time.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 40:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: I may need you to be more specific, my friend. You checked in here last night, I don't believe we talked much at all.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 41:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: Do you mean to ask which kingdom you're in?";

                        //button settings
                        optionOneButton.Text = "'Checked in? If this place is an Inn, why was I locked into my room?'";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "'Yes, which kigdom?'";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 42:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: My apologies for that, I was only looking out for your safety.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 43:
                    {
                        //output
                        outputLabel.Text = $"Inn Keeper: There was a thief who was coming in through the ground floor windows, stealing from my customers in the night. So I started locking everything, even the bedroom doors.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //Status update
                        knowsOfThief = 1;
                    }
                    break;

                case 44:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: I did plan to unlock it early in the morning... Actually I should go unlock the other doors now. Sorry for the trouble that caused you.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 45: ///icon default, scene cube
                    {
                        //output
                        outputLabel.Text = $"{player} received a 1kg cube of some kind of substance as an apology gift from the Inn Keeper.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        hasCube = 1;
                    }
                    break;

                case 46: ///scene outside inn
                    {
                        //output
                        outputLabel.Text = $"{player} heads outside.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 47:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: I can't give a clear answer anymore, as things are falling apart around here. We were known as Lakefysh before the court Jester's new name for the city caught on with the locals.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 48:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: The King's entire blood line supposedly died in their sleep, so here in the capital things have been... shaky to say the least.";

                        //button settings
                        optionOneButton.Text = "'Court Jester's new name?'";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "'Shaky, huh?'";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 49:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: She renamed it to the 'Kingdom of Clay-Heads.'";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 50: //
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: Surprisingly, she's gained quite the large following due to her cruel honesty and manipulative speech.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        knowsOfCastle = 1;
                    }
                    break;

                case 51:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: At the current rate, she'll probably weasel her way to the peak of command in this kingdom.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 52:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: The only things stopping her from ruling this country are global politics and the Church. I pray that fool doesn't succeed.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 53:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: Oh dear, I need to unlock the bedroom doors. Safe travels, my friend.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 54: //icon
                    {
                        //output
                        outputLabel.Text = $"{player} heads outside.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 55:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: That would be the Church. No one really knows what they are doing in there, but their noises relentlessly beat into the city streets all day and all night.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;

                        //status update
                        knowsOfChurch = 1;
                    }
                    break;

                case 56: //
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: You get used to it after living here for a bit. It actually only started recently, after the King's death.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 57:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: Would you excuse me? I need to go unlock the bedroom doors. Safe travels, my friend.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 58: ///icon default
                    {
                        //output
                        outputLabel.Text = $"{player} heads outside.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 59: ///scene character select
                    {
                        //output
                        outputLabel.Text = "Please write your player's name in the box.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;
                        playerNameText.Visible = true;
                        playerNameText.Enabled = true;
                        playerNameTextTip.Visible = true;
                        playerNameTextShimshon.Visible = true;
                        character = 2;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 60: ///icon, reset stuff
                    {
                        //name input
                        player = playerNameText.Text;
                        if (player == "")
                        {
                            player = "Shimshon";
                        }
                        playerNameText.Visible = false;
                        playerNameText.Enabled = false;
                        playerNameTextTip.Visible = false;
                        playerNameTextShimshon.Visible = false;

                        //momory wipe
                        forgetReset();

                        //output
                        outputLabel.Text = "Mysterious Voice: Is anyone awake?";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONmysteriousVoice;
                        ICONcharacter = Properties.Resources.CharacterShimshon;

                        //button settings
                        optionOneButton.Text = "Yes";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "No";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 61: ///icon shim
                    {
                        //output
                        outputLabel.Text = $"{player}: Awoga bog.";
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;

                        //status update
                        saidNo = 1;
                    }
                    break;

                case 62: //icon mys
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: Oh boy... you are certainly illiterate. Poor little guy... I'll take that as a yes.";
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 63: ///icon player
                    {
                        //output
                        outputLabel.Text = $"{player}: * Grunts like a sexually frustrated whale";
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 64: /// icon mys
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: Don't just grunt at me, you filthy barbarian!";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 65:
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: You can't stay in this room anymore.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 66:
                    {
                        //output
                        outputLabel.Text = $"The world rattles as the echoes of bombs ring in {player}'s' ears.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 67:
                    {
                        //output
                        outputLabel.Text = $"{player} believes they are in a room of some kind.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 68: /// scene window
                    {
                        //output
                        outputLabel.Text = $"{player} sees what appears to be light from a window to their left.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Search for door";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Sprint towards window";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 69:
                    {
                        //output
                        outputLabel.Text = $"After searching for what seemed like ages to their tiny brain, {player} successfully found the door.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 70:
                    {
                        //output
                        outputLabel.Text = $"The door is locked, what would {player} like to do?";

                        //button settings
                        optionOneButton.Text = "Break down door";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Head back to room";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 71: ///scene hallway
                    {
                        //output
                        outputLabel.Text = $"The door stood no chance against the might of {player}!";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 72:
                    {
                        //output
                        outputLabel.Text = $"Congratulations! {player} broke their arm and gained access to the hallways.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 73:
                    {
                        //output
                        outputLabel.Text = $"{player} will no longer be able to pickpocket.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        brokenArms = 1;
                    }
                    break;

                case 74:
                    {
                        //output
                        outputLabel.Text = $"{player} is met by a staircase at the end of the hallway, which weaves through a long and bendy corridor.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 75: //scene slippers
                    {
                        //output
                        outputLabel.Text = $"The steps of {player} are masked by their pink bunny slippers, slippers of which are worn to increase {player}'s sneakiness.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 76: //scene bottom stairs
                    {
                        //output
                        outputLabel.Text = $"Once at the bottom, {player} sees something at what might possibly be a reception desk.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 77:
                    {
                        //output
                        outputLabel.Text = $"{player} wonders why it stands there...";

                        //button settings
                        optionOneButton.Text = "Leave without saying a word";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Investigate 'The Thing That Stands'";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionThreeButton.Text = "KILL KILL KILL";
                        optionThreeBlocked.Visible = false;
                        optionThreeButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 78: ///scene closer to inn keeper
                    {
                        //output
                        outputLabel.Text = "Investiation:";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Study it's behaviour";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Talk to it";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                    }
                    break;

                case 79: //player icon
                    {
                        //output
                        outputLabel.Text = $"{player}: & G#^ GROG *&*** SLAAAAAAAAAAA";
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 80: //icon inn
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: Excuse me, friend...?";
                        iconBox.Image = ICONinnKeeper;

                        //button settings;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 81:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: I don't really understand you, and I bet with speech like that will turn away my customers.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 82:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: I hope you get what I am saying...";

                        //button settings
                        optionOneButton.Text = "'You want me to leave?'";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Tell a knock-knock joke";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 83: //icon shim
                    {
                        //output
                        outputLabel.Text = $"{player}: NOK NOK! WHUS TGER? WIPPPPY!!!!";
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 84: //icon display
                    {
                        //output
                        outputLabel.Text = $"{player} laughs manically while 'The Thing That Stands' begins to fear for its life.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 85:
                    {
                        //output
                        outputLabel.Text = "'It' chuckles slightly in an attempt to hide its fear.";

                        //button settings
                        optionOneButton.Text = "Notice that the knock-knock joke was a flop";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = $"It's fear excites {player}";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 86:
                    {
                        //output
                        outputLabel.Text = $"{player} can smell the bitter scent of its fear.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 87:
                    {
                        //output
                        outputLabel.Text = $"{player} attempts to eat 'The Thing That Stands,' however fails to do so.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 88: //scene dead on inn floor
                    {
                        //output
                        outputLabel.Text = $"As the body of {player} hits the ground, 'The Thing That Stands' runs away through the door.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 89:
                    {
                        //output
                        outputLabel.Text = "'It' thanks the guards outside. Another moment and 'It' knew it would have lost its life.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 90:
                    {
                        //output
                        outputLabel.Text = "It is wrong to try to eat someone while they are talking to you.";

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 91:
                    {
                        //output
                        outputLabel.Text = $"{player} slowly approaches 'The Thing That Stands' reception desk.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 92:
                    {
                        //output
                        outputLabel.Text = $"The desk is covered in strange oddities, all of which are unknown to {player}.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 93:
                    {
                        //output
                        outputLabel.Text = $"{player} begins knocking objects off of the table in quick, cat-like motions. As objects rain down from the table, 'The Thing That Stands' shouts from behind:";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 94: //icon innn keeper
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: I have an Inn to run here buddy, I can't let you do that.";
                        iconBox.Image = ICONinnKeeper;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 95:
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: GET OUT!";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 96: //icon default
                    {
                        //output
                        outputLabel.Text = $"{player} did not understand much of what 'The Thing That Stands' said.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 97:
                    {
                        //output
                        outputLabel.Text = $"{player} spots something shiny outside, and leaves.";

                        //button settings
                        optionFourButton.Text = "I love shiny things";
                    }
                    break;

                case 98: //player icon
                    {
                        //output
                        outputLabel.Text = $"{player}: rar tloo #&^& slab";
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 99: //icon default
                    {
                        //output
                        outputLabel.Text = $"'The Thing That Stands' does not understand {player}, but 'it' begins to pity {player}.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 100: //scene cube
                    {
                        //output
                        outputLabel.Text = "'The Thing That Stands' introduces itself as the Inn Keeper, and offers you a 1kg cube of some kind of substance.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 101:
                    {
                        //output
                        outputLabel.Text = $"{player} does not fully understand anything that has happened, or why they are being given a big square...";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        trustInnKeeper = 1;
                    }
                    break;

                case 102:
                    {
                        //output
                        outputLabel.Text = $"Still, they feel a strange new trust towards the Inn Keeper as they head outside.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 103:
                    {
                        //output
                        outputLabel.Text = $"{player} feels unwanted.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 104:
                    {
                        //output
                        outputLabel.Text = $"{player} leaves the building. From the outside, even the small brain of {player} can figure out that this building is an Inn";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 105:
                    {
                        //output
                        outputLabel.Text = $"{player} leaves the building. From the outside, even the small brain of {player} can figure out that this building is an Inn";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 106: //scene flying towards
                    {
                        //output
                        outputLabel.Text = $"Before a single word is uttered from 'The Thing That Stands', {player} pushes themselves off of the stairs and leaps through the air.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 107:
                    {
                        //output
                        outputLabel.Text = $"{player} stares into the eyes of 'The Thing That Stands' as they make contact with their upper body.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 108: //scene crouch atop
                    {
                        //output
                        outputLabel.Text = $"{player} crouches atop the shoulders of 'It', and grabs its head.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 109: //scene red room
                    {
                        //output
                        outputLabel.Text = "The room is painted red.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 110:
                    {
                        //output
                        outputLabel.Text = $"{player} has decapitated the Inn Keeper.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 111: //
                    {
                        //output
                        outputLabel.Text = $"{player} has been permanently blinded by their new found blood-lust.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        bloodlust = 1;
                    }
                    break;

                case 112: //scene in front of body
                    {
                        //output
                        outputLabel.Text = $"{player} stands in front of the body.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Continue the hunt outside";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Loot the body";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 113: //scene outside
                    {
                        //output
                        outputLabel.Text = $"{player} heads outside in search of more victims.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 114:
                    {
                        //output
                        outputLabel.Text = $"{player} combs through every pocket on the body.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 115: //scene cube
                    {
                        //output
                        outputLabel.Text = $"{player} grabs hold of a 1kg cube of some kind of substance.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update 
                        hasCube = 1;
                    }
                    break;

                case 116:
                    {
                        //output
                        outputLabel.Text = "They stash away the cube on their person.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 117: //scene caught
                    {
                        //output
                        outputLabel.Text = $"Someone spots {player}'s crime through the window and begins to giggle.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        caughtMurder = 1;
                    }
                    break;

                case 118: //scene outside
                    {
                        //output
                        outputLabel.Text = $"{player} heads outside to kill the witness to their crime.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 119://make sure icon is default, scene is outside Inn
                    {
                        //output
                        outputLabel.Text = $"{player} is outside of the Inn";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings reset
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;

                        //all the options
                        if (brokenLegs == 1)
                        {
                            optionOneButton.Text = "Scream in pain";
                            optionOneBlocked.Visible = false;
                            optionOneButton.Enabled = true;
                            character = 0; //1 is Jon, 2 is Shimshon
                            saidNo = 0;
                            brokenArms = 0;
                            shoesTied = 0;
                            antiSocial = 0;
                            knowsOfThief = 0;
                            hasCube = 0;
                            knowsOfCastle = 0;
                            knowsOfChurch = 0;
                            trustInnKeeper = 0;
                            bloodlust = 0;
                            caughtMurder = 0;

                        }
                        if (character == 1)
                        {
                            if (beenHere == 0)
                            {
                                optionTwoButton.Text = "Follow suspicious man down alleyway";
                                optionTwoBlocked.Visible = false;
                                optionTwoButton.Enabled = true;
                            }
                        }
                        if (knowsOfChurch == 1)
                        {
                            optionOneButton.Text = "Investigate the Church";
                            optionOneBlocked.Visible = false;
                            optionOneButton.Enabled = true;
                        }
                        if (knowsOfThief == 1)
                        {
                            optionOneButton.Text = "Stake out the thief";
                            optionOneBlocked.Visible = false;
                            optionOneButton.Enabled = true;
                        }
                        if (knowsOfCastle == 1)
                        {
                            optionOneButton.Text = "Travel to castle";
                            optionOneBlocked.Visible = false;
                            optionOneButton.Enabled = true;
                        }
                        if (trustInnKeeper == 1)
                        {
                            optionOneButton.Text = "Hang around Inn";
                            optionOneBlocked.Visible = false;
                            optionOneButton.Enabled = true;
                        }
                        if (bloodlust == 1)
                        {
                            optionOneButton.Text = "Hunt for blood";
                            optionOneBlocked.Visible = false;
                            optionOneButton.Enabled = true;
                        }
                        if (caughtMurder == 1)
                        {
                            optionThreeButton.Text = "Track the one who saw the murder";
                            optionThreeBlocked.Visible = false;
                            optionThreeButton.Enabled = true;
                        }
                        if (trustInnKeeper == 0)
                        {
                            if (character == 2)
                            {
                                optionTwoButton.Text = "Burn down the Inn";
                                optionTwoBlocked.Visible = false;
                                optionTwoButton.Enabled = true;
                            }
                        }
                        if (brokenLegs == 0)
                        {
                            optionFourButton.Text = "Leave the kingdom";
                            optionFourBlocked.Visible = false;
                            optionFourButton.Enabled = true;
                        }
                    }
                    break;

                case 120: ///new scene
                    {
                        //output
                        outputLabel.Text = $"{player} spots a suspicious, slender man turn around an alleyway.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 121:
                    {
                        //output
                        outputLabel.Text = $"{player} is 10 steps back from the suspicious target.";

                        //button settings
                        optionOneButton.Text = "Watch";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Confront";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;

                        //stop player from returning here
                        beenHere = 1;
                    }
                    break;

                case 122:
                    {
                        //output
                        outputLabel.Text = $"{player} watches the man bend over something just out of sight.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 123:
                    {
                        //output
                        outputLabel.Text = $"{player} thinks the man is looting a dead body off the street...";

                        //button settings
                        optionOneButton.Text = "Not my promblem";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Confront";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 124: ///display new scene closer to man
                    {
                        //output
                        outputLabel.Text = $"{player} confronts the man in the alleyway.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 125:
                    {
                        //output
                        outputLabel.Text = "A creature scampers off behind a trash bin during the confrontation.";

                        //button settings
                        optionOneButton.Text = "Find the creature";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Arrest the man";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 126: //scene puppy - TEMPORARY KNOWS OF CASTLE (this is where he can join the cult in the future)
                    {
                        //output
                        outputLabel.Text = $"{player} searches behind the trash bin and finds a small puppy.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;

                        ////add knows of castle (TEMPORARY)
                        //knowsOfCastle = 1;
                    }
                    break;

                case 127: //scene man, icon
                    {
                        //output
                        outputLabel.Text = "The thin man: Please don't hurt her, I was just out here making sure she had something to eat.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONhomelessMan;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 128: //scene alleyway
                    {
                        //output
                        outputLabel.Text = $"{player} feels embarrassed. They had assumed this man was out doing no good.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = $"{player} is so rude...";
                    }
                    break;

                case 129:
                    {
                        //output
                        outputLabel.Text = "The man does not resist.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 130: // scene puppy
                    {
                        //output
                        outputLabel.Text = "A small puppy jumps out from behind the trash can.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 131: //scene blackout
                    {
                        //output
                        outputLabel.Text = $"The puppy knocks {player} down to the ground. {player} blacks out.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 132: //scene outside church, icon default
                    {
                        //output
                        outputLabel.Text = $"{player} makes their way over to the Church.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;

                        //don't let them back
                        knowsOfChurch = 0;
                    }
                    break;

                case 133: //
                    {
                        //output
                        outputLabel.Text = $"The crashes echo throughout the entire Kingdom. It would have been impossible to locate the source of the noise without the Inn Keeper's help.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 134:
                    {
                        //output
                        outputLabel.Text = $"There are members of the Church stationed on the grounds. How will {player} get inside?";

                        //button settings
                        optionOneButton.Text = "Ask to go inside";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Climb in through a broken side panel";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 135:
                    {
                        //output
                        outputLabel.Text = $"{player} is not allowed inside of the Church.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 136: //scene black
                    {
                        //output
                        outputLabel.Text = $"The members of the Church grow suspicious of {player}. They take them into their custody.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 137: //scene inside church enterence
                    {
                        //output
                        outputLabel.Text = $"The members welcome {player} inside. From inside, {player} can hear the crashing of explosives from beneath them ";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Sneak towards noise";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Ask about noise";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 138: //male church icon
                    {
                        //output
                        outputLabel.Text = "Church Man: OH YEAH BABY!!! WE ARE BLOWING HOLES THROUGH THE EARTH!!!!";
                        iconBox.Image = ICONchurchMan;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;

                        //status update
                        knowsOfTunnels = 1;
                    }
                    break;

                case 139: //female church icon
                    {
                        //output
                        outputLabel.Text = "Church Woman: HEY DON'T SAY THAT, THEY ARE AN OUTSIDER.";
                        iconBox.Image = ICONchurchWoman;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 140: //icon church lead, scene church lead
                    {
                        //output
                        outputLabel.Text = "Church Lead: It is okay to tell this one. As long as our opinions on the ruling of this Kingdom align...";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONchurchLead;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        knowsOfCastle = 1;
                    }
                    break;

                case 141:
                    {
                        //output
                        outputLabel.Text = "Church Lead: Would you be willing to help us overthrow the Kingdom and release it from its unworthy rule?";

                        //button settings
                        optionOneButton.Text = "Sure, nothing better to do...";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Nah";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 142:
                    {
                        //output
                        outputLabel.Text = "Church Lead: WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL WONDERFUL....";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false; ;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 143:
                    {
                        //output
                        outputLabel.Text = "Church Lead: We welcome you here. We will need you.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 144: //female church icon, scene church enterance
                    {
                        //output
                        outputLabel.Text = "Church Woman: Forgive me for speaking out, but I fail no see how a random person off the streets will help us.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONchurchWoman;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 145: //chrch lead icon, church lead scene
                    {
                        //output
                        outputLabel.Text = "Church Lead: This one can make decisions, I can tell. It will be those decisions that decide who wins the up coming battle!!!!";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONchurchLead;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 146:
                    {
                        //output
                        outputLabel.Text = "Church Lead: Time for your most important decision! Will you:";

                        //button settings
                        optionOneButton.Text = "Charge headfirst into battle";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Sell your soul for power";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 147: //scene church lead crazed
                    {
                        //output
                        outputLabel.Text = "Church Lead: Not exactly the choice I wanted of you. NOT AT ALL, NOT AT ALL, NOT AT ALL, NO NO NO NONONON...";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 148: //scene church lead sad
                    {
                        //output
                        outputLabel.Text = "Church Lead: p - please make you-your way down to the basement.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";

                    }
                    break;

                case 149:
                    {
                        //output
                        outputLabel.Text = "Church Lead: you will find the tunnels... just follow everyone else i guess.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 150: //default icon, scene church hallways
                    {
                        //output
                        outputLabel.Text = $"{player} makes their way down the various hallways of the Church. They descend the stairs and join a group of armed Church members.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 151: //scene tunnles
                    {
                        //output
                        outputLabel.Text = $"It is time for everyone to move out. The tunnels lead to both outside of the Kingdom walls and to the Castle itself. The assault begins.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 152:
                    {
                        //output
                        outputLabel.Text = $"The tunnels seemingly change as {player} runs through them.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 153: //scene black
                    {
                        //output
                        outputLabel.Text = $"The walls seem to close in on {player}...";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 154: //
                    {
                        //output
                        outputLabel.Text = $"{player} makes it to a sharp incline in the tunnel. Members of the Church begin to climb upwards.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 155: //castle courtyard
                    {
                        //output
                        outputLabel.Text = $"{player} makes it to a sharp incline in the tunnel. Members of the Church begin to climb upwards.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 156:
                    {
                        //output
                        outputLabel.Text = $"{player} feels an ominous presence watching them from afar.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 157: //scene battle field courtyard
                    {
                        //output
                        outputLabel.Text = "The battlefield grows tense.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Get inside castle";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Fight";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 158: //scene castle door
                    {
                        //output
                        outputLabel.Text = $"{player} rushes for the entrance of the Castle, a large door which was rammed down by those who had invaded with them.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 159: //scene inside castle
                    {
                        //output
                        outputLabel.Text = "The inside of the Castle suddenly goes silent.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Call out for anyone";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Head up staircase";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 160: //scene up staircase
                    {
                        //output
                        outputLabel.Text = $"As {player} runs over to the staircase, they cannot shake the feeling that something is watching them.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 161:
                    {
                        //output
                        outputLabel.Text = "They trip on the first step. They try to get up...";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 162: //scene frozen hand
                    {
                        //output
                        outputLabel.Text = $"{player}'s hands have frozen to the floor of the Castle.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 163: //scene frozen down on one knee 
                    {
                        //output
                        outputLabel.Text = $"{player} freezes solid in the now snowing Castle.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 164: //player icon
                    {
                        //output
                        outputLabel.Text = $"{player}: HEY! WHERE DID EVERYONE GO?";
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false; ;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 165: ////default icon
                    {
                        //output
                        outputLabel.Text = $"No response.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 166:
                    {
                        //output
                        outputLabel.Text = $"{player}'s breath freezes in the air as they breathe. The entire Castle is silent.";

                        //button settings
                        optionOneButton.Text = "Head outsude";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Find something to warm up";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionThreeButton.Text = "Head up staircase";
                        optionThreeBlocked.Visible = false;
                        optionThreeButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 167: //scene endless garden
                    {
                        //output
                        outputLabel.Text = $"{player} steps outside and is met by an endless, empty garden. Besides the flowers, there is no other life except for them.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 168:
                    {
                        //output
                        outputLabel.Text = $"{player} does not feel alone, eyes watch from afar.";

                        //button settings
                        optionOneButton.Text = $"Search from whatever is looking at {player}";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Head back inside";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 169:
                    {
                        //output
                        outputLabel.Text = $"The Castle has vanished behind {player}.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 170:
                    {
                        //output
                        outputLabel.Text = $"{player} searches for whatever seems to be watching them.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 171: //scene flower beds garden
                    {
                        //output
                        outputLabel.Text = $"Everything feels hopeless, and a deep loneliness takes over {player}. There is nothing here but flowers.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 172:
                    {
                        //output
                        outputLabel.Text = $"{player} is alone. Trapped in a seemingly endless prison of flowers. Those watching eyes depart, disappointed. This is {player}'s punishment for their decisions.";

                        //button settings
                        optionOneButton.Text = "END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 173:
                    {
                        //output
                        outputLabel.Text = "There is nothing around any of the rooms.  No blankets, fires or clothes.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 174: //scene frozen solid
                    {
                        //output
                        outputLabel.Text = $"{player} freezes solid in the now snowing Castle.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 175: ///scene punching sword man (gif?)
                    {
                        //output
                        outputLabel.Text = $"{player} throws a punch at a man with a sword.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 176: //scene fillet
                    {
                        //output
                        outputLabel.Text = $"{player} is immediately filleted by the cold tip of the sword.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 177: //scene church lead crazed
                    {
                        //output
                        outputLabel.Text = "Church Lead: YES! EXCELLENT CHOICE!";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 178:
                    {
                        //output
                        outputLabel.Text = "Church Lead: A TRULY WONDERFUL, EXCEPTIONAL, DIVINE CHOICE!";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 179: //default icon, scene church entrance
                    {
                        //output
                        outputLabel.Text = $"{player} begins to feel dizzy. They begin to loose their footing and sway in the drafty wind of the entrance hallway.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 180: //icon church lead, scene church lead crazed
                    {
                        //output
                        outputLabel.Text = $"Church Lead: FOLLOW ME CHILD! THE PATH TO YOUR ENLIGHTENMENT LIES AHEAD!";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONchurchLead;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 181: //scene church stairs, default icon
                    {
                        //output
                        outputLabel.Text = $"{player} follows the Church Lead up multiple flights of stairs. At some point, they realize they are actually being carried by many members of the Church.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 182:
                    {
                        //output
                        outputLabel.Text = $"{player}'s vision becomes blurred. The walls circle around them as they ascend upwards towards the top level of the Church.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 183: //scene birds roof top church
                    {
                        //output
                        outputLabel.Text = $"You have lost all control over {player}. They can barely make out the silhouette of some dark clouds. White birds begin to gather around {player}.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 184: //church lead icon, make text fill screen
                    {
                        //output
                        outputLabel.Text = "Church Lead: ! ^&$&&*@^^^ &&^^@%^&@*)*()@ *@(@%^&@%&*@(*@(* *@&(@^^%@^&^@(*@*) *(&@%^&@^*(@*()@ *&@&%@^@^*(@*)(@& $^$%$#$% &^$@#$&^$*(DYD(#&D&#Y#*&#*(";
                        iconBox.Image = ICONchurchLead;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 185: //default icon, light hitting church
                    {
                        //output
                        outputLabel.Text = "The world shakes, but this time it isn't the explosives below the Church. The dark sky opens up. A single ray of light illuminates the Church.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 186: //scene Jon dead on pedistal white birds top down angle
                    {
                        //output
                        outputLabel.Text = $"The members of the Church gather around {player}. {player} lays on a stone pedestal, their body cold and dead.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 187: //scene birds melting
                    {
                        //output
                        outputLabel.Text = $"The birds begin to melt into {player}'s body.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 188: //icon church lead, scene church lead crazed
                    {
                        //output
                        outputLabel.Text = "Church Lead: IT IS PERFECT.ALL MY YEARS, MY LIFE, MY HEART, MY SOUL, MY LOVE, MY - MY - M...";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONchurchLead;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 189: ////scene birds melting, default icon
                    {
                        //output
                        outputLabel.Text = $"The Church Lead stutters like a mad lunatic at the sight of {player}'s disformed body.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 190: //scene growing puddle of birds
                    {
                        //output
                        outputLabel.Text = $"{player}'s body screams as the muscles, bones and skin contorts. Feathers coat the entire form, talons appear from the stubs where the feet once were.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 191: //scene dark glowig silhoutte
                    {
                        //output
                        outputLabel.Text = $"The crowd cheers from atop the Church as their deity awakens from {player}'s body.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 192: //scene Bird God, Wrangler of the Crazed
                    {
                        //output
                        outputLabel.Text = $"The God of the Clouds stands before them, ready to guide them into battle. {player}'s sacrifice will always be remembered.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 193: //leads to special ending
                    {
                        //output
                        outputLabel.Text = $"This is what must happen. There is no other meaning in {player}'s life. They would die a thousand times until they reach this conclusion.";

                        //button settings
                        optionOneButton.Text = "THE END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 194: //scene black, icon default
                    {
                        //output
                        outputLabel.Text = $"Obviously they are not going to let {player} leave after they leak so much private information...";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 195:
                    {
                        //output
                        outputLabel.Text = $"{player} has been taken into the Church's custody.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 196: //scene inside church hallway
                    {
                        //output
                        outputLabel.Text = $"{player} has gained access to the Church. If caught, the members will not tolerate their presence.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 197:
                    {
                        //output
                        outputLabel.Text = $"{player} can hear the crashing of explosives from beneath them ";

                        //button settings
                        optionOneButton.Text = "Sneak into basement";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Steal a disguise from someone";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 198: //scene black screen
                    {
                        //output
                        outputLabel.Text = $"{player} was caught immediately. They are not stealthy at all.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 199:
                    {
                        //output
                        outputLabel.Text = $"{player} spots a man at the end of a hallway. How do they steal the clothes?";

                        //button settings
                        optionOneButton.Text = "Knock him out";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Seduce him";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 200:
                    {
                        //output
                        outputLabel.Text = $"{player} successfully knocks the man out.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 201: //scene caught stealing clothes
                    {
                        //output
                        outputLabel.Text = $"As {player} removes the Church member's clothes, another member catches you in the act.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 202: //scene black
                    {
                        //output
                        outputLabel.Text = $"She is disgusted with {player}'s actions, and they are taken into the Church's custody.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 203: //scene in front of seduced man
                    {
                        //output
                        outputLabel.Text = $"{player} approaches the man and attempts to seduce him.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 204: //icon male church member
                    {
                        //output
                        outputLabel.Text = "Church Man: Sorry, I don't swing that way...";
                        iconBox.Image = ICONchurchMan;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 205:
                    {
                        //output
                        outputLabel.Text = "Church Man: HEY, WAIT! YOU SHOULDN'T BE HERE TO BEGIN WITH!";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 206: //icon default, scene black
                    {
                        //output
                        outputLabel.Text = "Ouch... rejected and taken into the Church's custody.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Just my way with people, they can't resist me";
                    }
                    break;

                case 207: //icon male church member
                    {
                        //output
                        outputLabel.Text = "Church Man: You must be a blessing from The One, given straight to me as a sign of my good faith.";
                        iconBox.Image = ICONchurchMan;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 208: //
                    {
                        //output
                        outputLabel.Text = "Church Man: I will happily join you in a private room where we won't be interrupted.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 209: //icon default, scene church man knocked out
                    {
                        //output
                        outputLabel.Text = $"Once alone with him, {player} knocks the man out and steals his clothes. They look just like a member of the Church now.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "Openly travel towards noise";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Sneak towards noise";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 210: //scene hallway basement stairs
                    {
                        //output
                        outputLabel.Text = $"{player} walks straight down to the basement. No one cares as they walk by.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 211: //scene tunnels
                    {
                        //output
                        outputLabel.Text = $"{player} is now in the basement where tunnels are being blown out of the Earth.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        knowsOfTunnels = 1;
                    }
                    break;

                case 212:
                    {
                        //output
                        outputLabel.Text = "The tunnels seem to go on forever in any direction.  They are well lit despite there being no visible light source.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        knowsOfCastle = 1;
                    }
                    break;

                case 213:
                    {
                        //output
                        outputLabel.Text = "There is a certain magic to these tunnels...";

                        //button settings
                        optionOneButton.Text = "Leave the Church";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Explore the tunnels";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 214: //
                    {
                        //output
                        outputLabel.Text = $"{player} exits the Church";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 215: //scene dark tunnel
                    {
                        //output
                        outputLabel.Text = $"{player} travels through the long, winding tunnel. The tunnel seems to darken with every step.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 216: //scene black
                    {
                        //output
                        outputLabel.Text = $"{player}'s footsteps echo through the tunnel. The walls seem to darken and close in on them.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 217: //
                    {
                        //output
                        outputLabel.Text = $"The walls seal {player} in. What once was a muddy tunnel is now a concrete cage.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 218: //scene player crouching in hall
                    {
                        //output
                        outputLabel.Text = $"{player} crouches down and sneaks towards the basement. They look stupid as they crouch and attract attention to themselves.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 219: //scene black
                    {
                        //output
                        outputLabel.Text = $"Maybe if {player} didn't look so stupid crouching down a hallway, they may have gotten to the noise.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 220: //scene inn outside
                    {
                        //output
                        outputLabel.Text = $"{player} has decided to stake-out the Inn in an attempt to bust the criminal.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 221: //scene inn outside night w/ moon
                    {
                        //output
                        outputLabel.Text = $"As the moon rises, {player} watches a man begin to scale the outside of the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Climb the building to chase him";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Go inside through the front door";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 222:
                    {
                        //output
                        outputLabel.Text = $"As {player} scales the building, their hand slips on a smooth sandy brick.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 223: //scene black
                    {
                        //output
                        outputLabel.Text = $"{player} falls from the Inn and slams their head off the concrete.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 224:
                    {
                        //output
                        outputLabel.Text = "The door is locked.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 225:
                    {
                        //output
                        outputLabel.Text = $"{player} hears the howling of hungry wolves.";

                        //button settings
                        optionOneButton.Text = "Pick the lock";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 226:
                    {
                        //output
                        outputLabel.Text = $"{player} is unable to pick lock due to their broken arm.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 227: //scene wolfs eating
                    {
                        //output
                        outputLabel.Text = $"A pack of wolves has caught up to {player}, and devour them alive.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 228: //scene inside inn night
                    {
                        //output
                        outputLabel.Text = $"{player} has successfully unlocked the door. They enter the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 229:
                    {
                        //output
                        outputLabel.Text = $"{player} hears the man rustling around upstairs.";

                        //button settings
                        optionOneButton.Text = "Head upstairs";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Find a weapon";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 230: //scene inn keepers desk night
                    {
                        //output
                        outputLabel.Text = $"{player} searches the Inn Keeper's reception desk for a weapon.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 231: //scene knife found
                    {
                        //output
                        outputLabel.Text = $"{player} arms themselves with a sharp knife, found in an old drawer.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        hasKnife = 1;
                    }
                    break;

                case 232:
                    {
                        //output
                        outputLabel.Text = $"{player} is ready to confront the thief.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 233: //scene inn staircase
                    {
                        //output
                        outputLabel.Text = $"{player} heads upstairs.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 234: //scene thief stealing
                    {
                        //output
                        outputLabel.Text = $"The thief, dressed in a sharp black suit, rummages through bins just steps away.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Rush him";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Threaten him";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 235:
                    {
                        //output
                        outputLabel.Text = $"{player} sprints towards the villain.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 236: //scene player soaring out window
                    {
                        //output
                        outputLabel.Text = $"{player} runs straight out a window.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 237: //scene skewered
                    {
                        //output
                        outputLabel.Text = "Skewered on a pole...";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 238: //scene stabbing thief
                    {
                        //output
                        outputLabel.Text = $"{player} stabs the man from behind until they die.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 239:
                    {
                        //output
                        outputLabel.Text = $"{player} killed a man for robbery. Nowadays this would be seen as horrible, but this is set in a medieval fantasy land.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 240: //scene spooning thief
                    {
                        //output
                        outputLabel.Text = $"{player} spoons the man until he dies.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 241: //scene bloody spoon
                    {
                        //output
                        outputLabel.Text = "The spoon is a grossly effective murder weapon.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 242: //
                    {
                        //output
                        outputLabel.Text = $"{player}: Hey buster... pal... little guy. Get out of here, or I'll hurt you.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 243: //icon thief
                    {
                        //output
                        outputLabel.Text = "Thief: Ah very scary, okay I will leave.";
                        iconBox.Image = ICONthief;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 244: //icon default, scene thief flee out door
                    {
                        //output
                        outputLabel.Text = $"The thief scampers away, promising to never return. This was easier to do than {player} thought it would be.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 245: //scene opening window
                    {
                        //output
                        outputLabel.Text = $"{player} gets tired and decides to sleep in one of the unlocked rooms.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "SLEEP WELL";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 246: //default icon
                    {
                        //output
                        outputLabel.Text = $"{player} suffers from severe stutters and fails to intimidate.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 247: //icon thief
                    {
                        //output
                        outputLabel.Text = "Thief: Nah I am staying, feel free to leave.";
                        iconBox.Image = ICONthief;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 248: //default icon, black scene
                    {
                        //output
                        outputLabel.Text = $"His words are so powerful and chadly that {player} gives up on everything in life. They will now buy a house and raise a family of cats, all because of this thief.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "GIVE UP";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 249: //scene spoon
                    {
                        //output
                        outputLabel.Text = $"{player} arms themselves with a spoon...  certainly that'll be effective.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        hasSpoon = 1;
                    }
                    break;

                case 250:
                    {
                        //output
                        outputLabel.Text = $"{player} is interested in meeting the Court Jester. They take a cart out to the Castle and pay the cart fee with what little money they have.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;

                        //status update
                        knowsOfCastle = 0;
                    }
                    break;

                case 251: //scene castle exterior
                    {
                        //output
                        outputLabel.Text = $"{player} is amazed by the marble walls and the scale of the Castle.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 252: //icon castle guard
                    {
                        //output
                        outputLabel.Text = "Castle Guard: Slow down pal. Not anyone can enter at a time like this...";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONcastleGuard;

                        //button settings
                        if (antiSocial == 1)
                        {
                            optionOneButton.Text = "";
                            optionOneBlocked.Visible = true;
                            optionOneButton.Enabled = false;
                            optionTwoButton.Text = "";
                            optionTwoBlocked.Visible = true;
                            optionTwoButton.Enabled = false;
                            optionThreeButton.Text = "";
                            optionThreeBlocked.Visible = true;
                            optionThreeButton.Enabled = false;
                            optionFourButton.Text = $"{player} is anti-social";
                            optionFourBlocked.Visible = false;
                            optionFourButton.Enabled = true;
                        }
                        else
                        {
                            optionOneButton.Text = "'I would like to meet the Court Jester.";
                            optionOneBlocked.Visible = false;
                            optionOneButton.Enabled = true;
                            optionTwoButton.Text = "(Lie) 'I am here to tend to the garden.'";
                            optionTwoBlocked.Visible = false;
                            optionTwoButton.Enabled = true;
                            if (knowsOfTunnels == 1)
                            {
                                optionThreeButton.Text = "'The Church is tunneling underground.'";
                                optionThreeBlocked.Visible = false;
                                optionThreeButton.Enabled = true;
                            }
                            optionFourButton.Text = "";
                            optionFourBlocked.Visible = true;
                            optionFourButton.Enabled = false;
                        }
                    }
                    break;

                case 253: //icon default
                    {
                        //output
                        outputLabel.Text = $"{player}, having the social capacity of a screwdriver, freezes up upon trying to figure out how to respond.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 254: //scene outside Inn
                    {
                        //output
                        outputLabel.Text = $"{player} flees back to the Inn. The Inn is at least slightly familiar in this unknown Kingdom.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 255: //icon castle gaurd
                    {
                        //output
                        outputLabel.Text = "Castle Guard: Sorry pal, we have no time to waste on outside affairs.";
                        iconBox.Image = ICONcastleGuard;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 256: //default icon, scene outside Inn
                    {
                        //output
                        outputLabel.Text = $"With nowhere else to go, {player} heads back to the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 257:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: Of course, Hero. Our Mistress, the Court Jester, has been waiting for you.";
                        iconBox.Image = ICONcastleGuard;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 258: //default icon
                    {
                        //output
                        outputLabel.Text = $"The guard showed {player} a strangely high level of respect, even bowing their head and addressing them as 'Hero' with no hesitation.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 259: //inside castle courtyard scene
                    {
                        //output
                        outputLabel.Text = $"{player} is motioned toward where the garden is, but they notice the Castle doors are wide open.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Go to garden";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Head inside Castle";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 1230: //scene garden
                    {
                        //output
                        outputLabel.Text = $"Eyes pierce the flesh of {player}. Those eyes follow them everywhere they go whilst in the courtyard.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1231: //
                    {
                        //output
                        outputLabel.Text = $"{player} is surrounded by red, blue, and purple flowers of all shapes and sizes.";

                        //button settings
                        optionOneButton.Text = "Stop to smell the flowers";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Trample the flowers";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 1232: //scene rose
                    {
                        //output
                        outputLabel.Text = $"The scent is hypnotizing. {player} had forgotten so much of their life before. They'll never be free to live safely with her omnipresent glare. Always waking in the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1233: // RESET THINGS HERE OR EARLIER
                    {
                        //output
                        outputLabel.Text = $"The silhouette of the Jester briefly flashes before {player}'s eyes. They forget everything.";

                        //button settings
                        optionOneButton.Text = "FORGOTTEN";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 1234: //scene crying flower
                    {
                        //output
                        outputLabel.Text = "The flowers shed their tears.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1235:
                    {
                        //output
                        outputLabel.Text = $"The air is cold. The tears of the swaying flowers still flow, but {player}'s breath freezes before it can escape their mouth.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1236: //scene bloody crying rose
                    {
                        //output
                        outputLabel.Text = $"{player} chokes on ice as they attempt to cough the bloody fragments out.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 1237: //scene inside castle, icon mysterious voice
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: I see you are both dishonest and untrustworthy. When I give my guidence out, I expect it to be followed.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1238: //default icon
                    {
                        //output
                        outputLabel.Text = $"A familiar feminine voice echoes into {player}'s ears. It speaks in a calm yet degrading tone.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1239: //scene castle doors
                    {
                        //output
                        outputLabel.Text = $"{player} stands on the steps before the grand white doors.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Step inside";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Head back to garden";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 1240: //inside castle scene, mys icon
                    {
                        //output
                        outputLabel.Text = "Mysterious voice: You exist for my benefit. I need you, my Hero...";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1241: //default icon
                    {
                        //output
                        outputLabel.Text = $"{player}'s foot sways through the entrance.  As it makes contact with the polished inside floor, {player} feels as if their head is slammed back by an unknown force.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1242: //scene player on one knee
                    {
                        //output
                        outputLabel.Text = $"The whiplash caused is enough to knock {player} to their knees.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1243:
                    {
                        //output
                        outputLabel.Text = $"All of the stationed guards do not react at the sight of {player} collapsing down onto their knees.  They remain as if frozen, like statues.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1244: //mys icon, freezing on knees as flowers grow upwards
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: I want you to go the Church next time. I would love you to bring forth their God.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1245: //default icon
                    {
                        //output
                        outputLabel.Text = $"Ice grows up {player}'s arms and legs as they begin to fade out of consciousness.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1246: //scene jester (basially just colours, nothing clear should be made out)  RESET THINGS
                    {
                        //output
                        outputLabel.Text = $"The face of the Woman briefly flashes before {player}'s eyes. They forget everything. It seems the world itself was rewritten...";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "FORGOTTEN";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 1247:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: Thanks for the information, but we are well aware of that situation.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1248:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: Our Mistress the Court Jester has been watching them closely.  She has ordered us to make no moves against them.";

                        //button settings
                        optionOneButton.Text = "'Why don't you attack'?";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "'Watching?'";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 1249:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: Two reasons. The biggest is public appearance. It doesn't look good when you attack a Church.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1250:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: And the second reason? They pose no threat to Her.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1251:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: 'Been fun chatting with you, but you best be leaving now.";

                        //button settings
                        optionFourButton.Text = "Return to Inn";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1252:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: She has a kind of omnipresent talent. I don't know how, but She can watch over us all.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1253:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: I asked Her about it myself one time, but I've sadly forgotten what She said to me...";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1254:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: 'Let's forget our memories together...'  That's what she told me...";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1255:
                    {
                        //output
                        outputLabel.Text = "Castle Guard: Been fun chatting with you, but you best be leaving now.";

                        //button settings
                        optionFourButton.Text = "Return to Inn";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1256: //scene flattened player, icon player
                    {
                        //output
                        outputLabel.Text = $"{player}: ^ ^&^RG &% AARRRR RRRRGGGGGGG * ^^R %% ";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1257: //icon default
                    {
                        //output
                        outputLabel.Text = $"Nobody cares that {player} is bleeding out.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 1258:
                    {
                        //output
                        outputLabel.Text = "Their loud screams go unnoticed, or maybe the people are just too busy to care.";

                        //button settings
                        optionOneButton.Text = "Scream again, but louder";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Roll towards help";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 1259: //scene scream face
                    {
                        //output
                        outputLabel.Text = $"{player} screams again, a shockingly disturbed scream of horror. Still, no one reacts.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 260: //scene dried out face
                    {
                        //output
                        outputLabel.Text = $"{player} exerted all their remaining energy screaming.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 261: //scene the immortal horse
                    {
                        //output
                        outputLabel.Text = $"{player} tries to roll towards help, but instead rolls directly into an immortal horse...";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 262: //scene zoomed out horse next to carnival
                    {
                        //output
                        outputLabel.Text = $"Or at least the man running the carnival claims it is immortal. Much unlike {player}, who is dead now.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 263:
                    {
                        //output
                        outputLabel.Text = $"{player} has decided to stay nearby the Inn, due to their strange trust towards the Inn Keeper.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 264: //scene inn ouside night
                    {
                        //output
                        outputLabel.Text = $"As the night falls, {player} watches a man begin to scale the outside of the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Tell him to stop";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Chase him";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 265: //scene man clibing building looking down in fear, icon player
                    {
                        //output
                        outputLabel.Text = $"{player}: SWOG FLOBBA!";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 266: //icon thief
                    {
                        //output
                        outputLabel.Text = "Thief: Oy! You are a foul smelling thing, aren't ya?";
                        iconBox.Image = ICONthief;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 267: //icon default, scene no more thief - same wall
                    {
                        //output
                        outputLabel.Text = "The man swings over a window sill, and into the second floor of the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 268:
                    {
                        //output
                        outputLabel.Text = $"The man shuts the window behind him. The next open window is on the third floor...";

                        //button settings
                        optionOneButton.Text = "Climb to third floor";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Scream";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 269: //player icon, scene outside inn night
                    {
                        //output
                        outputLabel.Text = $"{player}: @*&*&^kicw y lub^%%&&46 78(^@@@&@!!!";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 270: //default icon
                    {
                        //output
                        outputLabel.Text = $"The ear piercing scream is more than enough to catch the attention of everyone nearby, including everyone inside the Inn.";
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 271: //scene thief no pants running
                    {
                        //output
                        outputLabel.Text = "A loud thud can be heard from inside the Inn, followed by the thief scampering out the front door with no pants.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 272: //scene outside inn
                    {
                        //output
                        outputLabel.Text = $"{player} has successfully saved the Inn from the thief. They now rest in the Inn, satisfied with their adventure.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 273: //scene player jumping up window
                    {
                        //output
                        outputLabel.Text = $"{player} leaps up to the third floor with no effort. The silently enter the building due to their sneaky bunny slippers.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 274: //scene inside inn second third floor, bunny slippers
                    {
                        //output
                        outputLabel.Text = $"The man can be heard rummaging through containers from the floor beneath {player}...";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Sneak downstairs";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Leap out window";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 275: //scene black
                    {
                        //output
                        outputLabel.Text = "Wow, you really just chose that option. What do you think will happen?";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 276: //scene skewered in the night
                    {
                        //output
                        outputLabel.Text = $"'{player} flies out the window like a bird.'  NOPE! They fall to their death.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 277:
                    {
                        //output
                        outputLabel.Text = "You're sick. And not in a 'sick bro, totally wicked' kind of way. You're dastardly, too.";

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 278: //scene thief stealing
                    {
                        //output
                        outputLabel.Text = $"{player} sneaks down stairs. They stare at the villain whilst he steals out of cupboards.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 279:
                    {
                        //output
                        outputLabel.Text = "What is the plan of action?";

                        //button settings
                        optionOneButton.Text = "Scare the thief away";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Alert the Inn Keeper";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 280: //scene sneak up on thief
                    {
                        //output
                        outputLabel.Text = $"{player} creeps up behind the thief.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 281:
                    {
                        //output
                        outputLabel.Text = $"{player} proceeds to jump up in front of him and yell 'BOO!'";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 282: //scene black
                    {
                        //output
                        outputLabel.Text = $"{player} is immediately struck by a frying pan in retaliation. {player} lies unconscious until the next day when they wake up in bed.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "THE END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 283: //scene doors being knocked (maybe)
                    {
                        //output
                        outputLabel.Text = $"{player} begins running down the hallways, knocking on every door with a loud pound against the wood.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 284: //scene thief no pants flee
                    {
                        //output
                        outputLabel.Text = "This action is enough to wake everyone up. The Inn Keeper swiftly charges the thief out of the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 285: //scene black
                    {
                        //output
                        outputLabel.Text = $"{player} has successfully saved the Inn from the thief. They now rest, satisfied.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "THE END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 286: //scene running upwards
                    {
                        //output
                        outputLabel.Text = $"{player} begins to chase the thief, and runs upwards--perpendicular to the walls.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 287:
                    {
                        //output
                        outputLabel.Text = $"{player}'s terrifying power to defy gravity is enough to shock the thief into speeding up the climb.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 288: //scene splat
                    {
                        //output
                        outputLabel.Text = "The thief loses his footing and falls from off the wall.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 289: //scene black
                    {
                        //output
                        outputLabel.Text = $"{player} has successfully saved the Inn from the thief. They now rest, satisfied.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "THE END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 290:
                    {
                        //output
                        outputLabel.Text = $"{player} is hungry for blood...";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 291: //scene reflection window
                    {
                        //output
                        outputLabel.Text = $"{player} sees a tall, green looking person in pink bunny slippers through a window.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Sprint at it";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = $"...It stole {player}'s entire look";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 292: //shattered glass bleed out scene
                    {
                        //output
                        outputLabel.Text = $"{player} shatters through the reflective glass window. They scrape their face off the glass shards and die.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                    }
                    break;

                case 293:
                    {
                        //output
                        outputLabel.Text = $"{player} is peeved that the person looks just like them.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 294: //
                    {
                        //output
                        outputLabel.Text = $"{player} wants to kill... but....";

                        //button settings
                        optionOneButton.Text = "Sprint at it (KILL)";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "...It is kind of cute...";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 295: //scene window but with added hearts
                    {
                        //output
                        outputLabel.Text = $"The thing in the reflection of the window is exactly {player}'s type. Those long, gangly arms could probably give the most comforting hugs.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 296:
                    {
                        //output
                        outputLabel.Text = $"{player} wants to make a move on its new crush...";

                        //button settings
                        optionOneButton.Text = "SPRINT AT IT (KILL KILL KILL)";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Propose!";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 297: //scene propose to reflection
                    {
                        //output
                        outputLabel.Text = $"The thing in the reflection of the window proposes at the same time as {player}!";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 298: //scene heart
                    {
                        //output
                        outputLabel.Text = "The two of them were made for each other! They'll definitely live happily together.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "THE END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 299:
                    {
                        //output
                        outputLabel.Text = $"The person who witnessed {player}'s crime stands before them.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 1300: //mys voice icon, scene jester colour smear
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: I don't often leave the Castle, but I wanted to see my Hero wake in person. You are not them, though.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionOneButton.Text = "KILL";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "KILL";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionThreeButton.Text = "KILL";
                        optionThreeBlocked.Visible = false;
                        optionThreeButton.Enabled = true;
                        optionFourButton.Text = "KILL";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 300: //default icon, scene attempt decap
                    {
                        //output
                        outputLabel.Text = $"Display: {player} attempts to decapitate the target and use their skull as a soccer ball.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 301: //default icon, scene arm rip
                    {
                        //output
                        outputLabel.Text = $"{player} attempts to rip the target's arms off and use them to slam the target into the ground.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 302: //default icon, scene roundhouse
                    {
                        //output
                        outputLabel.Text = $"{player} roundhouse kicks the target with enough force to level a village.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 303: //default icon, scene stomach rip
                    {
                        //output
                        outputLabel.Text = $"{player} uses their boney hands in an attempt to rip open the target's stomach.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 304: //scene no damage
                    {
                        //output
                        outputLabel.Text = $"{player} fails to leave any damage to the target.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 305: //
                    {
                        //output
                        outputLabel.Text = $"The Woman stands indifferent to {player}'s attempts to kill, and continues to speak calmly.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 306: //icon mys voice
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: I truly did not expect to see something like you.";
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionOneButton.Text = "kill";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "give up";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 307: //icon default, scene attacking
                    {
                        //output
                        outputLabel.Text = $"{player} desperately claws at the impervious flesh of the target.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 308: //
                    {
                        //output
                        outputLabel.Text = "The target calmly speaks:";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 309: //icon mys voice
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: You didn't happen to see my Hero in there, did you? There is someone who must join the Church for me.";
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionOneButton.Text = "co-operate";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "give up";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 310: //icon player, scene standing 
                    {
                        //output
                        outputLabel.Text = $"{player}: Globey Slog bLu. Ai floop.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 311: //icon mys
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: I see... not here then.";
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 312: //scene white, icon default
                    {
                        //output
                        outputLabel.Text = $"The world goes silent. The birds freeze in the air, the trees no longer breathe in the wind, and the sun's light blots out the darkness.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 313:
                    {
                        //output
                        outputLabel.Text = "No one, not even the Jester Herself, will remember what She did here. But it was necessary if She wants to kill the God of the Clouds.";

                        //button settings
                        optionOneButton.Text = "FORGOTTEN";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 314: //icon default, scene give up
                    {
                        //output
                        outputLabel.Text = $"{player}'s mind has been broken by facing something that it could not over come.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 315: //scene black
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: Please do not suffer, I will allow you to forget this tragedy. When you wake up, you'll forget what happened here...";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONmysteriousVoice;

                        //button settings
                        optionOneButton.Text = "FORGOTTEN";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 316: //default icon, scene outside inn
                    {
                        //output
                        outputLabel.Text = $"{player} wants to burn down the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 317:
                    {
                        //output
                        outputLabel.Text = "They do not have a lighter, or any other fire starter.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 318: //scene man walking
                    {
                        //output
                        outputLabel.Text = "A man walks by. Maybe he has a lighter on him...";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Pick pocket";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Kill the man";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 319: //scene steal from pocket
                    {
                        //output
                        outputLabel.Text = $"{player} attempts to take the lighter from the man's pocket.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 320: //scene lighter
                    {
                        //output
                        outputLabel.Text = $"{player} is successful.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Light the Inn on fire";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = $"Light {player} on fire";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 321: //scene flaming Inn
                    {
                        //output
                        outputLabel.Text = $"{player} enters the Inn and proceeds to light it on fire.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 322: //scene flaming Inn fireworks
                    {
                        //output
                        outputLabel.Text = $"{player} burns alive inside the building.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 323: //scene flaming shimshon
                    {
                        //output
                        outputLabel.Text = "Fire hot, fire burns.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 324: //scene kingdom on fire
                    {
                        //output
                        outputLabel.Text = $"{player} gallops through the Kingdom, while on fire. The whole kingdom is lit up as they burn.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 325:
                    {
                        //output
                        outputLabel.Text = $"{player} attempts to take the lighter from the man's pocket.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 326:
                    {
                        //output
                        outputLabel.Text = $"{player}'s broken arm dangles into the mans leg as {player} attempts to take the lighter.";

                        //button settings
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 327: //scene futuristic man pointing gun towards character (possibly framed at viewer)
                    {
                        //output
                        outputLabel.Text = $"The man feels {player}'s arm brush against them. The man instantly pulls out a gun and shoots {player}.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 328: //scene default black
                    {
                        //output
                        outputLabel.Text = "Maybe don't steal from a time traveler next time.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 329:
                    {
                        //output
                        outputLabel.Text = $"{player} attempts to rob the man, but their bloodlust quickly takes over.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 330: //lighter scene
                    {
                        //output
                        outputLabel.Text = $"{player} looms over the man. From behind, {player} can see a lighter in the man's pocket.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 331: //scene throwing man through window
                    {
                        //output
                        outputLabel.Text = $"{player} grabs the man by the legs and windmill pitches him into the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 332: //scene flaming Inn
                    {
                        //output
                        outputLabel.Text = "The Inn catches fire.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 333: //scene flaming Inn with firworks
                    {
                        //output
                        outputLabel.Text = $"{player}'s leg hairs are singed by the fire. They die from the pain.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 334: //default icon, kingdom gate scene
                    {
                        //output
                        outputLabel.Text = $"{player} has spotted a large Kingdom gate nearby the Inn.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 335:
                    {
                        //output
                        outputLabel.Text = $"{player} wants to leave the kingdom.";

                        //button settings

                        optionFourButton.Text = "Next";
                    }
                    break;

                case 336: //scene kingdom gate with guard, icon gate guard
                    {
                        //output
                        outputLabel.Text = $"Border Guard: Sorry, no one in, no one out. That is Her orders.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONcastleGuard;

                        //button settings
                        optionOneButton.Text = "Ask politely to leave";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Be aggressive";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 337: //scene leap at walls guard, icon default
                    {
                        //output
                        outputLabel.Text = $"{player} leaps at the guard, grabbing at the guard's arms.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 338: //scene gauntlets covered in blood
                    {
                        //output
                        outputLabel.Text = $"{player} removes the iron-plated gauntlets of the guard and rams them into his thick neck.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 339: //player silhoutte leaving kingdom, over hill
                    {
                        //output
                        outputLabel.Text = $"{player} leaves the Kingdom, off to live happily ever after.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "THE END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 340: //player icon
                    {
                        //output
                        outputLabel.Text = $"{player}: Uuug.Mep.er ah... Mep...";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONcharacter;


                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 341: //icon wall guard
                    {
                        //output
                        outputLabel.Text = "Border Guard: Ummm....Hey look. If you got an important package to deliver, some of us have been letting couriers through.";
                        iconBox.Image = ICONcastleGuard;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 342:
                    {
                        //output
                        outputLabel.Text = "Border Guard: But you are not a courier. Sorry friend, wish I could help you out.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 343: //NOTHING HERE
                    {
                        //output
                        outputLabel.Text = "";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 344: //NOTHING HERE
                    {
                        //output
                        outputLabel.Text = "";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 345: //scene wall no guard, icon default
                    {
                        //output
                        outputLabel.Text = $"{player} is unable to leave through lawful means.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "Climb the wall";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Punch a hole in the wall";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 346: //player flat on ground scene
                    {
                        //output
                        outputLabel.Text = $"{player} falls immediately, doesn't even get an inch up the wall.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 347: //scene black default
                    {
                        //output
                        outputLabel.Text = $"{player} has died from head trauma.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 348: //scene "the THE", icon THE
                    {
                        //output
                        outputLabel.Text = "The THE (inside joke, you wouldn't get it)";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "THE";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 349: //black scene, default icon
                    {
                        //output
                        outputLabel.Text = $"{player} has died from their broken fist.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "THE THE (DEAD)";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 350: //scene cube
                    {
                        //output
                        outputLabel.Text = "Border Guard: I see you have that weird cube. Those things are dangerous, I'll let you take it out with you.";
                        iconBox.Image = ICONcastleGuard;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 351: //scene leaving kingdom, default icon
                    {
                        //output
                        outputLabel.Text = $"{player} is allowed to leave the Kingdom because the guard thinks they are delivering a package elsewhere.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 352:
                    {
                        //output
                        outputLabel.Text = $"{player} leaves the Kingdom. Dissatisfied eyes watch, plotting {player}'s next demise.";

                        //button settings
                        optionOneButton.Text = "THE END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 353:
                    {
                        //output
                        outputLabel.Text = $"{player} leaves the Kingdom, off to live happily ever after.";

                        //button settings
                        optionOneButton.Text = "THE END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 354: //jon player icon
                    {
                        //output
                        outputLabel.Text = $"{player}: Can I get an exception, I don't actually know how I got here.";
                        iconBox.Image = ICONcharacter;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 355: //guard icon
                    {
                        //output
                        outputLabel.Text = "Border Guard: Yeah sure, why not. We've been letting merchants and the such though anyways.";
                        iconBox.Image = ICONcastleGuard;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 356: //default icon, scene leaving kingdom
                    {
                        //output
                        outputLabel.Text = $"{player} leaves the Kingdom. Dissatisfied eyes watch, plotting {player}'s next demise.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "THE END";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 357: //default icon, menacing fist shake
                    {
                        //output
                        outputLabel.Text = $"{player} shakes their fist at the guard menacingly.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 358: //player skewered by sword scene
                    {
                        //output
                        outputLabel.Text = $"The guard has none of that, he skewers {player} immediately.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 359: //black default scene
                    {
                        //output
                        outputLabel.Text = $"{player} bleeds out.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 363: //scene looking through cage at dirty grassy overgrown hallway, default icon
                    {
                        //output
                        outputLabel.Text = $"{player} wakes up in a small room. A metal gate stands between them and a bright corridor.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONdefaultIcon;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 364:
                    {
                        //output
                        outputLabel.Text = "The cold gate is locked.";

                        //button settings
                        optionOneButton.Text = "Stay inside";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Pick lock";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 365: //default scene
                    {
                        //output
                        outputLabel.Text = $"{player} chooses to rot in the cage.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                    }
                    break;

                case 366: //scene white or maybe a grassy hallway exit
                    {
                        //output
                        outputLabel.Text = $"{player} is free to leave the Church.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 367:
                    {
                        //output
                        outputLabel.Text = $"{player} is unable to pick locks, and is trapped in the cell.";

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                    }
                    break;

                case 368: //default icon, opening dating scene
                    {
                        //transition
                        mainUiBox.Visible = false;
                        startAnimBox.Visible = true;
                        startAnimBox.Image = Properties.Resources.Date_Sim_Trans_Anim;
                        Refresh();

                        Thread.Sleep(animTiming);
                        Refresh();
                        Refresh();

                        mainUiBox.Image = Properties.Resources.dateSimUI;
                        mainUiBox.Visible = true;
                        startAnimBox.Visible = false;

                        //output
                        outputLabel.Text = $"{player} wakes up in a small room. The concrete walls are ice cold to the touch.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONDateSimNoDio;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionThreeButton.Text = "";
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;

                        //status update
                        insideDateSim = 1;
                    }
                    break;

                case 1368: //scene crying face
                    {
                        //output
                        outputLabel.Text = $"With every passing day your love moves onwards. But not you. You'll never quit.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 369: //scene hallway empty
                    {
                        //output
                        outputLabel.Text = "The most beautiful voice calls your name from the dark of a hallway.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Go towards it";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Call out its name";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 370:
                    {
                        //output
                        outputLabel.Text = $"{player} makes their way through the hallway.";

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 371: //hallway light hitting black void
                    {
                        //output
                        outputLabel.Text = "Light peers through a crack in the walls. It shines down on the figure.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Reach out your hand";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Admit your love";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 372: //scene empty hallway
                    {
                        //output
                        outputLabel.Text = "You'll never reach your love. It is impossible.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 373:
                    {
                        //output
                        outputLabel.Text = $"{player} cries their heart out.";
                        mainMenuBox.Image = Properties.Resources.HeartDrop;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 374: //scene smiling void
                    {
                        //output
                        outputLabel.Text = $"It feels the same way about you.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 375:
                    {
                        //output
                        outputLabel.Text = "The smell of roses begins to overtake the room. You are absorbed into its beautiful black pupils.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 376:
                    {
                        //output
                        outputLabel.Text = "You've always loved those eyes...";

                        //button settings
                        optionOneButton.Text = "Ask it out on a date";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Apologize";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 377: //jon player icon
                    {
                        //output
                        outputLabel.Text = "_______: We should go somewhere... maybe we can: ";
                        iconBox.Image = ICONYou;

                        //button settings
                        optionOneButton.Text = "walk around the lakeside together";
                        optionTwoButton.Text = "go to the theatre";
                    }
                    break;

                case 378: //scene smiling crying void, default icon
                    {
                        //output
                        outputLabel.Text = "It is ecstatic! It wanted to go walk around with you for as long as it can remember!";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONDateSimNoDio;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 379: //scene default black
                    {
                        //output
                        outputLabel.Text = "It cannot go with you. Maybe it never really loved you....";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 380:
                    {
                        //output
                        outputLabel.Text = $"{player} has never been so hurt.";
                        mainMenuBox.Image = Properties.Resources.HeartDrop;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 381: //scene smiling crying void, default icon
                    {
                        //output
                        outputLabel.Text = "It is ecstatic! It wanted to go to the theatre with you for as long as it can remember!";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONDateSimNoDio;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 382: //scene black
                    {
                        //output
                        outputLabel.Text = "It cannot go with you. You'll never know its favourite play.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 383:
                    {
                        //output
                        outputLabel.Text = $"{player} has died of heartbreak.";
                        mainMenuBox.Image = Properties.Resources.HeartDrop;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 384: //jon icon, black scene
                    {
                        //output
                        outputLabel.Text = "_______: I cannot do enough for you.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONYou;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 385: //default icon, smiling void scene
                    {
                        //output
                        outputLabel.Text = "It loves you all the same, despite your inadequacies.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONDateSimNoDio;

                        //button settings
                        optionOneButton.Text = "Ask why it loves you";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Tell it how much it means to you";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 386: //scene neutral void
                    {
                        //output
                        outputLabel.Text = "You will never get that answer.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 387: //scene black default
                    {
                        //output
                        outputLabel.Text = "You'll always fear that it fell out of love with you.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 388:
                    {
                        //output
                        outputLabel.Text = $"{player} has died of overthinking.";
                        mainMenuBox.Image = Properties.Resources.HeartDrop;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 389: //jon icon
                    {
                        //output
                        outputLabel.Text = "--- ---- -- ---- -- --";
                        iconBox.Image = ICONYou;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 390: //scene bigger void smile, default icon
                    {
                        //output
                        outputLabel.Text = "It gives you a smile.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONDateSimNoDio;

                        //button settings
                        optionOneButton.Text = "'I love you'";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Kiss it";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 391: //It icon
                    {
                        //output
                        outputLabel.Text = "_______: I love you too!";
                        iconBox.Image = ICONIt;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 392: //default icon
                    {
                        //output
                        outputLabel.Text = $"You feel incredibly warm. This is the happiest {player} has ever been.";
                        iconBox.Image = ICONDateSimNoDio;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 393:
                    {
                        //output
                        outputLabel.Text = "You shake in fear.";

                        //button settings
                        optionOneButton.Text = "Offer everything to it";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Kiss it";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 394: //scene frowning void
                    {
                        //output
                        outputLabel.Text = "You give away everything. Your life is no longer yours. You'd sell your very soul if you knew where to find it";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 395: //scene crying frowning void
                    {
                        //output
                        outputLabel.Text = "You cry.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Hold its hand";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Kiss it";
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 396: //scene black default
                    {
                        //output
                        outputLabel.Text = "The tears never end. The feelings never fade.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 397:
                    {
                        //output
                        outputLabel.Text = "You gave away all you are, all you can offer. And yet, you got no closer to reaching your love.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 398:
                    {
                        //output
                        outputLabel.Text = $"{player} is left heartbroken. There is no way to reach your dreams.";
                        mainMenuBox.Image = Properties.Resources.HeartDrop;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 399: //scene black
                    {
                        //output
                        outputLabel.Text = "You cannot reach it. Every time you get close, it becomes impossibly far away.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 400:
                    {
                        //output
                        outputLabel.Text = "You are berated with apologies. In the end, you are too passive to fight against its will.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 401:
                    {
                        //output
                        outputLabel.Text = $"{player} wishes everything was just slightly different.";
                        mainMenuBox.Image = Properties.Resources.HeartDrop;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 402: //scene frowning void crying
                    {
                        //output
                        outputLabel.Text = "Every action you take to get closer to it is working against you.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 403: //scene black
                    {
                        //output
                        outputLabel.Text = "You cannot reach it. You never will. Your love isn't wrong, but it isn't seen as right.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 404:
                    {
                        //output
                        outputLabel.Text = "These things—feelings—just happen sometimes.";
                        mainMenuBox.Image = Properties.Resources.HeartDrop;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 405: //jon player icon, scene black
                    {
                        //output
                        outputLabel.Text = "_______";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = ICONYou;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 406: //default icon
                    {
                        //output
                        outputLabel.Text = "Your voice is not heard. Your love is left unexpressed.";
                        iconBox.Image = ICONDateSimNoDio;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 407:
                    {
                        //output
                        outputLabel.Text = $"{player} has died of heartbreak.";
                        mainMenuBox.Image = Properties.Resources.HeartDrop;

                        //button settings
                        optionOneButton.Text = "DEAD";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionFourButton.Text = "";
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
                    }
                    break;

                case 409: //scene fast run boards
                    {
                        //output
                        outputLabel.Text = $"{player} sprints towards the window at full velocity, ripping floor boards up off the ground with their incredible speed.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 410: //scene mid air
                    {
                        //output
                        outputLabel.Text = $"Without thinking, {player} jumps out of the window. They fall three stories before landing onto a soft haystack.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 411: ///scene standing casually
                    {
                        //output
                        outputLabel.Text = $"{player} is uninjured.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 412: ///scene ripping boards up
                    {
                        //output
                        outputLabel.Text = $"{player} sprints towards the window at full velocity, ripping floor boards up off the ground with their incredible speed.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "";
                        optionOneBlocked.Visible = true;
                        optionOneButton.Enabled = false;
                        optionTwoButton.Text = "";
                        optionTwoBlocked.Visible = true;
                        optionTwoButton.Enabled = false;
                        optionFourButton.Text = "Next";
                        optionFourBlocked.Visible = false;
                        optionFourButton.Enabled = true;
                    }
                    break;

                case 413: ///scene faceplant
                    {
                        //output
                        outputLabel.Text = $"Without thinking, {player} jumps out of the window. They fall three stories before faceplanting into the concrete.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 414: ///scene broken legs
                    {
                        //output
                        outputLabel.Text = $"{player} is injured, and will no longer be able to move.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        brokenLegs = 1;
                    }
                    break;

                case 415: //
                    {
                        //output
                        outputLabel.Text = $"{player} should not jump from windows.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                //case 998: //WIN (proper ending) Too lazy to code for right now
                //    {
                //        //output
                //        outputLabel.Text = "";
                //        mainMenuBox.Image = Properties.Resources.scene;
                //        iconBox.Image = Properties.Resources.speechIcons;

                //        //button settings
                //        optionOneButton.Text = "";
                //        optionOneBlocked.Visible = true;
                //        optionOneButton.Enabled = false;
                //        optionTwoButton.Text = "";
                //        optionTwoBlocked.Visible = true;
                //        optionTwoButton.Enabled = false;
                //        optionThreeButton.Text = "";
                //        optionThreeBlocked.Visible = true;
                //        optionThreeButton.Enabled = false;
                //        optionFourButton.Text = "";
                //        optionFourBlocked.Visible = true;
                //        optionFourButton.Enabled = false;
                //    }
                //    break;

                case 999: //DEAD 
                    {
                        //hide things
                        iconBox.Visible = false;
                        optionOneBlocked.Visible = false;
                        optionTwoBlocked.Visible = false;
                        optionThreeBlocked.Visible = true;
                        optionFourBlocked.Visible = true;

                        //animation
                        deathAnimBox.Visible = true;
                        Refresh();
                        {
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            mainMenuBox.Image = Properties.Resources.scene;
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                            Thread.Sleep(animTiming);
                            Refresh();
                        }
                        endScreenBox.Visible = true;
                        Refresh();
                        deathAnimBox.Visible = false;

                        //reset game
                        character = 0; //1 is Jon, 2 is Shimshon
                        saidNo = 0;
                        brokenArms = 0;
                        shoesTied = 0;
                        antiSocial = 0;
                        brokenLegs = 0;
                        knowsOfThief = 0;
                        hasCube = 0;
                        knowsOfCastle = 0;
                        knowsOfChurch = 0;
                        trustInnKeeper = 0;
                        bloodlust = 0;
                        caughtMurder = 0;
                        beenHere = 0;
                        knowsOfTunnels = 0;
                        hasKnife = 0;
                        hasSpoon = 0;
                        insideDateSim = 0;
                        mainUiBox.Image = Properties.Resources.Ui;
                        iconBox.Image = ICONdefaultIcon;


                        //buttons
                        playAgainButton.Visible = true;
                        endGameButton.Visible = true;
                    }
                    break;

                case 1000: //Goodbye page
                    {
                        //output off
                        outputLabel.Visible = false;
                        iconBox.Visible = false;

                        //buttons off
                        optionOneBlocked.Visible = false;
                        optionOneButton.Visible = false;
                        optionTwoBlocked.Visible = false;
                        optionTwoButton.Visible = false;
                        optionThreeBlocked.Visible = false;
                        optionThreeButton.Visible = false;
                        optionFourBlocked.Visible = false;
                        optionFourButton.Visible = false;
                        playStartButton.Visible = false;
                        closeStartButon.Visible = false;
                        playAgainButton.Visible = false;
                        endGameButton.Visible = false;
                        endScreenBox.Visible = false;


                        //goodbye message
                        mainUiBox.Visible = true;
                        goodbyeMessageBack.Visible = true;
                        goodbyeMessageText.Visible = true;
                        Refresh();
                        Thread.Sleep(3000);
                        this.Close();
                    }
                    break;


                default:
                    break;

            }
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            page = 2;

            //hide page
            playAgainButton.Visible = false;
            endGameButton.Visible = false;
            endScreenBox.Visible = false;
            mainUiBox.Visible = false;
            mainMenuBox.Image = null;
            mainMenuBox.BackgroundImage = Properties.Resources.endPage;

            fullReset();
            DisplayPage();
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            page = 1000;
            DisplayPage();
        }

        public void fullReset()
        {
            //variables
            character = 0;
            saidNo = 0;
            brokenArms = 0;
            shoesTied = 0;
            antiSocial = 0;
            brokenLegs = 0;
            knowsOfThief = 0;
            hasCube = 0;
            knowsOfCastle = 0;
            knowsOfChurch = 0;
            trustInnKeeper = 0;
            bloodlust = 0;
            caughtMurder = 0;
            beenHere = 0;
            knowsOfTunnels = 0;
            hasKnife = 0;
            hasSpoon = 0;
            insideDateSim = 0;

            string player = "name";

            //display fixes if dating sim
            startAnimBox.Image = Properties.Resources.Start_Anim;
            mainUiBox.Image = Properties.Resources.Ui;

            //clear any button text
            optionOneButton.Text = "";
            optionTwoButton.Text = "";
            optionThreeButton.Text = "";
            optionFourButton.Text = "";
            optionOneBlocked.Visible = false;
            optionTwoBlocked.Visible = false;
            optionThreeBlocked.Visible = false;
            optionFourBlocked.Visible = false;
            outputLabel.Text = "";
        }

        public void forgetReset()
        {
            //variables
            saidNo = 0;
            brokenArms = 0;
            shoesTied = 0;
            antiSocial = 0;
            brokenLegs = 0;
            knowsOfThief = 0;
            hasCube = 0;
            knowsOfCastle = 0;
            knowsOfChurch = 0;
            trustInnKeeper = 0;
            bloodlust = 0;
            caughtMurder = 0;
            beenHere = 0;
            knowsOfTunnels = 0;
            hasKnife = 0;
            hasSpoon = 0;
            insideDateSim = 0;

            //display fixes if dating sim
            startAnimBox.Image = Properties.Resources.Start_Anim;
            mainUiBox.Image = Properties.Resources.Ui;

            //clear any button text
            optionOneButton.Text = "";
            optionTwoButton.Text = "";
            optionThreeButton.Text = "";
            optionFourButton.Text = "";
            optionOneBlocked.Visible = false;
            optionTwoBlocked.Visible = false;
            optionThreeBlocked.Visible = false;
            optionFourBlocked.Visible = false;
            outputLabel.Text = "";

        }
    }
}
