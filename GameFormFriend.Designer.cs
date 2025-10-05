namespace ConnectFour
{
    partial class GameFormFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFormFriend));
            panel1 = new Panel();
            label1 = new Label();
            labelTurn = new Label();
            panelTurnColor = new Panel();
            buttonHome = new Button();
            buttonHowtoPlay = new Button();
            buttonRestart = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelTurn);
            panel1.Controls.Add(panelTurnColor);
            panel1.Controls.Add(buttonHome);
            panel1.Controls.Add(buttonHowtoPlay);
            panel1.Controls.Add(buttonRestart);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(531, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 452);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 209);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 13;
            label1.Text = "Made by : \"Esraa Sayed\"";
            // 
            // labelTurn
            // 
            labelTurn.AutoSize = true;
            labelTurn.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTurn.ForeColor = Color.White;
            labelTurn.Location = new Point(56, 240);
            labelTurn.Name = "labelTurn";
            labelTurn.Size = new Size(100, 35);
            labelTurn.TabIndex = 12;
            labelTurn.Text = "Turn : ";
            // 
            // panelTurnColor
            // 
            panelTurnColor.BackColor = Color.Red;
            panelTurnColor.Location = new Point(162, 240);
            panelTurnColor.Name = "panelTurnColor";
            panelTurnColor.Size = new Size(42, 35);
            panelTurnColor.TabIndex = 11;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.White;
            buttonHome.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = Color.RoyalBlue;
            buttonHome.Location = new Point(26, 392);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(214, 45);
            buttonHome.TabIndex = 10;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonHowtoPlay
            // 
            buttonHowtoPlay.BackColor = Color.White;
            buttonHowtoPlay.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHowtoPlay.ForeColor = Color.RoyalBlue;
            buttonHowtoPlay.Location = new Point(26, 341);
            buttonHowtoPlay.Name = "buttonHowtoPlay";
            buttonHowtoPlay.Size = new Size(214, 45);
            buttonHowtoPlay.TabIndex = 9;
            buttonHowtoPlay.Text = "How to Play";
            buttonHowtoPlay.UseVisualStyleBackColor = false;
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.White;
            buttonRestart.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRestart.ForeColor = Color.RoyalBlue;
            buttonRestart.Location = new Point(26, 290);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(216, 45);
            buttonRestart.TabIndex = 8;
            buttonRestart.Text = "Restart";
            buttonRestart.UseVisualStyleBackColor = false;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // GameFormFriend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GameFormFriend";
            Text = "Connect 4";
            MouseClick += GameFormFriend_MouseClick;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Panel panel1;
        protected Label label1;
        protected Label labelTurn;
        protected Panel panelTurnColor;
        protected Button buttonHome;
        protected Button buttonHowtoPlay;
        protected Button buttonRestart;
        protected PictureBox pictureBox1;
    }
}