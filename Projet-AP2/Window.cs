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
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void jeuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stupideVautourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame d = new NewGame();
            d.ShowDialog();

        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            Button cardButton = (Button)sender;
            //Determiner le numéro de la carte  et appel à play à faire
            cardButton.Visible = false;
        }
    }
}
