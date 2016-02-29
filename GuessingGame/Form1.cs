/// Description: The program generates a random number between 1-100 which
///              the use must guess
/// Author:      Mr. T

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        int rand = randNum.Next(1, 101);
        
        
        //create a list of ints to track user guesses
        public static List<int> userGuesses = new List<int>();

        public Form1()
        {
            InitializeComponent();
            label1.Text = Convert.ToString(rand);
            inputBox.MaxLength = 2;
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // get the users guess and place into a variable
            int guess = Convert.ToInt16(inputBox.Text);

            // add guess to your global list
            userGuesses.Add(guess);

            // check guess against the random value and output appropriate message
            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
            }
            else
            {
                outputLabel.Text = "You Got it!";

                ResultScreen rs = new ResultScreen();
                this.Controls.Add(rs);
                rs.BringToFront();
            }

            // clear out the input box 
            inputBox.Text = "";
        }
    }
}
