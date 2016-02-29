using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class ResultScreen : UserControl
    {
        public ResultScreen()
        {
            InitializeComponent();
        }

        private void ResultScreen_Load(object sender, EventArgs e)
        {
            //Number of Gusses
            numberofGuesses.Text += Convert.ToString(Form1.userGuesses.Count);

            //Original Order
            for (int x = 0; x < Form1.userGuesses.Count; x++)
            {
                originalOrder.Text += " " + Convert.ToString(Form1.userGuesses[x]);
            }

            //Sorted Order
            Form1.userGuesses.Sort();
            for (int x = 0; x < Form1.userGuesses.Count; x++)
            {
                sortedOrder.Text += " " + Convert.ToString(Form1.userGuesses[x]);
            }
        }
    }
}
