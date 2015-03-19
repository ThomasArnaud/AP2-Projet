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
            this.tableLayoutPanel1.Controls.Add(this.difficultyComputer2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.difficultyComputer3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.difficultyComputer4, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre d\'adversaires";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ordinateur 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ordinateur 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ordinateur 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ordinateur 4";
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
            this.playersNumber.Size = new System.Drawing.Size(33, 21);
            this.playersNumber.TabIndex = 5;
            // 
            // difficultyComputer1
            // 
            this.difficultyComputer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyComputer1.FormattingEnabled = true;
            this.difficultyComputer1.Items.AddRange(new object[] {
            "facile",
            "moyen",
            "difficile"});
            this.difficultyComputer1.Location = new System.Drawing.Point(118, 18);
            this.difficultyComputer1.Name = "difficultyComputer1";
            this.difficultyComputer1.Size = new System.Drawing.Size(51, 21);
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
            this.difficultyComputer2.Location = new System.Drawing.Point(118, 242);
            this.difficultyComputer2.Name = "difficultyComputer2";
            this.difficultyComputer2.Size = new System.Drawing.Size(40, 21);
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
            this.difficultyComputer3.Location = new System.Drawing.Point(118, 270);
            this.difficultyComputer3.Name = "difficultyComputer3";
            this.difficultyComputer3.Size = new System.Drawing.Size(32, 21);
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
            this.difficultyComputer4.Location = new System.Drawing.Point(118, 290);
            this.difficultyComputer4.Name = "difficultyComputer4";
            this.difficultyComputer4.Size = new System.Drawing.Size(28, 21);
            this.difficultyComputer4.TabIndex = 9;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 351);
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
    }
}