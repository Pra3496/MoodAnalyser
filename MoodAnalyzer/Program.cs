using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
     

            bool flag = true;

            string moodly = "\0";
            
            while(flag)
            {
                
                Console.WriteLine("\nWell-Come to MoodAnalyzer Program\n");
                Console.WriteLine("Options");
                Console.WriteLine("1 : Mood Analzer");
                Console.WriteLine("0 Exit\n");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MoodAnalyzerProblem mood;
                      
                        Console.Write("\nEnter your statement : ");
                        moodly = Convert.ToString(Console.ReadLine());

                        mood = new MoodAnalyzerProblem(moodly);
                        Console.WriteLine("\n\t" + mood.AnalseMood() + "\n");
                       
                        Console.ReadKey();
                        break;
                  
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("please enter correct option");
                        break;

                }
                
            }
                
            
        }
    }
}