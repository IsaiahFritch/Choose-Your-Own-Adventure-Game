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

namespace Choose_Your_Own_Adventure_Game
{
    public partial class AdventureGame : Form
    {
        //global variables
        int page = 1;
        int animTiming = 5;
        Random ranGen = new Random();
        int chance = 1;

        string player = "name";

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

        public AdventureGame()
        {
            InitializeComponent();
            //formatting and correctly loading
            //main menu    (add scenes to the image property of mainMenuBox to display them)
            playStartButton.Parent = mainMenuBox;
            playStartButton.Location = new Point(260, 444);
            closeStartButon.Parent = mainMenuBox;
            closeStartButon.Location = new Point(260, 736);

            //Main UI
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

            //date sim transition

            //death animation

            //win animation

            //end screen
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
            else if (page == 41)
            {
                page = 42;
            }
            else if (page == 48)
            {
                page = 49;
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
            else if (page == 85)
            {
                page = 103;
            }
            else if (page == 112)
            {
                page = 113;
            }
            else if (page == 121)
            {
                page = 122;
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
            else if (page == 141)
            {
                page = 142;
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
            else if (page == 32)
            {
                page = 11;
            }
            else if (page == 28)
            {
                page = 55;
            }
            else if (page == 48)
            {
                page = 55;
            }
            else if (page == 60)
            {
                page = 61;
            }
            else if (page == 2)
            {
                page = 59;
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
            else if (page == 77)
            {
                page = 106;
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
            else if (page == 103)
            {
                page = 104;
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
            else if (page == 103)
            {
                page = 104;
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


            //perform the actions on that page
            DisplayPage();
        }

        public void DisplayPage()
        {

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
                            }

                            //Ui established
                            mainUiBox.Visible = true;
                            mainMenuBox.Image = Properties.Resources.scene;

                            //icon animation
                            iconFadeInBox.Visible = true;
                            Refresh();
                            {
                                Thread.Sleep(animTiming);
                                Refresh();
                                Thread.Sleep(animTiming);
                                Refresh();
                            }
                            iconBox.Visible = true;
                            Refresh();
                            startAnimBox.Visible = false;
                            iconFadeInBox.Visible = false;
                            Refresh();
                        }

                        //output
                        outputLabel.Text = "Will you play as Jon or Shimshon?";
                        ////mainMenuBoxImage = Properties.Resources.IMAGE

                        //button settings
                        optionOneButton.Text = "Jon";
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Shimshon";
                        optionTwoButton.Enabled = true;
                        optionThreeBlocked.Visible = true;
                        optionThreeButton.Enabled = false;
                        optionFourBlocked.Visible = true;
                        optionFourButton.Enabled = false;
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
                        player = "Jon";

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
                        if(player == "")
                        {
                            player = "Jon";
                        }
                        playerNameText.Visible = false;
                        playerNameText.Enabled = false;
                        playerNameTextTip.Visible = false;
                        playerNameTextJon.Visible = false;

                        //output
                        outputLabel.Text = "Mysterious Voice: Is anyone awake?";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;
                        ////reset everything except for name and character

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
                        outputLabel.Text = "No sir";
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

                case 6: ///icon
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: Obviously if you can respond you are awake.";
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        saidNo = 1;
                    }
                    break;

                case 7: ///icon
                    {
                        //output
                        outputLabel.Text = "Player: Of course, who could sleep through that noise?";
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

                case 8: ///icon
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: I'm just making sure you're alright.";
                        iconBox.Image = Properties.Resources.speechIcons;

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
                        outputLabel.Text = $"Display: The world rattles as the echoes of bombs ring in {player}'s ears.";
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 11: ///scene window
                    {
                        //output
                        outputLabel.Text = $"Display: {player} believes they are in a room of some kind.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 12: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} sees what appears to be light from a window to their left.";

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
                        outputLabel.Text = $"Display: It was easy to find the door, it was right behind {player}.  It took a moment of stumbling around in the dark, but they found it.";

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
                        outputLabel.Text = "Display: The door is locked, but {player} could pick it.";

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
                        outputLabel.Text = $"Display: The door stood no chance against the might of {player}, despite their weak fragile body.";
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
                        outputLabel.Text = "Display: Congratulations! {player} broke their arm and gained access to the hallways.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 17: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} will no longer be able to lockpick.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        brokenArms = 1;
                    }
                    break;

                case 18: 
                    {
                        //output
                        outputLabel.Text = $"Display: The lock stood no chance against the wit of {player} !";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 19: 
                    {
                        //output
                        outputLabel.Text = "Display: The door swings open, revealing the water-stained blue hallway.";

                        //button settings
                        optionFourButton.Text = "Next";

                    }
                    break;

                case 20: 
                    {
                        //output
                        outputLabel.Text = "Display: {player} is met by a staircase at the end of the hallway, which weaves through a long and bendy corridor.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 21: ///scene shoes
                    {
                        //output
                        outputLabel.Text = $"Display: {player}'s shoe's are untied. Do they tie them?";
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
                        outputLabel.Text = $"Display: As {player} makes their way through the dewy hallway, the crashing of explosives continues nearby.";
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
                        outputLabel.Text = "Display: {player} slowly descends down a squeaking stair case, and makes their way to what appears to be a reception desk.";
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
                        outputLabel.Text = $"Display: As {player} makes their way through the dewy hallway, the crashing of explosives continues nearby.";
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
                        outputLabel.Text = $"Display: {player} slowly descends down a squeaking stair case--being careful not to step on their laces--and makes their way to what appears to be a reception desk.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 26: 
                    {
                        //output
                        outputLabel.Text = $"Display: An older man with a well kept bushy beard waits for {player} at the front of the desk. In his hair is a small pink pin. The walls behind him are covered in menus and the artistic scribbles of his daughter.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 27: 
                    {
                        //output
                        outputLabel.Text = $"Display: As he stands there, he waves {player} over to him. He appears friendly, so they approach him.";

                        //button settings
                        optionFourButton.Text = "Next";

                    }
                    break;

                case 28: /// icon keeper, scene closer to desk
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: Bumpy start to the day! Good morning to you, my friend. Can I help you with anything?";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;

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
                        outputLabel.Text = $"Display: {player} is leaving for the door, but is caught by their shoe lace. They trip over and slam their head on the base of a solid metal standing coat-hanger.";
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

                case 30: ///scene
                    {
                        //output
                        outputLabel.Text = $"Display: {player} blacks out.";
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
                        outputLabel.Text = $"Display: {player} left the Inn.";
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

                        //status update
                        antiSocial = 1;
                    }
                    break;

                case 32: ///scene look out window
                    {
                        //output
                        outputLabel.Text = $"Display: {player} approaches the window. They recognize that they are on the third story.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionOneButton.Text = "Jump out window";
                        optionTwoButton.Text = "Head back to room";
                    }
                    break;

                case 34: ///scene impaled
                    {
                        //output
                        outputLabel.Text = $"Display: {player} leaps through the window. As they soar majestically through the sky, they are impaled by a tall metal fence post.";
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
                        outputLabel.Text = $"Display: {player} dies of blood loss.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 36: 
                    {
                        //output
                        outputLabel.Text = $"Display: Sometimes, being polite will get you further in life. Not often, though.";

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
                        outputLabel.Text = $"Display: {player} leaps through the window. As they land down below, they shatter both legs.";
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
                        outputLabel.Text = $"Display: The pain is blocked by the adrenaline rush that {player} receives.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //Status update
                        brokenLegs = 1;
                    }
                    break;

                case 39: ///icon broken legs outside jon
                    {
                        //output
                        outputLabel.Text = $"Display: {player} can no longer move. Take the stairs next time.";
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
                        optionTwoButton.Text = "Yes, which kigdom?";
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
                        outputLabel.Text = $"There was a thief who was coming in through the ground floor windows, stealing from my customers in the night. So I started locking everything, even the bedroom doors.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //Status update
                        knowsOfThief = 1;
                    }
                    break;

                case 44: 
                    {
                        //output
                        outputLabel.Text = "I did plan to unlock it early in the morning... Actually I should go  unlock the other doors now. Sorry for the trouble that caused you.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 45: ///icon default, scene cube
                    {
                        //output
                        outputLabel.Text = $"Display: {player} received a 1kg cube of some kind of substance as an apology gift from the Inn Keeper.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        hasCube = 1;
                    }
                    break;

                case 46: ///scene outside inn
                    {
                        //output
                        outputLabel.Text = $"Display: {player} heads outside.";
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
                        outputLabel.Text = "The King's entire blood line supposedly died in their sleep, so here in the capital things have been... shaky to say the least.";

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
                        outputLabel.Text = "Surprisingly, she's gained quite the large following due to her cruel honesty and manipulative speech.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        knowsOfCastle = 1;
                    }
                    break;

                case 51: 
                    {
                        //output
                        outputLabel.Text = "At the current rate, she'll probably weasel her way to the peak of command in this kingdom.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 52: 
                    {
                        //output
                        outputLabel.Text = "The only things stopping her from ruling this country are global politics and the Church. I pray that fool doesn't succeed.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 53: 
                    {
                        //output
                        outputLabel.Text = "Oh dear, I need to unlock the bedroom doors. Safe travels, my friend.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 54: //icon
                    {
                        //output
                        outputLabel.Text = $"Display: {player} heads outside.";
                        iconBox.Image = Properties.Resources.speechIcons;

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
                        outputLabel.Text = "You get used to it after living here for a bit. It actually only started recently, after the King's death.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 57: 
                    {
                        //output
                        outputLabel.Text = "Would you excuse me? I need to go unlock the bedroom doors. Safe travels, my friend.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 58: ///icon default
                    {
                        //output
                        outputLabel.Text = $"Display: {player} heads outside.";
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 59: ///scene character select
                    {
                        //output
                        outputLabel.Text = "Please write your player's name in the box.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        playerNameText.Visible = true;
                        playerNameText.Enabled = true;
                        playerNameTextTip.Visible = true;
                        playerNameTextShimshon.Visible = true;
                        player = "Shimshon";

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
                        if (player == "")
                        {
                            player = "Shimshon";
                        }
                        playerNameText.Visible = false;
                        playerNameText.Enabled = false;
                        playerNameTextTip.Visible = false;
                        playerNameTextShimshon.Visible = false;

                        //output
                        outputLabel.Text = "Mysterious Voice: Is anyone awake?";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;
                        ////reset everything except for name and character

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
                        outputLabel.Text = "Player: Awoga bog.";
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

                        //status update
                        saidNo = 1;
                    }
                    break;

                case 62: //icon mys
                    {
                        //output
                        outputLabel.Text = "Mysterious Voice: Oh boy... you are certainly illiterate. Poor little guy... I'll take that as a yes.";
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

                case 63: ///icon player
                    {
                        //output
                        outputLabel.Text = "Player: * Grunts like a sexually frustrated whale";
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

                case 64: /// icon mys
                    {
                        //output
                        outputLabel.Text = "";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionOneButton.Text = "Mysterious Voice: Don't just grunt at me, you filthy barbarian!";
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
                        outputLabel.Text = $"Display: The world rattles as the echoes of bombs ring in {player}'s' ears.";
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 67: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} believes they are in a room of some kind.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 68: /// scene window
                    {
                        //output
                        outputLabel.Text = $"Display: {player} sees what appears to be light from a window to their left.";
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
                        outputLabel.Text = $"Display: The door is locked, what would {player} like to do?";

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
                        outputLabel.Text = $"Display: The door stood no chance against the might of {player}!";
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
                        outputLabel.Text = $"Display: Congratulations! {player} broke their arm and gained access to the hallways.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 73: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} will no longer be able to pickpocket.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        brokenArms = 1;
                    }
                    break;

                case 74: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} is met by a staircase at the end of the hallway, which weaves through a long and bendy corridor.";

                        //button settings
                       optionFourButton.Text = "Next";
                    }
                    break;

                case 75: //scene slippers
                    {
                        //output
                        outputLabel.Text = $"Display: The steps of {player} are masked by their pink bunny slippers, slippers of which are worn to increase {player}'s sneakiness.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 76: //scene bottom stairs
                    {
                        //output
                        outputLabel.Text = $"Display: Once at the bottom, {player} sees something at what might possibly be a reception desk.";
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
                        optionOneButton.Text = "Talk to it";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "Study it's behaviour";
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
                        outputLabel.Text = "Player: & G#^ GROG *&*** SLAAAAAAAAAAA";
                        iconBox.Image = Properties.Resources.speechIcons;

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
                        iconBox.Image = Properties.Resources.speechIcons;

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
                        optionOneButton.Text = "Tell a knock-knock joke";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "'You want me to leave?'";
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
                        outputLabel.Text = "Player: NOK NOK! WHUS TGER? WIPPPPY!!!!";
                        iconBox.Image = Properties.Resources.speechIcons;

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
                        outputLabel.Text = $"Display: {player} laughs manically while 'The Thing That Stands' begins to fear for its life.";
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 85: 
                    {
                        //output
                        outputLabel.Text = "Display: 'It' chuckles slightly in an attempt to hide its fear.";

                        //button settings
                        optionOneButton.Text = "Notice that the knock-knock joke was a flop";
                        optionOneBlocked.Visible = false;
                        optionOneButton.Enabled = true;
                        optionTwoButton.Text = "It's fear excites {player}";
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
                        outputLabel.Text = $"Display: {player} can smell the bitter scent of its fear.";

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
                        outputLabel.Text = $"Display: {player} attempts to eat 'The Thing That Stands,' however fails to do so.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 88: //scene dead on inn floor
                    {
                        //output
                        outputLabel.Text = $"Display: As the body of {player} lies on the ground, 'The Thing That Stands' runs away through the door.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 89: 
                    {
                        //output
                        outputLabel.Text = "Display: 'It' thanks the guards outside. Another moment and 'It' knew it would have lost its life.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 90: 
                    {
                        //output
                        outputLabel.Text = "Display: It is wrong to try to eat someone while they are talking to you.";

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
                        outputLabel.Text = $"Display: {player} slowly approaches 'The Thing That Stands' reception desk.";

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
                        outputLabel.Text = $"Display: The desk is covered in strange oddities, all of which are unknown to {player}.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 93: 
                    {
                        //output
                        outputLabel.Text = $"Display: Player begins knocking objects off of the table in quick, cat-like motions. As objects rain down from the table, 'The Thing That Stands' shouts from behind:";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 94: //icon innn keeper
                    {
                        //output
                        outputLabel.Text = "Inn Keeper: I have an Inn to run here buddy, I can't let you do that.";
                        iconBox.Image = Properties.Resources.speechIcons;

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
                        outputLabel.Text = "Display: {player} did not understand much of what 'The Thing That Stands' said.";
                        mainMenuBox.Image = Properties.Resources.scene;
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 97: 
                    {
                        //output
                        outputLabel.Text = "Display: {player} spots something shiny outside, and leaves.";

                        //button settings
                        optionFourButton.Text = "I love shiny things";
                    }
                    break;

                case 98: //player icon
                    {
                        //output
                        outputLabel.Text = "Player: rar tloo #&^& slab";
                        iconBox.Image = Properties.Resources.speechIcons;

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
                        outputLabel.Text = $"Display: 'The Thing That Stands' does not understand {player}, but 'it' begins to pity {player}.";
                        iconBox.Image = Properties.Resources.speechIcons;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 100: //scene cube
                    {
                        //output
                        outputLabel.Text = "Display: 'The Thing That Stands' introduces itself as the Inn Keeper, and offers you a 1kg cube of some kind of substance.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 101: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} does not fully understand anything that has happened, or why they are being given a big square...";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        trustInnKeeper = 1;
                    }
                    break;

                case 102: 
                    {
                        //output
                        outputLabel.Text = $"Display: Still, they feel a strange new trust towards the Inn Keeper as they head outside.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 103: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} feels unwanted.";

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
                        outputLabel.Text = $"Display: {player} leaves the building. From the outside, even the small brain of {player} can figure out that this building is an Inn";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 105: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} leaves the building. From the outside, even the small brain of {player} can figure out that this building is an Inn";

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
                        outputLabel.Text = $"Display: Before a single word is uttered from 'The Thing That Stands', {player} pushes themselves off of the stairs and leaps through the air.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 107: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} stares into the eyes of 'The Thing That Stands' as they make contact with their upper body.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 108: //scene crouch atop
                    {
                        //output
                        outputLabel.Text = $"Display: {player} crouches atop the shoulders of 'It', and grabs its head.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 109: //scene red room
                    {
                        //output
                        outputLabel.Text = "Display: The room is painted red.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 110: 
                    {
                        //output
                        outputLabel.Text = $"Display: {player} has decapitated the Inn Keeper.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 111: //
                    {
                        //output
                        outputLabel.Text = $"Display: {player} has been permanently blinded by their new found blood-lust.";

                        //button settings
                        optionFourButton.Text = "Next";

                        //status update
                        bloodlust = 1;
                    }
                    break;

                case 112: //scene in front of body
                    {
                        //output
                        outputLabel.Text = "Display: Player stands in front of the body.";
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
                        outputLabel.Text = $"Display: {player} heads outside in search of more victims.";
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
                        outputLabel.Text = $"Display: {player} combs through every pocket on the body.";

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
                        outputLabel.Text = $"Display: {player} grabs hold of a 1kg cube of some kind of substance.";
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
                        outputLabel.Text = "Display: They stash away the cube on their person.";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 117: //scene caught
                    {
                        //output
                        outputLabel.Text = $"Display: Someone spots {player}'s crime through the window and begins to giggle.";
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
                        outputLabel.Text = $"Display: {player} heads outside to kill the witness to their crime.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 119: //////START HERE TOMORROW
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

                case 120: //
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

                case 121: //
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

                case 122: //
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

                case 123: //
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

                case 124: //
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

                case 125: //
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

                case 126: //
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

                case 127: //
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

                case 128: //
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

                case 129: //
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

                case 130: //
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

                case 131: //
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

                case 132: //
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

                case 133: //
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

                case 134: //
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

                case 135: //
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

                case 136: //
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

                case 137: //
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

                case 138: //
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

                case 139: //
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

                case 140: //
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

                case 141: //
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

                case 142: //
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

                case 143: //
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

                case 144: //
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

                case 145: //
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

                case 146: //
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

                case 147: //
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

                case 148: //
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

                case 149: //
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

                case 150: //
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

                case 151: //
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

                case 152: //
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

                case 153: //
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

                case 154: //
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

                case 155: //
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

                case 156: //
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

                case 157: //
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

                case 158: //
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

                case 159: //
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

                case 160: //
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

                case 161: //
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

                case 162: //
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

                case 163: //
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

                case 164: //
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

                case 165: //
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

                case 166: //
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

                case 167: //
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

                case 168: //
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

                case 169: //
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

                case 170: //
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

                case 171: //
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

                case 172: //
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

                case 173: //
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

                case 174: //
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

                case 175: //
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

                case 176: //
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

                case 177: //
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

                case 178: //
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

                case 179: //
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

                case 180: //
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

                case 181: //
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

                case 182: //
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

                case 183: //
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

                case 184: //
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

                case 185: //
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

                case 186: //
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

                case 187: //
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

                case 188: //
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

                case 189: //
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

                case 190: //
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

                case 191: //
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

                case 192: //
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

                case 193: //
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

                case 194: //
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

                case 195: //
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

                case 196: //
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

                case 197: //
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

                case 198: //
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

                case 199: //
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

                case 200: //
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

                case 201: //
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

                case 202: //
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

                case 203: //
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

                case 204: //
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

                case 205: //
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

                case 206: //
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

                case 207: //
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

                case 208: //
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

                case 209: //
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

                case 210: //
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

                case 211: //
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

                case 212: //
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

                case 213: //
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

                case 214: //
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

                case 215: //
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

                case 216: //
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

                case 217: //
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

                case 218: //
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

                case 219: //
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

                case 220: //
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

                case 221: //
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

                case 222: //
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

                case 223: //
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

                case 224: //
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

                case 225: //
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

                case 226: //
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

                case 227: //
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

                case 228: //
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

                case 229: //
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

                case 230: //
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

                case 231: //
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

                case 232: //
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

                case 233: //
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

                case 234: //
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

                case 235: //
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

                case 236: //
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

                case 237: //
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

                case 238: //
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

                case 239: //
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

                case 240: //
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

                case 241: //
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

                case 242: //
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

                case 243: //
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

                case 244: //
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

                case 245: //
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

                case 246: //
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

                case 247: //
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

                case 248: //
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

                case 249: //
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

                case 250: //
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

                case 251: //
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

                case 252: //
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

                case 253: //
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

                case 254: //
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

                case 255: //
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

                case 256: //
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

                case 257: //
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

                case 258: //
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

                case 259: //
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

                case 260: //
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

                case 261: //
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

                case 262: //
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

                case 263: //
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

                case 264: //
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

                case 265: //
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

                case 266: //
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

                case 267: //
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

                case 268: //
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

                case 269: //
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

                case 270: //
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

                case 271: //
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

                case 272: //
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

                case 273: //
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

                case 274: //
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

                case 275: //
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

                case 276: //
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

                case 278: //
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

                case 279: //
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

                case 280: //
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

                case 281: //
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

                case 282: //
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

                case 283: //
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

                case 284: //
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

                case 285: //
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

                case 286: //
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

                case 287: //
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

                case 288: //
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

                case 289: //
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

                case 290: //
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

                case 291: //
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

                case 292: //
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

                case 293: //
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

                case 294: //
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

                case 295: //
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

                case 296: //
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

                case 297: //
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

                case 298: //
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

                case 299: //
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

                case 300: //
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

                case 301: //
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

                case 302: //
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

                case 303: //
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

                case 304: //
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

                case 305: //
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

                case 306: //
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

                case 307: //
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

                case 308: //
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

                case 309: //
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

                case 310: //
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

                case 311: //
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

                case 312: //
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

                case 313: //
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

                case 314: //
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

                case 315: //
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

                case 316: //
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

                case 317: //
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

                case 318: //
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

                case 319: //
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

                case 320: //
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

                case 321: //
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

                case 322: //
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

                case 323: //
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

                case 324: //
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

                case 325: //
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

                case 326: //
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

                case 327: //
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

                case 328: //
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

                case 329: //
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

                case 330: //
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

                case 331: //
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

                case 332: //
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

                case 333: //
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

                case 334: //
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

                case 335: //
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

                case 336: //
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

                case 337: //
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

                case 338: //
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

                case 339: //
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

                case 340: //
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

                case 341: //
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

                case 342: //
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

                case 343: //
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

                case 344: //
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

                case 345: //
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

                case 346: //
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

                case 347: //
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

                case 348: //
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

                case 349: //
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

                case 350: //
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

                case 351: //
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

                case 352: //
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

                case 353: //
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

                case 354: //
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

                case 355: //
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

                case 356: //
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

                case 357: //
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

                case 358: //
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

                case 359: //
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

                case 360: //
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

                case 361: //
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

                case 362: //
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

                case 363: //
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

                case 364: //
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

                case 365: //
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

                case 366: //
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

                case 367: //
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

                case 368: //
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

                case 369: //
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

                case 370: //
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

                case 371: //
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

                case 372: //
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

                case 373: //
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

                case 374: //
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

                case 375: //
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

                case 376: //
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

                case 377: //
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

                case 378: //
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

                case 379: //
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

                case 380: //
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

                case 381: //
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

                case 382: //
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

                case 383: //
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

                case 384: //
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

                case 385: //
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

                case 386: //
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

                case 387: //
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

                case 388: //
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

                case 389: //
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

                case 390: //
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

                case 391: //
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

                case 392: //
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

                case 393: //
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

                case 394: //
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

                case 395: //
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

                case 396: //
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

                case 397: //
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

                case 398: //
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

                case 399: //
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

                case 400: //
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

                case 401: //
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

                case 402: //
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

                case 403: //
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

                case 404: //
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

                case 405: //
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

                case 406: //
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

                case 407: //
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

                case 408: //
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

                case 409: //scene fast run boards
                    {
                        //output
                        outputLabel.Text = $"Display: {player} sprints towards the window at full velocity, ripping floor boards up off the ground with their incredible speed.";
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
                        outputLabel.Text = $"Display: Without thinking, {player} jumps out of the window. They fall three stories before landing onto a soft haystack.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 411: ///scene standing casually
                    {
                        //output
                        outputLabel.Text = $"Display: {player} is uninjured.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 412: ///scene ripping boards up
                    {
                        //output
                        outputLabel.Text = $"Display: {player} sprints towards the window at full velocity, ripping floor boards up off the ground with their incredible speed.";
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
                        outputLabel.Text = $"Display: Without thinking, {player} jumps out of the window. They fall three stories before faceplanting into the concrete.";
                        mainMenuBox.Image = Properties.Resources.scene;

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 414: ///scene broken legs
                    {
                        //output
                        outputLabel.Text = $"Display: {player} is injured, and will no longer be able to move.";
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
                        outputLabel.Text = $"Display: {player} is outside of the Inn";

                        //button settings
                        optionFourButton.Text = "Next";
                    }
                    break;

                case 998: //WIN (proper ending)
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

                case 999: //DEAD 
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

                case 1000: //Goodbye page
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


                default:
                    break;

            }
        }
    }

}
