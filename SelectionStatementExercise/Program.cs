using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            GuessingGame();

        }


        public static void GuessingGame()
        {


            var r = new Random();
            var favNumber = r.Next(1, 10);

            Console.WriteLine("Try to guess a number");

            var userInput = int.Parse(Console.ReadLine());

        

            if (userInput < favNumber)
            {
                Console.WriteLine($"Too low!!!\nYour guess: {userInput}");
            }


            else if (userInput > favNumber)
            {
                Console.WriteLine($"Too high \nYour guess: {userInput}");
            }

            else

            {
                Console.WriteLine("You guessed it yay.");
            }


        }



        
    }
}
