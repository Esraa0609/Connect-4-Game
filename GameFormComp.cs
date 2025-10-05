using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class GameFormComp : GameFormFriend
    {
        public GameFormComp() : base()
        {
            InitializeComponent();
        }
        public GameFormComp(Form1 parent) : base(parent)
        {
            InitializeComponent();

        }
        protected override void GameFormFriend_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.turn == 1)
            {
                base.GameFormFriend_MouseClick(sender, e);
                if (this.turn == 2)
                {
                    timerComputerPlay.Start();
                }
            }
        }
        private void ComputerMove()
        {
            // 1. Check if computer can win
            for (int c = 0; c < cols; c++)
            {
                int r = rowNumber(c);
                if (r != -1)
                {
                    board[r, c] = 2;
                    if (Winner(2) == 2)
                    {
                        PlaceDisc(r, c, Brushes.Yellow);
                        return;
                    }
                    board[r, c] = 0;
                }
            }

            // 2. Block if player could win next
            for (int c = 0; c < cols; c++)
            {
                int r = rowNumber(c);
                if (r != -1)
                {
                    board[r, c] = 1;
                    if (Winner(1) == 1)
                    {
                        board[r, c] = 2;
                        PlaceDisc(r, c, Brushes.Yellow);
                        return;
                    }
                    board[r, c] = 0;
                }
            }

            // 3. choose best column 
            int[] order = { 3, 2, 4, 1, 5, 0, 6 };
            foreach (int c in order)
            {
                int r = rowNumber(c);
                if (r != -1)
                {
                    board[r, c] = 2;
                    PlaceDisc(r, c, Brushes.Yellow);
                    return;
                }
            }
        }
        private void PlaceDisc(int row, int col, Brush brush)
        {
            Graphics g = this.CreateGraphics();
            int x = this.boardX + col * this.cellWidth + (this.cellWidth - this.discSize) / 2;
            int y = this.boardY + row * this.cellHeight + (this.cellHeight - this.discSize) / 2;

            g.FillEllipse(brush, x, y, this.discSize, this.discSize);

            int win = this.Winner(this.turn);
            if (win != -1)
            {
                string player = (win == 1) ? "Red" : "Yellow";
                MessageBox.Show("Congratulations! " + player + " player has won!");
                buttonRestart_Click(null, null);
                return;
            }

            this.turn = 1;
            panelTurnColor.BackColor = Color.Red;
        }

        private void timerComputerPlay_Tick(object sender, EventArgs e)
        {
            timerComputerPlay.Stop(); 
            ComputerMove();
        }
    }
}
