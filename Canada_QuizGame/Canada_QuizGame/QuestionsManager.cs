using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canada_QuizGame
{
    internal static class QuestionsManager
    {
        public static MCQ[] QuestionsRandomizer(MCQ q1, MCQ q2, MCQ q3, MCQ q4, MCQ q5, MCQ q6, MCQ q7)
        {
            MCQ[] Questions = new MCQ[7];

            Questions[0] = q1;
            Questions[1] = q2;  
            Questions[2] = q3;  
            Questions[3] = q4;  
            Questions[4] = q5;  
            Questions[5] = q6;  
            Questions[6] = q7;

            ShuffleArray(Questions);

            return Questions;
           
        }

        public static void ShuffleArray(MCQ[] mcq)
        {
            int n = mcq.Length;
            Random rand = new Random();

            for(int i = 0; i < n; i++)
            {
                swap(mcq, i, i+rand.Next(n - i));
            }
        }

        public static void swap(MCQ[] mcq, int a, int b)
        {
            MCQ temp = mcq[a];
            mcq[a] = mcq[b];
            mcq[b] = temp;
        }

    }
}
