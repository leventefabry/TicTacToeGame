using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int _maxButton = 9;
        private bool _changeUser;
        private List<string> _xList = new List<string>();
        private List<string> _oList = new List<string>();
        private int _xWin = 0;
        private int _oWin = 0;
        private int _draw = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = NewGameBtn.Top;
            int left = NewGameBtn.Right + 20;
            int size = 100;

            for (int i = 0; i < _maxButton; i++)
            {
                var b = new Button();
                Controls.Add(b);
                b.Name = i.ToString();
                b.Top = top;
                b.Left = left;
                b.Width = size;
                b.Height = size;
                //b.ForeColor = Color.Black;
                b.Font = new Font(FontFamily.GenericSansSerif, 30f, FontStyle.Bold);
                b.Click += GameButton_click;

                if ((i + 1) % 3 == 0)
                {
                    left = NewGameBtn.Right + 20;
                    top += size + 20;
                }
                else
                {
                    left += size + 20;
                }
            }
        }

        private void NewGame()
        {
            ButtonEnable(true);
            foreach (Control item in Controls)
            {
                if ((item is Button) && item.Name != "NewGameBtn")
                {
                    item.Text = "";
                }
            }
            _xList.Clear();
            _oList.Clear();
        }

        private void ButtonEnable(bool boolean)
        {
            foreach (Control item in Controls)
            {
                if ((item is Button) && item.Name != "NewGameBtn")
                {
                    item.Enabled = boolean;
                }
            }
        }

        private void HighScore()
        {
            OLabelCount.Text = _oWin.ToString();
            XLabelCount.Text = _xWin.ToString();
            DrawLabelCount.Text = _draw.ToString();
        }

        private bool Win(List<string> list)
        {
            //vertical
            if (list.Contains("0") && list.Contains("1") && list.Contains("2"))
            {
                return true;
            }
            else if (list.Contains("3") && list.Contains("4") && list.Contains("5"))
            {
                return true;
            }
            else if (list.Contains("6") && list.Contains("7") && list.Contains("8"))
            {
                return true;
            }

            //horizontal
            else if (list.Contains("0") && list.Contains("3") && list.Contains("6"))
            {
                return true;
            }
            else if (list.Contains("1") && list.Contains("4") && list.Contains("7"))
            {
                return true;
            }
            else if (list.Contains("2") && list.Contains("5") && list.Contains("8"))
            {
                return true;
            }

            //diagonal
            else if (list.Contains("0") && list.Contains("4") && list.Contains("8"))
            {
                return true;
            }
            else if (list.Contains("2") && list.Contains("4") && list.Contains("6"))
            {
                return true;
            }

            return false;
        }

        private int NumberOfClickedButtons()
        {
            int buttonNumbers = 0;

            foreach (Control item in Controls)
            {
                if (item is Button && item.Enabled == false)
                {
                    buttonNumbers++;
                }
            }

            return buttonNumbers;
        }

        private void GameButton_click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (!_changeUser)
                {
                    (sender as Button).Text = "X";
                    (sender as Button).Enabled = false;
                    _changeUser = true;
                    _xList.Add((sender as Button).Name);
                }
                else
                {
                    (sender as Button).Text = "O";
                    (sender as Button).Enabled = false;
                    _changeUser = false;
                    _oList.Add((sender as Button).Name);
                }

                if (Win(_xList))
                {
                    MessageBox.Show("X Win!");
                    ButtonEnable(false);
                    _xWin++;

                }
                else if (Win(_oList))
                {
                    MessageBox.Show("O Win!");
                    ButtonEnable(false);
                    _oWin++;
                }
                else if (NumberOfClickedButtons() == 9)
                {
                    MessageBox.Show("Draw");
                    _draw++;
                }
                HighScore();
            }
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
