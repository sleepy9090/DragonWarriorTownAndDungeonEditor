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
    public partial class FormMain : Form
    {
        string filepath;

        public FormMain()
        {
            InitializeComponent();
            populateComboBoxSelectMap();
            setFormControlsStatus(false);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonOpen_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open file...";
            openFileDialog.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                setFormControlsStatus(true);

                string path = openFileDialog.FileName;
                filepath = path;
                textBoxFileName.Text = path;


            }
        }

        private void populateComboBoxSelectMap()
        {
            comboBoxSelectMap.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxSelectMap.Items.Add("Brecconary");
            comboBoxSelectMap.Items.Add("Cantlin");
            comboBoxSelectMap.Items.Add("Charlock Castle - B1");
            comboBoxSelectMap.Items.Add("Charlock Castle - B2");
            comboBoxSelectMap.Items.Add("Charlock Castle - B3");
            comboBoxSelectMap.Items.Add("Charlock Castle - B4");
            comboBoxSelectMap.Items.Add("Charlock Castle - B5");
            comboBoxSelectMap.Items.Add("Charlock Castle - B6");
            comboBoxSelectMap.Items.Add("Charlock Castle - B7");
            comboBoxSelectMap.Items.Add("Charlock Castle - F1");
            comboBoxSelectMap.Items.Add("Erdrick's Cave - B1");
            comboBoxSelectMap.Items.Add("Erdrick's Cave - B2");
            comboBoxSelectMap.Items.Add("Garinham");
            comboBoxSelectMap.Items.Add("Garinham Grave - B1");
            comboBoxSelectMap.Items.Add("Garinham Grave - B2");
            comboBoxSelectMap.Items.Add("Garinham Grave - B3");
            comboBoxSelectMap.Items.Add("Garinham Grave - B4");
            comboBoxSelectMap.Items.Add("Hauksness Ruins");
            comboBoxSelectMap.Items.Add("Kol");
            comboBoxSelectMap.Items.Add("Rain Shrine");
            comboBoxSelectMap.Items.Add("Rainbow Shrine");
            comboBoxSelectMap.Items.Add("Rimuldar");
            comboBoxSelectMap.Items.Add("Rock Mountain Cave - B1");
            comboBoxSelectMap.Items.Add("Rock Mountain Cave - B2");
            comboBoxSelectMap.Items.Add("Swamp Cave");
            comboBoxSelectMap.Items.Add("Tantegel Castle");
            comboBoxSelectMap.Items.Add("Tantegel Castle - Basement - Sunlight Shrine");
            comboBoxSelectMap.Items.Add("Tantegel Castle - Throne Room");

            comboBoxSelectMap.SelectedIndex = 0;
        }

        private void setFormControlsStatus(bool isEnabled)
        {
            buttonEditMap.Enabled = isEnabled;
            comboBoxSelectMap.Enabled = isEnabled;
        }

        private void buttonEditMap_Click(object sender, EventArgs e)
        {
            if(comboBoxSelectMap.SelectedItem.ToString() == "Brecconary")
            {
                FormBrecconary formBrecconary = new FormBrecconary(filepath);
                formBrecconary.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Cantlin")
            {
                FormCantlin formCantlin = new FormCantlin(filepath);
                formCantlin.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Charlock Castle - B1")
            {
                FormCharlockCastleB1 formCharlockCastleB1 = new FormCharlockCastleB1(filepath);
                formCharlockCastleB1.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Charlock Castle - B2")
            {
                FormCharlockCastleB2 formCharlockCastleB2 = new FormCharlockCastleB2(filepath);
                formCharlockCastleB2.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Charlock Castle - B3")
            {
                FormCharlockCastleB3 formCharlockCastleB3 = new FormCharlockCastleB3(filepath);
                formCharlockCastleB3.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Charlock Castle - B4")
            {
                FormCharlockCastleB4 formCharlockCastleB4 = new FormCharlockCastleB4(filepath);
                formCharlockCastleB4.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Charlock Castle - B5")
            {
                FormCharlockCastleB5 formCharlockCastleB5 = new FormCharlockCastleB5(filepath);
                formCharlockCastleB5.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Charlock Castle - B6")
            {
                FormCharlockCastleB6 formCharlockCastleB6 = new FormCharlockCastleB6(filepath);
                formCharlockCastleB6.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Charlock Castle - B7")
            {
                FormCharlockCastleB7 formCharlockCastleB7 = new FormCharlockCastleB7(filepath);
                formCharlockCastleB7.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Charlock Castle - F1")
            {
                FormCharlockCastleF1 formCharlockCastleF1 = new FormCharlockCastleF1(filepath);
                formCharlockCastleF1.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Erdrick's Cave - B1")
            {
                FormErdricksCaveB1 formErdricksCaveB1 = new FormErdricksCaveB1(filepath);
                formErdricksCaveB1.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Erdrick's Cave - B2")
            {
                FormErdricksCaveB2 formErdricksCaveB2 = new FormErdricksCaveB2(filepath);
                formErdricksCaveB2.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Garinham")
            {
                FormGarinham formGarinham = new FormGarinham(filepath);
                formGarinham.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Garinham Grave - B1")
            {
                FormGarinhamsGraveB1 formGarinhamsGraveB1 = new FormGarinhamsGraveB1(filepath);
                formGarinhamsGraveB1.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Garinham Grave - B2")
            {
                FormGarinhamsGraveB2 formGarinhamsGraveB2 = new FormGarinhamsGraveB2(filepath);
                formGarinhamsGraveB2.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Garinham Grave - B3")
            {
                FormGarinhamsGraveB3 formGarinhamsGraveB3 = new FormGarinhamsGraveB3(filepath);
                formGarinhamsGraveB3.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Garinham Grave - B4")
            {
                FormGarinhamsGraveB4 formGarinhamsGraveB4 = new FormGarinhamsGraveB4(filepath);
                formGarinhamsGraveB4.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Hauksness Ruins")
            {
                FormHauksnessRuins formHauksnessRuins = new FormHauksnessRuins(filepath);
                formHauksnessRuins.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Kol")
            {
                FormKol formKol = new FormKol(filepath);
                formKol.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Rainbow Shrine")
            {
                FormRainbowShrine formRainbowShrine = new FormRainbowShrine(filepath);
                formRainbowShrine.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Rain Shrine")
            {
                FormRainShrine formRainShrine = new FormRainShrine(filepath);
                formRainShrine.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Rimuldar")
            {
                FormRimuldar formRimuldar = new FormRimuldar(filepath);
                formRimuldar.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Rock Mountain Cave - B1")
            {
                FormRockMountainCaveB1 formRockMountainCaveB1 = new FormRockMountainCaveB1(filepath);
                formRockMountainCaveB1.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Rock Mountain Cave - B2")
            {
                FormRockMountainCaveB2 formRockMountainCaveB2 = new FormRockMountainCaveB2(filepath);
                formRockMountainCaveB2.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Swamp Cave")
            {
                FormSwampCave formSwampCave = new FormSwampCave(filepath);
                formSwampCave.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Tantegel Castle")
            {
                FormTantegelCastle formTantegelCastle = new FormTantegelCastle(filepath);
                formTantegelCastle.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Tantegel Castle - Basement - Sunlight Shrine")
            {
                FormTantegelCastleBasement formTantegelCastleBasement = new FormTantegelCastleBasement(filepath);
                formTantegelCastleBasement.ShowDialog();
            }
            else if (comboBoxSelectMap.SelectedItem.ToString() == "Tantegel Castle - Throne Room")
            {
                FormTantegelCastleThroneRoom formTantegelCastleThroneRoom = new FormTantegelCastleThroneRoom(filepath);
                formTantegelCastleThroneRoom.ShowDialog();
            }
        }
    }
}
