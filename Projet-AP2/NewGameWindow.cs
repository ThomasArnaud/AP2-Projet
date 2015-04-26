using System;
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
    public partial class NewGameWindow : Form
    {
        protected List<ComboBox> computersList;

        public NewGameWindow()
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
            if (this.playerName.Text.Length == 0)
            {
                return;
            }

            for (int i = 0; i < computersList.Count; i++)
            {
                if (computersList[i].Enabled == true && computersList[i].SelectedIndex == -1)
                {
                    return;
                }
            }
                

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
            for (int i = 0, j = (int)this.opponentsNumber.Value; i < 4; i++)
            {
                this.computersList[i].Enabled = i < j;
            }
        }

        public String PlayerName
        {
            get
            {
                return this.playerName.Text;
            }
        }

        public Byte OpponentsNumber
        {
            get
            {
                return (Byte) this.opponentsNumber.Value;
            }
        }

        public Byte GetOpponentDifficulty(Byte opponentNumber)
        {
            if(opponentNumber >= 1 && opponentNumber <= (Byte) this.opponentsNumber.Value)
            {
                switch(opponentNumber)
                {
                    case 1:
                        return (Byte)(this.difficultyComputer1.SelectedIndex + 1);

                    case 2:
                        return (Byte)(this.difficultyComputer2.SelectedIndex + 1);

                    case 3:
                        return (Byte)(this.difficultyComputer3.SelectedIndex + 1);

                    case 4:
                        return (Byte)(this.difficultyComputer4.SelectedIndex + 1);
                }
            }

            return 0;
        }
    }
}
