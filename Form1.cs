using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form : System.Windows.Forms.Form
    {
        Random randomNumber = new Random();

        int number = 0;
        int difference = 0;
        public Form()
        {
            InitializeComponent();
            startNewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startNewGame() {
            label1.Text = "I have a number between 1 and 1000. Can you guess my number? Enter your guess: ";
            resultText.Text = "Guess result appears here.";
            number = randomNumber.Next(1, 1000);
            textBox1.Enabled = true;
            textBox1.Text = "";
            difference = -1;
            this.BackColor = SystemColors.GrayText;
            label2.Text = number.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuessNumber(object sender, EventArgs e)
        {
            if (difference == -1)
            {

            }
            else
            {
                try
                {

                    int n = Convert.ToInt32(((TextBox)sender).Text);

                    if (n == number)
                    {
                        resultText.Text = "Correct!";
                        this.BackColor = SystemColors.GrayText;
                        textBox1.Enabled = false;

                    }
                    else if (number > n)
                    {
                        resultText.Text = "Too low.Try a higher number!";
                        if (number - n > difference)
                        {
                            this.BackColor = Color.IndianRed;
                        }
                        else
                        {
                            this.BackColor = SystemColors.MenuHighlight;
                        }
                    }
                    else if (number < n)
                    {
                        resultText.Text = "Too high.Try a lower number!";
                        if (n - number > difference)
                        {
                            this.BackColor = Color.IndianRed;
                        }
                        else
                        {
                            this.BackColor = SystemColors.MenuHighlight;
                        }
                    }
                }
                catch { }
            }
            try
            {
                int nn = Convert.ToInt32(((TextBox)sender).Text);
                if (number > nn)
                    difference = number - nn;
                else difference = nn - number;
                label2.Text = difference.ToString();
            }
            catch { }
        }
    }
}
