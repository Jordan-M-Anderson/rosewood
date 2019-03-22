namespace PokerProposalForms
{
    partial class Form1
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
            this.MainMenuHeader = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuHeader
            // 
            this.MainMenuHeader.AutoSize = true;
            this.MainMenuHeader.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenuHeader.Font = new System.Drawing.Font("Calibri", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuHeader.Location = new System.Drawing.Point(68, 52);
            this.MainMenuHeader.Name = "MainMenuHeader";
            this.MainMenuHeader.Size = new System.Drawing.Size(1089, 114);
            this.MainMenuHeader.TabIndex = 0;
            this.MainMenuHeader.Text = "Poker Probability Calculator";
            this.MainMenuHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startGame
            // 
            this.startGame.AutoSize = true;
            this.startGame.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(380, 230);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(461, 112);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Start";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.QuickPlay_Click);
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.Location = new System.Drawing.Point(380, 348);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(461, 112);
            this.settings.TabIndex = 2;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(380, 466);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(461, 112);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 712);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.MainMenuHeader);
            this.Name = "Form1";
            this.Text = "Poker Probability Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenuHeader;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button exit;
    }
}

