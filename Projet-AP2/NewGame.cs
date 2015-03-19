﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP2
{
    public partial class NewGame : Form
    {
        protected List<ComboBox> computersList;
        public NewGame()
        {
            InitializeComponent();
            this.computersList = new List<ComboBox>();
            this.computersList.Add(difficultyComputer1);
            this.computersList.Add(difficultyComputer2);
            this.computersList.Add(difficultyComputer3);
            this.computersList.Add(difficultyComputer4);
            this.difficultyComputer2.Enabled = false;
            this.difficultyComputer3.Enabled = false;
            this.difficultyComputer4.Enabled = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void playersNumber_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0, j = (int)this.playersNumber.Value; i < 4; i++)
            {
                this.computersList[i].Enabled = i < j;
            }
        }
    }
}
