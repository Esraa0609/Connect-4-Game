using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ConnectFour
{
    public partial class GameFormFriend : Form
    {
        protected Rectangle[] boardColumns;
        protected int[,] board;
        protected int turn;

        //Board Draw
        protected int rows;
        protected int cols;
        protected int boardX;
        protected int boardY;
        protected int boardWidth;
        protected int boardHeight;
        protected int cellWidth;
        protected int cellHeight;
        protected int discSize;

        protected Form1 parentForm;
        public GameFormFriend()
        {
            InitializeComponent();

        }
        public GameFormFriend(Form1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;

            //Board Draw
            this.rows = 6;
            this.cols = 7;
            this.boardColumns = new Rectangle[cols];
            this.board = new int[rows, cols];
            this.boardX = 0;
            this.boardY = 0;
            this.boardWidth = (ClientRectangle.Width * 2) / 3;
            this.boardHeight = ClientRectangle.Height - boardY;
            this.cellWidth = boardWidth / cols;
            this.cellHeight = boardHeight / rows;
            this.discSize = Math.Min(cellWidth, cellHeight) - 8; // padding

            this.turn = 1;
            this.Paint += this.GameFormFriend_Paint;
            this.parentForm = parentForm;
        }
        protected void GameFormFriend_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillRectangle(Brushes.Blue, this.boardX, this.boardY, this.boardWidth, this.boardHeight);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0)
                        this.boardColumns[j] = new Rectangle(this.boardX + j * this.cellWidth, this.boardY, this.cellWidth, this.boardHeight);

                    int x = this.boardX + j * this.cellWidth + (this.cellWidth - this.discSize) / 2;
                    int y = this.boardY + i * this.cellHeight + (this.cellHeight - this.discSize) / 2;
                    e.Graphics.FillEllipse(Brushes.White, x, y, this.discSize, this.discSize);
                }
            }

        }
        protected virtual void GameFormFriend_MouseClick(object sender, MouseEventArgs e)
        {
            int colIndx = this.ColNumber(e.Location);
            if (colIndx != -1)
            {
                int rowIndx = this.rowNumber(colIndx);
                if (rowIndx != -1)
                {
                    this.board[rowIndx, colIndx] = this.turn;
                    if (this.turn == 1)
                    {
                        Graphics g = this.CreateGraphics();
                        int x = this.boardX + colIndx * this.cellWidth + (this.cellWidth - this.discSize) / 2;
                        int y = this.boardY + rowIndx * this.cellHeight + (this.cellHeight - this.discSize) / 2;
                        g.FillEllipse(Brushes.Red, x, y, this.discSize, this.discSize);
                    }
                    else
                    {
                        Graphics g = this.CreateGraphics();
                        int x = this.boardX + colIndx * this.cellWidth + (this.cellWidth - this.discSize) / 2;
                        int y = this.boardY + rowIndx * this.cellHeight + (this.cellHeight - this.discSize) / 2;
                        g.FillEllipse(Brushes.Yellow, x, y, this.discSize, this.discSize);
                    }

                    int win = this.Winner(this.turn);
                    if (win != -1)
                    {
                        string player = (win == 1) ? "Red" : "Yellow";
                        MessageBox.Show("Congratulations! " + player + " player has won!");
                        panelTurnColor.BackColor = Color.Red;
                        buttonRestart_Click(sender, e);
                    }

                    if (this.turn == 1)
                    {
                        this.turn = 2;
                        panelTurnColor.BackColor = Color.Yellow;
                    }
                    else
                    {
                        this.turn = 1;
                        panelTurnColor.BackColor = Color.Red;

                    }
                }
            }

        }

        protected int ColNumber(Point mouse)
        {
            for (int i = 0; i < this.boardColumns.Length; i++)
            {
                if ((mouse.X >= this.boardColumns[i].X) && (mouse.Y >= this.boardColumns[i].Y))
                {
                    if ((mouse.X <= this.boardColumns[i].X + this.boardColumns[i].Width) && (mouse.Y <= this.boardColumns[i].Y + this.boardColumns[i].Height))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        protected int rowNumber(int col)
        {
            for (int i = 5; i >= 0; i--)
            {
                if (this.board[i, col] == 0)
                    return i;
            }
            return -1;
        }

        protected int Winner(int player)
        {
            //vertical chaeck
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.board.GetLength(1); col++)
                {
                    if (CheckEqaul(player, this.board[row, col], this.board[row + 1, col], this.board[row + 2, col], this.board[row + 3, col]))
                        return player;
                }
            }

            //horizontal check
            for (int row = 0; row < this.board.GetLength(0); row++)
            {
                for (int col = 0; col < this.board.GetLength(1) - 3; col++)
                {
                    if (CheckEqaul(player, this.board[row, col], this.board[row, col + 1], this.board[row, col + 2], this.board[row, col + 3]))
                        return player;
                }
            }

            //top left diagonal check
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.board.GetLength(1) - 3; col++)
                {
                    if (CheckEqaul(player, this.board[row, col], this.board[row + 1, col + 1], this.board[row + 2, col + 2], this.board[row + 3, col + 3]))
                        return player;
                }
            }

            //top right diagonal check
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 3; col < this.board.GetLength(1); col++)
                {
                    if (CheckEqaul(player, this.board[row, col], this.board[row + 1, col - 1], this.board[row + 2, col - 2], this.board[row + 3, col - 3]))
                        return player;
                }
            }

            return -1;
        }
        protected bool CheckEqaul(int x, params int[] num)
        {
            foreach (int n in num)
            {
                if (n != x)
                { return false; }
            }
            return true;
        }

        protected void buttonRestart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    this.board[i, j] = 0;
                }
            }
            this.turn = 1;
            this.panelTurnColor.BackColor = Color.Red;
            this.Invalidate();
        }

        protected void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show(); 
            parentForm.panelChooseGame.Visible = true; 
        }
    }
}
