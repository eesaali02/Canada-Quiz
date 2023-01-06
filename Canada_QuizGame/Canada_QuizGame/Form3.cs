using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canada_QuizGame
{
    public partial class Form3 : Form
    {
        public Form3(int points, string name)
        {
            InitializeComponent();
            string player = name;
            int score = points;

            lblMessage.Text = $"{player}, You scored {score} points!";

        }
    }
}
