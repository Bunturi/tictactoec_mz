using Microsoft.VisualBasic.Devices;

namespace tictactoe
{
  
    public partial class Form1 : Form
    {
        int turn = 1;
        int click1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("button"))
                {
                    btn.Click += click_event;
                }
            }
        }

        private void click_event(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null && btn.Text == "")
            {
                btn.Text = turn % 2 != 0 ? "X" : "O";
                turn++;
                display();
                checkit();
            }
        }

        public void display()
        {
            if (turn % 2 != 0)
            {
                displayturn.Text = "Player 1";
            }
            else
            {
                displayturn.Text = "Player 2";
            }
        }

        public void checkit()
        {
            string[,] board = new string[3, 3]
            {
        { button1.Text, button2.Text, button3.Text },
        { button4.Text, button5.Text, button6.Text },
        { button7.Text, button8.Text, button9.Text }
            };

            for (int i = 0; i < 3; i++)
            {
                
                if (board[i, 0] != "" && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    HighlightWin(new[] { $"button{i * 3 + 1}", $"button{i * 3 + 2}", $"button{i * 3 + 3}" });
                    return;
                }

                
                if (board[0, i] != "" && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    HighlightWin(new[] { $"button{1 + i}", $"button{4 + i}", $"button{7 + i}" });
                    return;
                }
            }

            
            if (board[0, 0] != "" && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                HighlightWin(new[] { "button1", "button5", "button9" });
                return;
            }

            if (board[0, 2] != "" && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                HighlightWin(new[] { "button3", "button5", "button7" });
                return;
            }
        }

        private void HighlightWin(string[] buttons)
        {
            foreach (string btnName in buttons)
            {
                Button btn = this.Controls[btnName] as Button;
                if (btn != null)
                {
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.White;
                }
            }

            string winner = turn % 2 == 0 ? "Player 1" : "Player 2";
            MessageBox.Show($"{winner} Wins!");
            cleargame();
        }

        public void cleargame()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("button"))
                {
                    btn.Text = "";
                    btn.BackColor = DefaultBackColor;
                    btn.ForeColor = DefaultForeColor;
                }
            }
            turn = 1;
            display();
        }


    }
}
