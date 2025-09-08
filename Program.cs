namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Code snippet by Malin Hallgren
Part of Chas Academy .NET25*/

            int number = 0;
            bool validInput = false;


            /*The following block asks for a numeric input and runs until suuch is given
            While input wasn't needed I find that a refresher on how to parse user input
            is never a bad thing*/

            while (!validInput)
            {
                Console.WriteLine("Mata in ett nummer");

                validInput = int.TryParse(Console.ReadLine(), out number);

                if (validInput)
                {
                    if (number >= 10)
                    {
                        Console.WriteLine("Talet är Stort!");
                    }

                    else
                    {
                        Console.WriteLine("Oj! Litet tal!");
                    }
                }
                else
                {
                    Console.WriteLine("Det där är inget nummer.");
                }
            }

            /*Asks the user their name and saves it in nullable string name
            string needs to be nullable in the event that the user presses enter 
            without entering their name, and because VS gets angry otherwise
            Prints a greeting to the user*/

            Console.WriteLine("Vad heter du?");
            string? name = Console.ReadLine();

            Console.WriteLine($"Hej {name}");

            /*Counts from one to the number stored in number with a slight delay
            to make it easier to read, and because I wanted to experiment with
            thread.sleep a bit*/

            for (int i = 1; i <= number; i++)
            {
                Thread.Sleep(250);
                Console.Write($"{i} ");
            }
        }
    }
}
