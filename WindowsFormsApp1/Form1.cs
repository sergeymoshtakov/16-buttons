using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButtons();
        }

        private void CreateButtons()
        {
            Button[,] buttons = new Button[4,4];
            Random random = new Random();
            int buttonNumber = 1;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Text = "button " + buttonNumber;
                    buttons[i, j].Location = new Point(50 + i * 100, 50 + j * 40);
                    buttons[i, j].Click += Button_Click;
                    Controls.Add(buttons[i, j]);
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    buttons[i, j].BackColor = randomColor;
                    buttonNumber++;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Visible = false;
        }
    }
}
