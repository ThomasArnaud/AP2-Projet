namespace Projet_AP2
{
    partial class Window
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stupidVultureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.playerNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.scoreLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.card1Button = new System.Windows.Forms.Button();
            this.card2Button = new System.Windows.Forms.Button();
            this.card3Button = new System.Windows.Forms.Button();
            this.card4Button = new System.Windows.Forms.Button();
            this.card5Button = new System.Windows.Forms.Button();
            this.card6Button = new System.Windows.Forms.Button();
            this.card7Button = new System.Windows.Forms.Button();
            this.card8Button = new System.Windows.Forms.Button();
            this.card9Button = new System.Windows.Forms.Button();
            this.card10Button = new System.Windows.Forms.Button();
            this.card11Button = new System.Windows.Forms.Button();
            this.card12Button = new System.Windows.Forms.Button();
            this.card13Button = new System.Windows.Forms.Button();
            this.card14Button = new System.Windows.Forms.Button();
            this.card15Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stupidVultureToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.gameToolStripMenuItem.Text = "Partie";
            // 
            // stupidVultureToolStripMenuItem
            // 
            this.stupidVultureToolStripMenuItem.Name = "stupidVultureToolStripMenuItem";
            this.stupidVultureToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.stupidVultureToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.stupidVultureToolStripMenuItem.Text = "Nouvelle partie";
            this.stupidVultureToolStripMenuItem.Click += new System.EventHandler(this.stupidVultureToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Enabled = false;
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Enabled = false;
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Enabled = false;
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerNameLabel,
            this.toolStripStatusLabel1,
            this.scoreLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(59, 17);
            this.playerNameLabel.Text = "Anonyme";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "| Score :";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 17);
            this.scoreLabel.Text = "0";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(760, 439);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // card1Button
            // 
            this.card1Button.Location = new System.Drawing.Point(28, 472);
            this.card1Button.Margin = new System.Windows.Forms.Padding(0);
            this.card1Button.Name = "card1Button";
            this.card1Button.Size = new System.Drawing.Size(30, 60);
            this.card1Button.TabIndex = 3;
            this.card1Button.Text = "1";
            this.card1Button.UseVisualStyleBackColor = true;
            this.card1Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card2Button
            // 
            this.card2Button.Location = new System.Drawing.Point(78, 472);
            this.card2Button.Margin = new System.Windows.Forms.Padding(0);
            this.card2Button.Name = "card2Button";
            this.card2Button.Size = new System.Drawing.Size(30, 60);
            this.card2Button.TabIndex = 4;
            this.card2Button.Text = "2";
            this.card2Button.UseVisualStyleBackColor = true;
            this.card2Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card3Button
            // 
            this.card3Button.Location = new System.Drawing.Point(128, 472);
            this.card3Button.Margin = new System.Windows.Forms.Padding(0);
            this.card3Button.Name = "card3Button";
            this.card3Button.Size = new System.Drawing.Size(30, 60);
            this.card3Button.TabIndex = 5;
            this.card3Button.Text = "3";
            this.card3Button.UseVisualStyleBackColor = true;
            this.card3Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card4Button
            // 
            this.card4Button.Location = new System.Drawing.Point(178, 472);
            this.card4Button.Margin = new System.Windows.Forms.Padding(0);
            this.card4Button.Name = "card4Button";
            this.card4Button.Size = new System.Drawing.Size(30, 60);
            this.card4Button.TabIndex = 6;
            this.card4Button.Text = "4";
            this.card4Button.UseVisualStyleBackColor = true;
            this.card4Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card5Button
            // 
            this.card5Button.Location = new System.Drawing.Point(228, 472);
            this.card5Button.Margin = new System.Windows.Forms.Padding(0);
            this.card5Button.Name = "card5Button";
            this.card5Button.Size = new System.Drawing.Size(30, 60);
            this.card5Button.TabIndex = 7;
            this.card5Button.Text = "5";
            this.card5Button.UseVisualStyleBackColor = true;
            this.card5Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card6Button
            // 
            this.card6Button.Location = new System.Drawing.Point(278, 472);
            this.card6Button.Margin = new System.Windows.Forms.Padding(0);
            this.card6Button.Name = "card6Button";
            this.card6Button.Size = new System.Drawing.Size(30, 60);
            this.card6Button.TabIndex = 8;
            this.card6Button.Text = "6";
            this.card6Button.UseVisualStyleBackColor = true;
            this.card6Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card7Button
            // 
            this.card7Button.Location = new System.Drawing.Point(328, 472);
            this.card7Button.Margin = new System.Windows.Forms.Padding(0);
            this.card7Button.Name = "card7Button";
            this.card7Button.Size = new System.Drawing.Size(30, 60);
            this.card7Button.TabIndex = 9;
            this.card7Button.Text = "7";
            this.card7Button.UseVisualStyleBackColor = true;
            this.card7Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card8Button
            // 
            this.card8Button.Location = new System.Drawing.Point(378, 472);
            this.card8Button.Name = "card8Button";
            this.card8Button.Size = new System.Drawing.Size(30, 60);
            this.card8Button.TabIndex = 10;
            this.card8Button.Text = "8";
            this.card8Button.UseVisualStyleBackColor = true;
            this.card8Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card9Button
            // 
            this.card9Button.Location = new System.Drawing.Point(428, 472);
            this.card9Button.Name = "card9Button";
            this.card9Button.Size = new System.Drawing.Size(30, 60);
            this.card9Button.TabIndex = 11;
            this.card9Button.Text = "9";
            this.card9Button.UseVisualStyleBackColor = true;
            this.card9Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card10Button
            // 
            this.card10Button.Location = new System.Drawing.Point(478, 472);
            this.card10Button.Name = "card10Button";
            this.card10Button.Size = new System.Drawing.Size(30, 60);
            this.card10Button.TabIndex = 12;
            this.card10Button.Text = "10";
            this.card10Button.UseVisualStyleBackColor = true;
            this.card10Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card11Button
            // 
            this.card11Button.Location = new System.Drawing.Point(528, 472);
            this.card11Button.Name = "card11Button";
            this.card11Button.Size = new System.Drawing.Size(30, 60);
            this.card11Button.TabIndex = 13;
            this.card11Button.Text = "11";
            this.card11Button.UseVisualStyleBackColor = true;
            this.card11Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card12Button
            // 
            this.card12Button.Location = new System.Drawing.Point(578, 472);
            this.card12Button.Name = "card12Button";
            this.card12Button.Size = new System.Drawing.Size(30, 60);
            this.card12Button.TabIndex = 14;
            this.card12Button.Text = "12";
            this.card12Button.UseVisualStyleBackColor = true;
            this.card12Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card13Button
            // 
            this.card13Button.Location = new System.Drawing.Point(628, 472);
            this.card13Button.Name = "card13Button";
            this.card13Button.Size = new System.Drawing.Size(30, 60);
            this.card13Button.TabIndex = 15;
            this.card13Button.Text = "13";
            this.card13Button.UseVisualStyleBackColor = true;
            this.card13Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card14Button
            // 
            this.card14Button.Location = new System.Drawing.Point(678, 472);
            this.card14Button.Name = "card14Button";
            this.card14Button.Size = new System.Drawing.Size(30, 60);
            this.card14Button.TabIndex = 16;
            this.card14Button.Text = "14";
            this.card14Button.UseVisualStyleBackColor = true;
            this.card14Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // card15Button
            // 
            this.card15Button.Location = new System.Drawing.Point(728, 472);
            this.card15Button.Margin = new System.Windows.Forms.Padding(0);
            this.card15Button.Name = "card15Button";
            this.card15Button.Size = new System.Drawing.Size(30, 60);
            this.card15Button.TabIndex = 17;
            this.card15Button.Text = "15";
            this.card15Button.UseVisualStyleBackColor = true;
            this.card15Button.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.card15Button);
            this.Controls.Add(this.card14Button);
            this.Controls.Add(this.card13Button);
            this.Controls.Add(this.card12Button);
            this.Controls.Add(this.card11Button);
            this.Controls.Add(this.card10Button);
            this.Controls.Add(this.card9Button);
            this.Controls.Add(this.card8Button);
            this.Controls.Add(this.card7Button);
            this.Controls.Add(this.card6Button);
            this.Controls.Add(this.card5Button);
            this.Controls.Add(this.card4Button);
            this.Controls.Add(this.card3Button);
            this.Controls.Add(this.card2Button);
            this.Controls.Add(this.card1Button);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Window";
            this.Text = "Stupide Vautour";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stupidVultureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button card1Button;
        private System.Windows.Forms.Button card2Button;
        private System.Windows.Forms.Button card3Button;
        private System.Windows.Forms.Button card4Button;
        private System.Windows.Forms.Button card5Button;
        private System.Windows.Forms.Button card6Button;
        private System.Windows.Forms.Button card7Button;
        private System.Windows.Forms.Button card8Button;
        private System.Windows.Forms.Button card9Button;
        private System.Windows.Forms.Button card10Button;
        private System.Windows.Forms.Button card11Button;
        private System.Windows.Forms.Button card12Button;
        private System.Windows.Forms.Button card13Button;
        private System.Windows.Forms.Button card14Button;
        private System.Windows.Forms.Button card15Button;
        private System.Windows.Forms.ToolStripStatusLabel playerNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel scoreLabel;
    }
}

