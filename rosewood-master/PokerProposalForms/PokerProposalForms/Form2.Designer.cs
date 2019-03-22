namespace PokerProposalForms
{
    partial class Form2
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
            this.pokerType1 = new System.Windows.Forms.RadioButton();
            this.PokerGamesHeader = new System.Windows.Forms.Label();
            this.settingsHeader = new System.Windows.Forms.Label();
            this.pokerType2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.settingsMenubutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pokerType1
            // 
            this.pokerType1.AutoSize = true;
            this.pokerType1.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokerType1.Location = new System.Drawing.Point(59, 204);
            this.pokerType1.Name = "pokerType1";
            this.pokerType1.Size = new System.Drawing.Size(253, 45);
            this.pokerType1.TabIndex = 0;
            this.pokerType1.TabStop = true;
            this.pokerType1.Text = "Texas Hold\'em";
            this.pokerType1.UseVisualStyleBackColor = true;
            this.pokerType1.CheckedChanged += new System.EventHandler(this.pokerType1_CheckedChanged);
            // 
            // PokerGamesHeader
            // 
            this.PokerGamesHeader.AutoSize = true;
            this.PokerGamesHeader.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokerGamesHeader.Location = new System.Drawing.Point(47, 129);
            this.PokerGamesHeader.Name = "PokerGamesHeader";
            this.PokerGamesHeader.Size = new System.Drawing.Size(380, 61);
            this.PokerGamesHeader.TabIndex = 1;
            this.PokerGamesHeader.Text = "Poker Game Type";
            // 
            // settingsHeader
            // 
            this.settingsHeader.AutoSize = true;
            this.settingsHeader.Font = new System.Drawing.Font("Calibri", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsHeader.Location = new System.Drawing.Point(344, 9);
            this.settingsHeader.Name = "settingsHeader";
            this.settingsHeader.Size = new System.Drawing.Size(308, 101);
            this.settingsHeader.TabIndex = 2;
            this.settingsHeader.Text = "Settings";
            // 
            // pokerType2
            // 
            this.pokerType2.AutoSize = true;
            this.pokerType2.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokerType2.Location = new System.Drawing.Point(59, 263);
            this.pokerType2.Name = "pokerType2";
            this.pokerType2.Size = new System.Drawing.Size(155, 45);
            this.pokerType2.TabIndex = 3;
            this.pokerType2.TabStop = true;
            this.pokerType2.Text = "Omaha";
            this.pokerType2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 61);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Players";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(661, 204);
            this.comboBox1.MaxDropDownItems = 9;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 48);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "10";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // settingsMenubutton
            // 
            this.settingsMenubutton.Font = new System.Drawing.Font("Verdana", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsMenubutton.Location = new System.Drawing.Point(361, 330);
            this.settingsMenubutton.Name = "settingsMenubutton";
            this.settingsMenubutton.Size = new System.Drawing.Size(277, 57);
            this.settingsMenubutton.TabIndex = 7;
            this.settingsMenubutton.Text = "Back to Menu";
            this.settingsMenubutton.UseVisualStyleBackColor = true;
            this.settingsMenubutton.Click += new System.EventHandler(this.settingsMenubutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 453);
            this.Controls.Add(this.settingsMenubutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pokerType2);
            this.Controls.Add(this.settingsHeader);
            this.Controls.Add(this.PokerGamesHeader);
            this.Controls.Add(this.pokerType1);
            this.Name = "Form2";
            this.Text = "Poker Probability Calculator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton pokerType1;
        private System.Windows.Forms.Label PokerGamesHeader;
        private System.Windows.Forms.Label settingsHeader;
        private System.Windows.Forms.RadioButton pokerType2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button settingsMenubutton;

    }
}