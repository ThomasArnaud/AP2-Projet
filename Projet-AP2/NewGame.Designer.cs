namespace Projet_AP2
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playersNumber = new System.Windows.Forms.ComboBox();
            this.difficultyComputer1 = new System.Windows.Forms.ComboBox();
            this.difficultyComputer2 = new System.Windows.Forms.ComboBox();
            this.difficultyComputer3 = new System.Windows.Forms.ComboBox();
            this.difficultyComputer4 = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playersNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.difficultyComputer1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.difficultyComputer3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.difficultyComputer4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.difficultyComputer2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.playButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 165);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre d\'adversaires";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ordinateur 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ordinateur 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ordinateur 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ordinateur 4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playersNumber
            // 
            this.playersNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playersNumber.FormattingEnabled = true;
            this.playersNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.playersNumber.Location = new System.Drawing.Point(118, 3);
            this.playersNumber.Name = "playersNumber";
            this.playersNumber.Size = new System.Drawing.Size(32, 21);
            this.playersNumber.TabIndex = 5;
            this.playersNumber.SelectedIndexChanged += new System.EventHandler(this.playersNumber_SelectedIndexChanged);
            // 
            // difficultyComputer1
            // 
            this.difficultyComputer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyComputer1.FormattingEnabled = true;
            this.difficultyComputer1.Items.AddRange(new object[] {
            "facile",
            "moyen",
            "difficile"});
            this.difficultyComputer1.Location = new System.Drawing.Point(118, 28);
            this.difficultyComputer1.Name = "difficultyComputer1";
            this.difficultyComputer1.Size = new System.Drawing.Size(61, 21);
            this.difficultyComputer1.TabIndex = 6;
            // 
            // difficultyComputer2
            // 
            this.difficultyComputer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyComputer2.FormattingEnabled = true;
            this.difficultyComputer2.Items.AddRange(new object[] {
            "facile",
            "moyen",
            "difficile"});
            this.difficultyComputer2.Location = new System.Drawing.Point(118, 53);
            this.difficultyComputer2.Name = "difficultyComputer2";
            this.difficultyComputer2.Size = new System.Drawing.Size(61, 21);
            this.difficultyComputer2.TabIndex = 7;
            // 
            // difficultyComputer3
            // 
            this.difficultyComputer3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyComputer3.FormattingEnabled = true;
            this.difficultyComputer3.Items.AddRange(new object[] {
            "facile",
            "moyen",
            "difficile"});
            this.difficultyComputer3.Location = new System.Drawing.Point(118, 78);
            this.difficultyComputer3.Name = "difficultyComputer3";
            this.difficultyComputer3.Size = new System.Drawing.Size(61, 21);
            this.difficultyComputer3.TabIndex = 8;
            // 
            // difficultyComputer4
            // 
            this.difficultyComputer4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyComputer4.FormattingEnabled = true;
            this.difficultyComputer4.Items.AddRange(new object[] {
            "facile",
            "moyen",
            "difficile"});
            this.difficultyComputer4.Location = new System.Drawing.Point(118, 103);
            this.difficultyComputer4.Name = "difficultyComputer4";
            this.difficultyComputer4.Size = new System.Drawing.Size(61, 21);
            this.difficultyComputer4.TabIndex = 9;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(3, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(61, 21);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Location = new System.Drawing.Point(152, 141);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(61, 21);
            this.playButton.TabIndex = 11;
            this.playButton.Text = "Jouer";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // NewGame
            // 
            this.AcceptButton = this.playButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(240, 189);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox playersNumber;
        private System.Windows.Forms.ComboBox difficultyComputer1;
        private System.Windows.Forms.ComboBox difficultyComputer2;
        private System.Windows.Forms.ComboBox difficultyComputer3;
        private System.Windows.Forms.ComboBox difficultyComputer4;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button cancelButton;
    }
}