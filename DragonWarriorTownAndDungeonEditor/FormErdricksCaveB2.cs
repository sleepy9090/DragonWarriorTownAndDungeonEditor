using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Shawn M. Crawford - [sleepy9090] - 2017
namespace DragonWarriorTownAndDungeonEditor
{
    public partial class FormErdricksCaveB2 : Form
    {
        string path;

        public FormErdricksCaveB2(string gamePath)
        {
            InitializeComponent();
            populateComboBoxTileTypes();
            path = gamePath;
        }

        /*
         * Caves:
         * Number| Tile
         * ------+-------------------
         * 0 | Cracked Stone Wall
         * 1 | Stairs Up
         * 2 | Red Brick Floor
         * 3 | Stairs Down
         * 4 | Treasure Chest
         * 5 | Locked Door
         * 6 | Princess Gwaelin
         * 7 | Black wall ??????
         */
        private void loadMap()
        {
            ClassDWBackend classDWBackend = new ClassDWBackend(path);

            string erdricksCaveB2HexData = classDWBackend.getErdricksCaveB2Data();
            int x = 1;
            bool hasError = false;

            foreach (char ch in erdricksCaveB2HexData)
            {
                try
                {
                    PictureBox currentPictureBox = (PictureBox)FormErdricksCaveB2.ActiveForm.Controls.Find("pictureBox" + x, true)[0];

                    switch (ch)
                    {
                        case '0':
                            currentPictureBox.Image = Properties.Resources._0_crackedstonewall;
                            currentPictureBox.Image.Tag = "0-CrackedStoneWall";
                            break;
                        case '1':
                            currentPictureBox.Image = Properties.Resources._1_stairsup;
                            currentPictureBox.Image.Tag = "1-StairsUp";
                            break;
                        case '2':
                            currentPictureBox.Image = Properties.Resources._2_redbrickfloor;
                            currentPictureBox.Image.Tag = "2-RedBrickFloor";
                            break;
                        case '3':
                            currentPictureBox.Image = Properties.Resources._3_stairsdown;
                            currentPictureBox.Image.Tag = "3-StairsDown";
                            break;
                        case '4':
                            currentPictureBox.Image = Properties.Resources._4_treasurechest;
                            currentPictureBox.Image.Tag = "4-TreasureChest";
                            break;
                        case '5':
                            currentPictureBox.Image = Properties.Resources._5_lockeddoor;
                            currentPictureBox.Image.Tag = "5-LockedDoor";
                            break;
                        case '6':
                            currentPictureBox.Image = Properties.Resources._6_princessgwaelin;
                            currentPictureBox.Image.Tag = "6-PrincessGwaelin";
                            break;
                        case '7':
                            currentPictureBox.Image = Properties.Resources._7_blackwall;
                            currentPictureBox.Image.Tag = "7-BlackWall";
                            break;
                        // So this occurs because it is "roof" tiles for another map, so 8 would be 1000, we ignore the upper bit of the nibble, so treat as 0
                        case '8':
                            currentPictureBox.Image = Properties.Resources._0_crackedstonewall_special;
                            currentPictureBox.Image.Tag = "8-CrackedStoneWall-Special";
                            break;
                        // So this occurs because it is "roof" tiles for another map, so 9 would be 1001, we ignore the upper bit, so treat as 1
                        case '9':
                            currentPictureBox.Image = Properties.Resources._1_stairsup_special;
                            currentPictureBox.Image.Tag = "9-StairsUp-Special";
                            break;
                        // Same as above for the remaining
                        case 'A':
                            currentPictureBox.Image = Properties.Resources._2_redbrickfloor_special;
                            currentPictureBox.Image.Tag = "A-RedBrickFloor-Special";
                            break;
                        case 'B':
                            currentPictureBox.Image = Properties.Resources._3_stairsdown_special;
                            currentPictureBox.Image.Tag = "B-StairsDown-Special";
                            break;
                        case 'C':
                            currentPictureBox.Image = Properties.Resources._4_treasurechest_special;
                            currentPictureBox.Image.Tag = "C-TreasureChest-Special";
                            break;
                        case 'D':
                            currentPictureBox.Image = Properties.Resources._5_lockeddoor_special;
                            currentPictureBox.Image.Tag = "D-LockedDoor-Special";
                            break;
                        case 'E':
                            currentPictureBox.Image = Properties.Resources._6_princessgwaelin_special;
                            currentPictureBox.Image.Tag = "E-PrincessGwaelin-Special";
                            break;
                        case 'F':
                            currentPictureBox.Image = Properties.Resources._7_blackwall_special;
                            currentPictureBox.Image.Tag = "F-BlackWall-Special";
                            break;
                        default:
                            break;
                    }

                    currentPictureBox.Refresh();
                    currentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    currentPictureBox.Visible = true;

                    x++;
                }
                catch (Exception ex)
                {
                    hasError = true;
                    break;
                }
            }

            if (hasError)
            {
                MessageBox.Show("Failed to populate map tiles. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void saveMap()
        {
            ClassDWBackend classDWBackend = new ClassDWBackend(path);
            string newErdricksCaveB2HexData = "";
            for (int x = 1; x <= 100; x++)
            {
                try
                {
                    PictureBox currentPictureBox = (PictureBox)FormErdricksCaveB2.ActiveForm.Controls.Find("pictureBox" + x, true)[0];
                    String currentImageTag = currentPictureBox.Image.Tag.ToString();

                    if (currentImageTag == "0-CrackedStoneWall")
                    {
                        newErdricksCaveB2HexData += "0";
                    }
                    else if (currentImageTag == "1-StairsUp")
                    {
                        newErdricksCaveB2HexData += "1";
                    }
                    else if (currentImageTag == "2-RedBrickFloor")
                    {
                        newErdricksCaveB2HexData += "2";
                    }
                    else if (currentImageTag == "3-StairsDown")
                    {
                        newErdricksCaveB2HexData += "3";
                    }
                    else if (currentImageTag == "4-TreasureChest")
                    {
                        newErdricksCaveB2HexData += "4";
                    }
                    else if (currentImageTag == "5-LockedDoor")
                    {
                        newErdricksCaveB2HexData += "5";
                    }
                    else if (currentImageTag == "6-PrincessGwaelin")
                    {
                        newErdricksCaveB2HexData += "6";
                    }
                    else if (currentImageTag == "7-BlackWall")
                    {
                        newErdricksCaveB2HexData += "7";
                    }
                    else if (currentImageTag == "8-CrackedStoneWall-Special")
                    {
                        newErdricksCaveB2HexData += "8";
                    }
                    else if (currentImageTag == "9-StairsUp-Special")
                    {
                        newErdricksCaveB2HexData += "9";
                    }
                    else if (currentImageTag == "A-RedBrickFloor-Special")
                    {
                        newErdricksCaveB2HexData += "A";
                    }
                    else if (currentImageTag == "B-StairsDown-Special")
                    {
                        newErdricksCaveB2HexData += "B";
                    }
                    else if (currentImageTag == "C-TreasureChest-Special")
                    {
                        newErdricksCaveB2HexData += "C";
                    }
                    else if (currentImageTag == "D-LockedDoor-Special")
                    {
                        newErdricksCaveB2HexData += "D";
                    }
                    else if (currentImageTag == "E-PrincessGwaelin-Special")
                    {
                        newErdricksCaveB2HexData += "E";
                    }
                    else if (currentImageTag == "F-BlackWall-Special")
                    {
                        newErdricksCaveB2HexData += "F";
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Failed to write ROM: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bool result = classDWBackend.setErdricksCaveB2Data(newErdricksCaveB2HexData);
            if (result)
            {
                MessageBox.Show("Successfully wrote ROM.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to write ROM.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateComboBoxTileTypes()
        {
            Dictionary<string, string> tileTypes = new Dictionary<string, string>();

            tileTypes.Add("0", "Solid Stone");
            tileTypes.Add("1", "Stairs Up");
            tileTypes.Add("2", "Red Brick Floor");
            tileTypes.Add("3", "Stairs Down");
            tileTypes.Add("4", "Treasure Chest");
            tileTypes.Add("5", "Locked Door");
            tileTypes.Add("6", "Princess Gwaelin");
            tileTypes.Add("7", "Black Wall");
            tileTypes.Add("8", "Solid Stone - Special");
            tileTypes.Add("9", "Stairs Up - Special");
            tileTypes.Add("A", "Red Brick Floor - Special");
            tileTypes.Add("B", "Stairs Down - Special");
            tileTypes.Add("C", "Treasure Chest - Special");
            tileTypes.Add("D", "Locked Door - Special");
            tileTypes.Add("E", "Princess Gwaelin - Special");
            tileTypes.Add("F", "Black Wall - Special");

            comboBoxTileTypes.DataSource = new BindingSource(tileTypes, null);
            comboBoxTileTypes.DisplayMember = "Value";
            comboBoxTileTypes.ValueMember = "Key";
        }

        private void loadMap(object sender, EventArgs e)
        {
            loadMap();
        }

        private void changeMap(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox currentPictureBox = ((PictureBox)sender);
                string tileType = comboBoxTileTypes.SelectedValue.ToString();
                char ch = Convert.ToChar(tileType);

                switch (ch)
                {
                    case '0':
                        currentPictureBox.Image = Properties.Resources._0_crackedstonewall;
                        currentPictureBox.Image.Tag = "0-CrackedStoneWall";
                        break;
                    case '1':
                        currentPictureBox.Image = Properties.Resources._1_stairsup;
                        currentPictureBox.Image.Tag = "1-StairsUp";
                        break;
                    case '2':
                        currentPictureBox.Image = Properties.Resources._2_redbrickfloor;
                        currentPictureBox.Image.Tag = "2-RedBrickFloor";
                        break;
                    case '3':
                        currentPictureBox.Image = Properties.Resources._3_stairsdown;
                        currentPictureBox.Image.Tag = "3-StairsDown";
                        break;
                    case '4':
                        currentPictureBox.Image = Properties.Resources._4_treasurechest;
                        currentPictureBox.Image.Tag = "4-TreasureChest";
                        break;
                    case '5':
                        currentPictureBox.Image = Properties.Resources._5_lockeddoor;
                        currentPictureBox.Image.Tag = "5-LockedDoor";
                        break;
                    case '6':
                        currentPictureBox.Image = Properties.Resources._6_princessgwaelin;
                        currentPictureBox.Image.Tag = "6-PrincessGwaelin";
                        break;
                    case '7':
                        currentPictureBox.Image = Properties.Resources._7_blackwall;
                        currentPictureBox.Image.Tag = "7-BlackWall";
                        break;
                    case '8':
                        currentPictureBox.Image = Properties.Resources._0_crackedstonewall_special;
                        currentPictureBox.Image.Tag = "8-CrackedStoneWall-Special";
                        break;
                    case '9':
                        currentPictureBox.Image = Properties.Resources._1_stairsup_special;
                        currentPictureBox.Image.Tag = "9-StairsUp-Special";
                        break;
                    case 'A':
                        currentPictureBox.Image = Properties.Resources._2_redbrickfloor_special;
                        currentPictureBox.Image.Tag = "A-RedBrickFloor-Special";
                        break;
                    case 'B':
                        currentPictureBox.Image = Properties.Resources._3_stairsdown_special;
                        currentPictureBox.Image.Tag = "B-StairsDown-Special";
                        break;
                    case 'C':
                        currentPictureBox.Image = Properties.Resources._4_treasurechest_special;
                        currentPictureBox.Image.Tag = "C-TreasureChest-Special";
                        break;
                    case 'D':
                        currentPictureBox.Image = Properties.Resources._5_lockeddoor_special;
                        currentPictureBox.Image.Tag = "D-LockedDoor-Special";
                        break;
                    case 'E':
                        currentPictureBox.Image = Properties.Resources._6_princessgwaelin_special;
                        currentPictureBox.Image.Tag = "E-PrincessGwaelin-Special";
                        break;
                    case 'F':
                        currentPictureBox.Image = Properties.Resources._7_blackwall_special;
                        currentPictureBox.Image.Tag = "F-BlackWall-Special";
                        break;
                    default:
                        break;
                }

                currentPictureBox.Refresh();
                currentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                currentPictureBox.Visible = true;
            }
        }

        private void button0CrackedStoneWall_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 0;
        }

        private void button1StairsUp_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 1;
        }

        private void button2RedBrickFloor_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 2;
        }

        private void button3StairsDown_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 3;
        }

        private void button4TreasureChest_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 4;
        }

        private void button5LockedDoor_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 5;
        }

        private void button6PrincessGwaelin_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 6;
        }

        private void button7BlackWall_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 7;
        }

        private void button8CrackedStoneWall_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 8;
        }

        private void button9StairsUp_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 9;
        }

        private void buttonARedBrickFloor_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 10;
        }

        private void buttonBStairsDown_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 11;
        }

        private void buttonCTreasureChest_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 12;
        }

        private void buttonDLockedDoor_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 13;
        }

        private void buttonEPrincessGwaelin_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 14;
        }

        private void buttonFBlackWall_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 15;
        }

        private void buttonWriteROM_Click(object sender, EventArgs e)
        {
            saveMap();
        }
    }
}
