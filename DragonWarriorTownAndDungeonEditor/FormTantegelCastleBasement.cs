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
    public partial class FormTantegelCastleBasement : Form
    {
        string path;

        public FormTantegelCastleBasement(string gamePath)
        {
            InitializeComponent();
            populateComboBoxTileTypes();
            path = gamePath;
        }

        /*
         * Towns:
         * Number| Tile
         * ------+-------------------
         * 0 | Grass
         * 1 | Desert
         * 2 | Water
         * 3 | Treasure Chest
         * 4 | Solid Stone Wall
         * 5 | Stairs Up
         * 6 | Red Brick Floor
         * 7 | Stairs Down
         * 8 | Grass - Special
         * 9 | Desert - Special
         * A | Water - Special
         * B | Treasure Chest - Special
         * C | Solid Stone Wall - Special
         * D | Stairs Up - Special
         * E | Red Brick Floor - Special
         * F | Stairs Down - Special
         */
        private void loadMap()
        {
            ClassDWBackend classDWBackend = new ClassDWBackend(path);

            string tantegelCastlBasementSunlightShrineHexData = classDWBackend.getTantegelCastleBasementSunlightShrineData();

            int x = 1;
            bool hasError = false;

            foreach (char ch in tantegelCastlBasementSunlightShrineHexData)
            {
                try
                {
                    PictureBox currentPictureBox = (PictureBox)FormTantegelCastleBasement.ActiveForm.Controls.Find("pictureBox" + x, true)[0];

                    switch (ch)
                    {
                        case '0':
                            currentPictureBox.Image = Properties.Resources._0_grass;
                            currentPictureBox.Image.Tag = "0-Grass";
                            break;
                        case '1':
                            currentPictureBox.Image = Properties.Resources._1_desert;
                            currentPictureBox.Image.Tag = "1-Desert";
                            break;
                        case '2':
                            currentPictureBox.Image = Properties.Resources._2_water;
                            currentPictureBox.Image.Tag = "2-Water";
                            break;
                        case '3':
                            currentPictureBox.Image = Properties.Resources._3_treasurechest;
                            currentPictureBox.Image.Tag = "3-TreasureChest";
                            break;
                        case '4':
                            currentPictureBox.Image = Properties.Resources._4_solidstonewall2;
                            currentPictureBox.Image.Tag = "4-SolidStoneWall2";
                            break;
                        case '5':
                            currentPictureBox.Image = Properties.Resources._5_stairsup;
                            currentPictureBox.Image.Tag = "5-StairsUp";
                            break;
                        case '6':
                            currentPictureBox.Image = Properties.Resources._6_redbrickfloor;
                            currentPictureBox.Image.Tag = "6-RedBrickFloor";
                            break;
                        case '7':
                            currentPictureBox.Image = Properties.Resources._7_stairsdown;
                            currentPictureBox.Image.Tag = "7-StairsDown";
                            break;
                        case '8':
                            currentPictureBox.Image = Properties.Resources._8_grass_special;
                            currentPictureBox.Image.Tag = "8-Grass-Special";
                            break;
                        case '9':
                            currentPictureBox.Image = Properties.Resources._9_desert_special;
                            currentPictureBox.Image.Tag = "9-Desert-Special";
                            break;
                        case 'A':
                            currentPictureBox.Image = Properties.Resources.a_water_special;
                            currentPictureBox.Image.Tag = "A-Water-Special";
                            break;
                        case 'B':
                            currentPictureBox.Image = Properties.Resources.b_treasurechest_special;
                            currentPictureBox.Image.Tag = "B-TreasureChest-Special";
                            break;
                        case 'C':
                            currentPictureBox.Image = Properties.Resources.c_solidstonewall_special;
                            currentPictureBox.Image.Tag = "C-SolidStoneWall-Special";
                            break;
                        case 'D':
                            currentPictureBox.Image = Properties.Resources.d_stairsup_special;
                            currentPictureBox.Image.Tag = "D-StairsUp-Special";
                            break;
                        case 'E':
                            currentPictureBox.Image = Properties.Resources.e_redbrickfloor_special;
                            currentPictureBox.Image.Tag = "E-RedBrickFloor-Special";
                            break;
                        case 'F':
                            currentPictureBox.Image = Properties.Resources.f_stairsdown_special;
                            currentPictureBox.Image.Tag = "F-StairsDown-Special";
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
            string newTantegelCastletantegelCastlBasementSunlightShrineHexData = "";
            for (int x = 1; x <= 100; x++)
            {
                try
                {
                    PictureBox currentPictureBox = (PictureBox)FormTantegelCastleBasement.ActiveForm.Controls.Find("pictureBox" + x, true)[0];
                    String currentImageTag = currentPictureBox.Image.Tag.ToString();

                    if (currentImageTag == "0-Grass")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "0";
                    }
                    else if (currentImageTag == "1-Desert")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "1";
                    }
                    else if (currentImageTag == "2-Water")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "2";
                    }
                    else if (currentImageTag == "3-TreasureChest")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "3";
                    }
                    else if (currentImageTag == "4-SolidStoneWall2")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "4";
                    }
                    else if (currentImageTag == "5-StairsUp")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "5";
                    }
                    else if (currentImageTag == "6-RedBrickFloor")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "6";
                    }
                    else if (currentImageTag == "7-StairsDown")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "7";
                    }
                    else if (currentImageTag == "8-Grass-Special")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "8";
                    }
                    else if (currentImageTag == "9-Desert-Special")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "9";
                    }
                    else if (currentImageTag == "A-Water-Special")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "A";
                    }
                    else if (currentImageTag == "B-TreasureChest-Special")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "B";
                    }
                    else if (currentImageTag == "C-SolidStoneWall-Special")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "C";
                    }
                    else if (currentImageTag == "D-StairsUp-Special")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "D";
                    }
                    else if (currentImageTag == "E-RedBrickFloor-Special")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "E";
                    }
                    else if (currentImageTag == "F-StairsDown-Special")
                    {
                        newTantegelCastletantegelCastlBasementSunlightShrineHexData += "F";
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Failed to write ROM: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bool result = classDWBackend.setTantegelCastleBasementSunlightShrineData(newTantegelCastletantegelCastlBasementSunlightShrineHexData);
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

            tileTypes.Add("0", "Grass");
            tileTypes.Add("1", "Desert");
            tileTypes.Add("2", "Water");
            tileTypes.Add("3", "Treasure Chest");
            tileTypes.Add("4", "Solid Stone");
            tileTypes.Add("5", "Stairs Up");
            tileTypes.Add("6", "Red Brick Floor");
            tileTypes.Add("7", "Stairs Down");
            tileTypes.Add("8", "Grass - Special");
            tileTypes.Add("9", "Desert - Special");
            tileTypes.Add("A", "Water - Special");
            tileTypes.Add("B", "Treasure Chest - Special");
            tileTypes.Add("C", "Solid Stone - Special");
            tileTypes.Add("D", "Stairs Up - Special");
            tileTypes.Add("E", "Red Brick Floor - Special");
            tileTypes.Add("F", "Stairs Down - Special");

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
                        currentPictureBox.Image = Properties.Resources._0_grass;
                        currentPictureBox.Image.Tag = "0-Grass";
                        break;
                    case '1':
                        currentPictureBox.Image = Properties.Resources._1_desert;
                        currentPictureBox.Image.Tag = "1-Desert";
                        break;
                    case '2':
                        currentPictureBox.Image = Properties.Resources._2_water;
                        currentPictureBox.Image.Tag = "2-Water";
                        break;
                    case '3':
                        currentPictureBox.Image = Properties.Resources._3_treasurechest;
                        currentPictureBox.Image.Tag = "3-TreasureChest";
                        break;
                    case '4':
                        currentPictureBox.Image = Properties.Resources._4_solidstonewall2;
                        currentPictureBox.Image.Tag = "4-SolidStoneWall2";
                        break;
                    case '5':
                        currentPictureBox.Image = Properties.Resources._5_stairsup;
                        currentPictureBox.Image.Tag = "5-StairsUp";
                        break;
                    case '6':
                        currentPictureBox.Image = Properties.Resources._6_redbrickfloor;
                        currentPictureBox.Image.Tag = "6-RedBrickFloor";
                        break;
                    case '7':
                        currentPictureBox.Image = Properties.Resources._7_stairsdown;
                        currentPictureBox.Image.Tag = "7-StairsDown";
                        break;
                    case '8':
                        currentPictureBox.Image = Properties.Resources._8_grass_special;
                        currentPictureBox.Image.Tag = "8-Grass-Special";
                        break;
                    case '9':
                        currentPictureBox.Image = Properties.Resources._9_desert_special;
                        currentPictureBox.Image.Tag = "9-Desert-Special";
                        break;
                    case 'A':
                        currentPictureBox.Image = Properties.Resources.a_water_special;
                        currentPictureBox.Image.Tag = "A-Water-Special";
                        break;
                    case 'B':
                        currentPictureBox.Image = Properties.Resources.b_treasurechest_special;
                        currentPictureBox.Image.Tag = "B-TreasureChest-Special";
                        break;
                    case 'C':
                        currentPictureBox.Image = Properties.Resources.c_solidstonewall_special;
                        currentPictureBox.Image.Tag = "C-SolidStoneWall-Special";
                        break;
                    case 'D':
                        currentPictureBox.Image = Properties.Resources.d_stairsup_special;
                        currentPictureBox.Image.Tag = "D-StairsUp-Special";
                        break;
                    case 'E':
                        currentPictureBox.Image = Properties.Resources.e_redbrickfloor_special;
                        currentPictureBox.Image.Tag = "E-RedBrickFloor-Special";
                        break;
                    case 'F':
                        currentPictureBox.Image = Properties.Resources.f_stairsdown_special;
                        currentPictureBox.Image.Tag = "F-StairsDown-Special";
                        break;
                    default:
                        break;
                }

                currentPictureBox.Refresh();
                currentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                currentPictureBox.Visible = true;
            }
        }

        private void button0Grass_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 0;
        }

        private void button1Desert_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 1;
        }

        private void button2Water_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 2;
        }

        private void button3TreasureChest_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 3;
        }

        private void button4SolidStoneWall2_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 4;
        }

        private void button5StairsUp_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 5;
        }

        private void button6RedBrickFloor_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 6;
        }

        private void button7StairsDown_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 7;
        }

        private void button8GrassSpecial_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 8;
        }

        private void button9DesertSpecial_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 9;
        }

        private void buttonAWaterSpecial_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 10;
        }

        private void buttonBTreasureChestSpecial_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 11;
        }

        private void buttonCSolidStoneWallSpecial_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 12;
        }

        private void buttonDStairsUpSpecial_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 13;
        }

        private void buttonERedBrickFloorSpecial_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 14;
        }

        private void buttonFStairsDownSpecial_Click(object sender, EventArgs e)
        {
            comboBoxTileTypes.SelectedIndex = 15;
        }

        private void buttonWriteROM_Click(object sender, EventArgs e)
        {
            saveMap();
        }
    }
}
