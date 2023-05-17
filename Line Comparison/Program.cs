using System;

namespace LineComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program");

            // Line 1 coordinates
            float x1, x2, y1, y2;
            float length1;

            // Line 2 coordinates
            float x1_1, x2_2, y1_1, y2_2;
            float length2;

            Console.WriteLine("Line 1");
            x1 = GetUserInput("Enter the x-coordinate of the first point: ");
            y1 = GetUserInput("Enter the y-coordinate of the first point: ");
            x2 = GetUserInput("Enter the x-coordinate of the second point: ");
            y2 = GetUserInput("Enter the y-coordinate of the second point: ");

            // Calculate length of Line 1
            length1 = CalculateLineLength(x1, y1, x2, y2);
            Console.WriteLine("Length of Line 1: " + length1);

            Console.WriteLine("Line 2");
            x1_1 = GetUserInput("Enter the x-coordinate of the first point: ");
            y1_1 = GetUserInput("Enter the y-coordinate of the first point: ");
            x2_2 = GetUserInput("Enter the x-coordinate of the second point: ");
            y2_2 = GetUserInput("Enter the y-coordinate of the second point: ");

            // Calculate length of Line 2
            length2 = CalculateLineLength(x1_1, y1_1, x2_2, y2_2);
            Console.WriteLine("Length of Line 2: " + length2);

            // Compare the lengths of the lines
            if (IsEqualLength(length1, length2))
            {
                Console.WriteLine("Both lines are equal in length");
            }
            else if (IsLine1Longer(length1, length2))
            {
                Console.WriteLine("Line 1 is longer than Line 2");
            }
            else
            {
                Console.WriteLine("Line 2 is longer than Line 1");
            }

            Console.ReadLine();
        }

        static float GetUserInput(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }

        static float CalculateLineLength(float x1, float y1, float x2, float y2)
        {
            return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static bool IsEqualLength(float length1, float length2)
        {
            return Math.Abs(length1 - length2) < 0.0001;
        }

        static bool IsLine1Longer(float length1, float length2)
        {
            return length1 > length2;
        }
    }
}
