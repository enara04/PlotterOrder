using System;

namespace Hazifeladat1
{
    class Program
    {
        private const int PEN_MIN = 1;
        private const int PEN_MAX = 24;
        private const int PAPER_LENGTH_MIN = 10;
        private const int PAPER_LENGTH_MAX = 500;
        private const int PAPER_WIDTH_MIN = 10;
        private const int PAPER_WIDTH_MAX = 500;
        private const int MAX_SPEED_MIN = 10;
        private const int MAX_SPEED_MAX = 110;

        static void Main(string[] args)
        {
            int total = 0;
            int sum = 0;
            Plotter plotter;
            char keyInfo = 'y';

            do
            {
                plotter = GetPlotterFromConsole();

                //Print price of plotter
                Console.WriteLine("{0}", plotter);


                Console.Write("Would you like to buy the plotter? (y/n) ");
                char keyInfo2 = GetCharFromConsole();
                Console.WriteLine();
                if (keyInfo2 == 'y')
                {
                    //Calculate total income
                    total += plotter.CalculatePrice();
                    sum++;
                }

                Console.Write("Is there a new customer? (y/n) ");
                keyInfo = GetCharFromConsole();
                Console.WriteLine();

                //Continue iteration when 'y' entered
            } while (keyInfo == 'y');

            Console.WriteLine("Total price: {0}", total);
            Console.WriteLine("Number of sold plotters: {0}", sum);

        }

        private static int GetIntFromConsole(int min, int max)
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
            {
                Console.WriteLine("Please enter an integer number ({0}-{1})!", min, max);
            }
            return number;
        }

        private static char GetCharFromConsole()
        {
            char answer;
            while (!char.TryParse(Console.ReadLine(), out answer) || answer != 'y' && answer != 'n')
            {
                Console.WriteLine("Please enter y or n!");
            }
            return answer;
        }

        private static Plotter GetPlotterFromConsole()
        {
            Plotter plotter;          //On default initialization, no need for new operator
                                       //value type variable has been created
            Console.Write("--Attributes of the needed plotter--");
            Console.WriteLine();
            Console.Write("Number of pens: ");
            plotter.PenNum = GetIntFromConsole(PEN_MIN, PEN_MAX);
            Console.Write("Length of Paper: ");
            plotter.PaperLength = GetIntFromConsole(PAPER_LENGTH_MIN, PAPER_LENGTH_MAX);
            Console.Write("Width of Paper: ");
            plotter.PaperWidth = GetIntFromConsole(PAPER_WIDTH_MIN, PAPER_WIDTH_MAX);
            Console.Write("Maximum speed of plotter: ");
            plotter.MaxSpeed = GetIntFromConsole(MAX_SPEED_MIN, MAX_SPEED_MAX);

            return plotter;
        }
    }
}
