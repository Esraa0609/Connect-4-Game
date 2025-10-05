namespace ConnectFour
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timerProgress = new System.Windows.Forms.Timer(components);
            panelStartPage = new Panel();
            label1 = new Label();
            StartButton = new Button();
            GameMainPicture = new PictureBox();
            progressBar1 = new ProgressBar();
            labelChooseMode = new Label();
            buttonCompPlay = new Button();
            buttonFriendPlay = new Button();
            panelChooseGame = new Panel();
            panelStartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GameMainPicture).BeginInit();
            panelChooseGame.SuspendLayout();
            SuspendLayout();
            // 
            // timerProgress
            // 
            timerProgress.Interval = 50;
            timerProgress.Tick += timerProgress_Tick;
            // 
            // panelStartPage
            // 
            panelStartPage.Controls.Add(label1);
            panelStartPage.Controls.Add(StartButton);
            panelStartPage.Controls.Add(GameMainPicture);
            panelStartPage.Controls.Add(progressBar1);
            panelStartPage.Dock = DockStyle.Fill;
            panelStartPage.Location = new Point(0, 0);
            panelStartPage.Name = "panelStartPage";
            panelStartPage.Size = new Size(800, 450);
            panelStartPage.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 428);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 19;
            label1.Text = "© 2025 Esraa Sayed. ";
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.Gainsboro;
            StartButton.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartButton.ForeColor = SystemColors.HotTrack;
            StartButton.Location = new Point(322, 338);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(145, 45);
            StartButton.TabIndex = 18;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Visible = false;
            StartButton.Click += StartButton_Click;
            // 
            // GameMainPicture
            // 
            GameMainPicture.Image = Properties.Resources.apps_41929_13910108538401625_dfad4587_dfb3_4aa4_8bed_b5d2dd8fc79f_removebg_preview__1_;
            GameMainPicture.Location = new Point(216, 29);
            GameMainPicture.Name = "GameMainPicture";
            GameMainPicture.Size = new Size(357, 299);
            GameMainPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            GameMainPicture.TabIndex = 17;
            GameMainPicture.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Blue;
            progressBar1.Location = new Point(241, 351);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(309, 5);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 16;
            // 
            // labelChooseMode
            // 
            labelChooseMode.AutoSize = true;
            labelChooseMode.Font = new Font("Algerian", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelChooseMode.ForeColor = SystemColors.ButtonHighlight;
            labelChooseMode.Location = new Point(159, 63);
            labelChooseMode.Name = "labelChooseMode";
            labelChooseMode.Size = new Size(480, 54);
            labelChooseMode.TabIndex = 0;
            labelChooseMode.Text = "Choose Game Mode";
            labelChooseMode.Click += labelChooseMode_Click;
            // 
            // buttonCompPlay
            // 
            buttonCompPlay.BackColor = Color.White;
            buttonCompPlay.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCompPlay.ForeColor = Color.DarkRed;
            buttonCompPlay.Location = new Point(216, 170);
            buttonCompPlay.Name = "buttonCompPlay";
            buttonCompPlay.Size = new Size(372, 84);
            buttonCompPlay.TabIndex = 1;
            buttonCompPlay.Text = "Play with a Computer";
            buttonCompPlay.UseVisualStyleBackColor = false;
            buttonCompPlay.Click += buttonCompPlay_Click;
            // 
            // buttonFriendPlay
            // 
            buttonFriendPlay.BackColor = Color.White;
            buttonFriendPlay.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFriendPlay.ForeColor = Color.DarkRed;
            buttonFriendPlay.Location = new Point(216, 272);
            buttonFriendPlay.Name = "buttonFriendPlay";
            buttonFriendPlay.Size = new Size(372, 84);
            buttonFriendPlay.TabIndex = 2;
            buttonFriendPlay.Text = "Play with a Friend";
            buttonFriendPlay.UseVisualStyleBackColor = false;
            buttonFriendPlay.Click += button2_Click;
            // 
            // panelChooseGame
            // 
            panelChooseGame.BackColor = Color.RoyalBlue;
            panelChooseGame.Controls.Add(buttonFriendPlay);
            panelChooseGame.Controls.Add(buttonCompPlay);
            panelChooseGame.Controls.Add(labelChooseMode);
            panelChooseGame.Dock = DockStyle.Fill;
            panelChooseGame.Location = new Point(0, 0);
            panelChooseGame.Name = "panelChooseGame";
            panelChooseGame.Size = new Size(800, 450);
            panelChooseGame.TabIndex = 21;
            panelChooseGame.Visible = false;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panelChooseGame);
            Controls.Add(panelStartPage);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connect 4";
            panelStartPage.ResumeLayout(false);
            panelStartPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GameMainPicture).EndInit();
            panelChooseGame.ResumeLayout(false);
            panelChooseGame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerProgress;
        private Panel panelStartPage;
        private Label label1;
        private Button StartButton;
        private PictureBox GameMainPicture;
        private ProgressBar progressBar1;
        private Label labelChooseMode;
        private Button buttonCompPlay;
        private Button buttonFriendPlay;
        public Panel panelChooseGame;
    }
}
