namespace ConnectFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timerProgress.Start();

        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
            }
            else
            {
                timerProgress.Stop();
                progressBar1.Visible = false;
                StartButton.Visible = true;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            panelStartPage.Visible = false;
            panelChooseGame.Visible = true;


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelChooseGame.Visible = false;

            GameFormFriend gameStart = new GameFormFriend(this);
            gameStart.TopLevel = false; 
            gameStart.FormBorderStyle = FormBorderStyle.None;
            gameStart.Dock = DockStyle.Fill;

            this.Controls.Add(gameStart);
            gameStart.Show();
        }

        private void labelChooseMode_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCompPlay_Click(object sender, EventArgs e)
        {
            panelChooseGame.Visible = false;

            GameFormComp gameStart = new GameFormComp(this);
            gameStart.TopLevel = false;
            gameStart.FormBorderStyle = FormBorderStyle.None;
            gameStart.Dock = DockStyle.Fill;

            this.Controls.Add(gameStart);
            gameStart.Show();
        }
    }
}
