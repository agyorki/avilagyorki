using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingGrade_Gyorki
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int[] a = new int[20];
            
            //loads the array with user input
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter the grade(1 for correct, 0 for incorrect) : ");

                a[i] = Convert.ToInt32(Console.ReadLine());

                //assigns zero if it is false else it is true
                if (a[i] == 0)
                    a[i] = 0;
                else
                    a[i] = 1;
            }

            //setting the score to 5 to account for bonus points
            double score = 5;

            //declare char to store grade
            char grade;

            //for loop to add up the grade
            for (int i = 0; i < 20; i++)
            {
                if (a[i] == 0)
                {
                    //if it incorrect then the score is reduced by 5
                    score -= 0.5;
                }
                else
                {
                    // if correct then the score adds 5
                    score += 5;
                }
            }

            //if statements to assign the letter grade based on score
            if (score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'B';
            }
            else if (score >= 70)
            {
                grade = 'C';
            }
            else if (score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            //calling helper method and loading our score and grade values into it
            displayGrade(score, grade);

            Console.ReadLine();        

    }

        //display grade function
        private static void displayGrade(double score, char grade)
        {
            //printing the score;
            Console.WriteLine("Score is " + score);
            //printing the grade;
            Console.WriteLine("Grade is " + grade);

        }

    }
}































           
