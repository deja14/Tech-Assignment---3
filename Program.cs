using System;

namespace Tech_Assignment___3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a KM-Increment value between 10 and 25:");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                miles = KM * 0.621371;

                const int size = 3;
                int [] myvalues = new int[size];

                for (int i = 0; i < size; i++) ;
                {
                    myvalues [i] = value_of_input * 0.621371;
                }



            }
            catch
            {
                Console.WriteLine("Please enter a integer value between 10 and 25");
            }
        }
    }
}
