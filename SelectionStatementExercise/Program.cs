
using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Please input a number to guess");
            var userInput = int.Parse(Console.ReadLine());

            var answer = Guess(favNumber, userInput);
            Console.WriteLine(answer);

            //Create a methos which returns what the users guess and see if it correct
        }
            static string Guess(int favNumber,int userinput)
            {


                if (favNumber > userinput)
                {

                    return ("To low");

                }
                else if (favNumber < userinput)
                {
                    return ("To High");
                }

                else
                {

                    return ("Youu Guessed itt");
                }



            }
    }
}
