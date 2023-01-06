using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Canada_QuizGame
{
    public partial class Form2 : Form
    {
        int answer;
        int questionNumber = 1;
        int score = 0;
        int totalQuestions = 7;
        int ticks = 60;

        MCQ q1 = new MCQ("What is the Capital City of Canada?", 3, "Location of Carleton University", "Toronto", "Montreal", "Ottawa", "Vancouver");
        MCQ q2 = new MCQ("Who is the current Prime Minister of Canada?", 1, "He is serving his second consecutive term", "Justin Trudeau", "Pierre Trudeau", "Stephen Harper", "Brian Mulroney");
        MCQ q3 = new MCQ("Which is the biggest of the Canadian Provinces?", 2, "They mainly speak French.", "Saskatchewan", "Quebec", "Ontario", "B.C");
        MCQ q4 = new MCQ("Which Canadian Province has the greatest population?", 4, "They have a great lake named after them", "Quebec", "B.C", "Alberta", "Ontario");
        MCQ q5 = new MCQ("Which is Canada’s longest river?", 3, "Sounds like a girls name", "St. Lawrence River", "Ottawa River", "Mackenzie River", "Yukon River");
        MCQ q6 = new MCQ("When does Canada celebrate its national day?", 3, "Same month and US Independance Day", "June 1", "July 4", "July 1", "June 4");
        MCQ q7 = new MCQ("What is the capital of Saskatchewan?", 1, "Second Largest City in Saskatchewan", "Regina", "Saskatoon", "Edmonton", "Moose Jaw");

        MCQ[] Questions = new MCQ[7];
        

        public Form2(string name)
        {
            InitializeComponent();
            lblTimer.Text = "";
            btnOption1.Text = "";
            btnOption2.Text = "";
            btnOption3.Text = "";
            btnOption4.Text = "";
            lblQuestion.Text = "";
            lblHint.Text = "";
            lblPlayerName.Text = name;

            Questions = QuestionsManager.QuestionsRandomizer(q1, q2, q3, q4, q5, q6, q7);

            AskQuestion(questionNumber);
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblQ5points_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            btnOption1.Visible = true;
            btnOption2.Visible = true;
            btnOption3.Visible = true;
            btnOption4.Visible = true;
            lblHint.Text = "";

            var senderObject = (Button)sender;

            int button = Convert.ToInt32(senderObject.Tag);

            if(button == answer)
            {
                MessageBox.Show("Congratulations!");
                if(questionNumber == 1)
                {
                    lblQ1points.Text = "100";
                    score += 100;
                }
                if (questionNumber == 2)
                {
                    lblQ2points.Text = "200";
                    score += 200;
                }
                if (questionNumber == 3)
                {
                    lblQ3points.Text = "300";
                    score += 300;
                }
                if (questionNumber == 4)
                {
                    lblQ4points.Text = "400";
                    score += 400;
                }
                if (questionNumber == 5)
                {
                    lblQ5points.Text = "500";
                    score += 500;
                }
                if (questionNumber == 6)
                {
                    lblQ6points.Text = "600";
                    score += 600;
                }
                if (questionNumber == 7)
                {
                    lblQ7points.Text = "700";
                    score += 700;
                }

                lblPoints.Text = score.ToString();
            }

            else
            {
                if(answer == 1)
                {
                    btnOption1.BackColor = Color.LimeGreen;
                    MessageBox.Show("Better Luck Next Time!");
                    btnOption1.BackColor = Color.MistyRose;
                }
                if (answer == 2)
                {
                    btnOption2.BackColor = Color.LimeGreen;
                    MessageBox.Show("Better Luck Next Time!");
                    btnOption2.BackColor = Color.MistyRose;
                }
                if (answer == 3)
                {
                    btnOption3.BackColor = Color.LimeGreen;
                    MessageBox.Show("Better Luck Next Time!");
                    btnOption3.BackColor = Color.MistyRose;
                }
                if (answer == 4)
                {
                    btnOption4.BackColor = Color.LimeGreen;
                    MessageBox.Show("Better Luck Next Time!");
                    btnOption4.BackColor = Color.MistyRose;
                }
            }

            if(questionNumber == totalQuestions)
            {
                timer1.Stop();
                Form3 f3 = new Form3(score, lblPlayerName.Text);
                f3.Show();
                this.Hide();
            }

            questionNumber++;
            AskQuestion(questionNumber);
        }

        private void AskQuestion(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    ticks = 60;
                    timer1.Start();
                    lblQ1.BackColor = Color.LimeGreen;
                    lblQuestion.Text = Questions[0].question;
                    btnOption1.Text = Questions[0].op1;
                    btnOption2.Text = Questions[0].op2;
                    btnOption3.Text = Questions[0].op3;
                    btnOption4.Text = Questions[0].op4;
                    answer = Questions[0].answer;
                    break;

                case 2:
                    ticks = 60;
                    timer1.Start();
                    lblQ2.BackColor = Color.LimeGreen;
                    lblQ1.BackColor = Color.White;
                    lblQuestion.Text = Questions[1].question;
                    btnOption1.Text = Questions[1].op1;
                    btnOption2.Text = Questions[1].op2;
                    btnOption3.Text = Questions[1].op3;
                    btnOption4.Text = Questions[1].op4;
                    answer = Questions[1].answer;
                    break;

                case 3:
                    ticks = 60;
                    timer1.Start();
                    lblQ3.BackColor = Color.LimeGreen;
                    lblQ1.BackColor = Color.White;
                    lblQ2.BackColor = Color.White;
                    lblQuestion.Text = Questions[2].question;
                    btnOption1.Text = Questions[2].op1;
                    btnOption2.Text = Questions[2].op2;
                    btnOption3.Text = Questions[2].op3;
                    btnOption4.Text = Questions[2].op4;

                    answer = Questions[2].answer;
                    break;

                case 4:
                    ticks = 60;
                    timer1.Start();
                    lblQ4.BackColor = Color.LimeGreen;
                    lblQ1.BackColor = Color.White;
                    lblQ2.BackColor = Color.White;
                    lblQ3.BackColor = Color.White;

                    lblQuestion.Text = Questions[3].question;
                    btnOption1.Text = Questions[3].op1;
                    btnOption2.Text = Questions[3].op2;
                    btnOption3.Text = Questions[3].op3;
                    btnOption4.Text = Questions[3].op4;

                    answer = Questions[3].answer;
                    break;
                case 5:
                    ticks = 60;
                    timer1.Start();
                    lblQ5.BackColor = Color.LimeGreen;
                    lblQ1.BackColor = Color.White;
                    lblQ2.BackColor = Color.White;
                    lblQ3.BackColor = Color.White;
                    lblQ4.BackColor = Color.White;

                    lblQuestion.Text = Questions[4].question;
                    btnOption1.Text = Questions[4].op1;
                    btnOption2.Text = Questions[4].op2;
                    btnOption3.Text = Questions[4].op3;
                    btnOption4.Text = Questions[4].op4;


                    answer = Questions[4].answer;
                    break;

                case 6:
                    ticks = 60;
                    timer1.Start();
                    lblQ6.BackColor = Color.LimeGreen;
                    lblQ1.BackColor = Color.White;
                    lblQ2.BackColor = Color.White;
                    lblQ3.BackColor = Color.White;
                    lblQ4.BackColor = Color.White;
                    lblQ5.BackColor = Color.White;

                    lblQuestion.Text = Questions[5].question;
                    btnOption1.Text = Questions[5].op1;
                    btnOption2.Text = Questions[5].op2;
                    btnOption3.Text = Questions[5].op3;
                    btnOption4.Text = Questions[5].op4;

                    answer = Questions[5].answer;
                    break; 

                case 7:
                    ticks = 60;
                    timer1.Start();
                    lblQ7.BackColor = Color.LimeGreen;
                    lblQ1.BackColor = Color.White;
                    lblQ2.BackColor = Color.White;
                    lblQ3.BackColor = Color.White;
                    lblQ4.BackColor = Color.White;
                    lblQ5.BackColor = Color.White;
                    lblQ6.BackColor = Color.White;

                    lblQuestion.Text = Questions[6].question;
                    btnOption1.Text = Questions[6].op1;
                    btnOption2.Text = Questions[6].op2;
                    btnOption3.Text = Questions[6].op3;
                    btnOption4.Text = Questions[6].op4;

                    answer = Questions[6].answer;
                    break;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            if(answer == 1)
            {
                btnOption2.Visible = false;
                btnOption3.Visible = false;
            }
            if (answer == 2)
            {
                btnOption1.Visible = false;
                btnOption3.Visible = false;
            }
            if (answer == 3)
            {
                btnOption2.Visible = false;
                btnOption4.Visible = false;
            }
            if (answer == 4)
            {
                btnOption3.Visible = false;
                btnOption1.Visible = false;
            }

            btn5050.Visible = false;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if(questionNumber == 1)
            {
                lblHint.Text = Questions[0].hint;
            }
            if (questionNumber == 2)
            {
                lblHint.Text = Questions[1].hint;
            }
            if (questionNumber == 3)
            {
                lblHint.Text = Questions[2].hint;
            }
            if (questionNumber == 4)
            {
                lblHint.Text = Questions[3].hint;
            }
            if (questionNumber == 5)
            {
                lblHint.Text = Questions[4].hint;
            }
            if (questionNumber == 5)
            {
                lblHint.Text = Questions[5].hint;
            }
            if (questionNumber == 7)
            {
                lblHint.Text = Questions[6].hint;
            }

            btnHint.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks--;
            lblTimer.Text = ticks.ToString();

            if(ticks == 0)
            {
                timer1.Stop();
                questionNumber++;
                AskQuestion(questionNumber);
            }

        }
    }
}
