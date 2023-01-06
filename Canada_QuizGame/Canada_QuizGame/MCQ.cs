using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canada_QuizGame
{
    internal class MCQ
    {
        public string question;
        public int answer;
        public string hint;
        public string op1;
        public string op2;
        public string op3;
        public string op4;
        

        public MCQ(string question, int answer, string hint, string op1, string op2, string op3, string op4)
        {
            this.question = question;
            this.answer = answer;
            this.hint = hint;
            this.op1 = op1;
            this.op2 = op2;
            this.op3 = op3;
            this.op4 = op4;
        }
    }
}
