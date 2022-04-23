using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGame
{
    public partial class Form1 : Form
    {
        int number;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            number = rnd.Next(0,11);
        }

        private void NumberEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text == number.ToString())
            {
                textBox1.Text = "You Win";
                button12.Visible = true;
            }
            else
            {
                textBox1.Text = "You Lose";
                button11.Visible = true;
            }
        }

        private void TryAgain(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random rnd = new Random();
            number = rnd.Next(0, 11);
            button11.Visible=false;
            button12.Visible=false;
        }
    }
}
