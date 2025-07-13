namespace Assignment_CS_04_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problems Solutions Assignment 4 C#
            #region Question 1 
            /*
            int Number;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out Number);

            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine($"{i} ");
            }
            */
            #endregion
            #region Question 2
            /*
            int Number;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out Number);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(Number * i );
            }
            */
            #endregion
            #region Question 3
            /*
            int Number;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out Number);

            for (int i = 2; i <= Number; i += 2)
            {
                Console.WriteLine(i + " ");
            }
            */
            #endregion
            #region Question 4
            /*
            int baseNum;
            int Power;
            int result = 1;
            Console.Write("Enter Base Number : ");
            int.TryParse(Console.ReadLine(), out baseNum);
            Console.Write("Enter Power : ");
            int.TryParse(Console.ReadLine(), out Power);
            for(int i=1;i<=Power;i++)
            {
                result = result * baseNum;
            }
            Console.WriteLine($"{baseNum} To The Power Of {Power} Equals {result}");
            */
            #endregion
            #region Question 5
            /*
            int StdMarks;
            const int SubjectsNumber = 5;
            int totalMarks = 0;
            Console.WriteLine("Please Enter Student Marks : ");
            for(int i=1;i<= SubjectsNumber; i++)
            {
                int.TryParse(Console.ReadLine(), out StdMarks);
                totalMarks = totalMarks + StdMarks;
            }
            double AverageMarks = totalMarks / SubjectsNumber;
            double Percentage = AverageMarks;

            Console.WriteLine($"Total marks = {totalMarks}");
            Console.WriteLine($"Average Marks = {AverageMarks}");
            Console.WriteLine($"Percentage = {Percentage}%");
            */
            #endregion
            #region Question 6
            /*
            string Str;
            string reversedStr="";
            Console.Write("Enter A String ");
            Str=Console.ReadLine();
            for(int i = Str.Length - 1; i >= 0; i--) // Strings Length Is greater than the index by 1 So we have to put -1 to access all string indices
            {
                reversedStr +=Str[i];
            }
            Console.WriteLine($"Reversed String : {reversedStr}");*/
            #endregion
            #region Question 7
            /*
            int Number;
            Console.WriteLine("Please enter a number ");
            int.TryParse(Console.ReadLine(), out Number);
            int reversedInteger = 0;

            while (Number > 0)
            {
                int digit = Number % 10; // To Extract The Last Digit Of The Number
                reversedInteger = reversedInteger * 10 + digit; //Shif The Digits Of The Reversed Number To The Left
                Number /= 10; // Move to The Next Digit 
            }
            Console.WriteLine("Reversed Number: " + reversedInteger);*/
            #endregion
            #region Question 8
            /*
            int FirstNumber, LastNumber;

            Console.Write("Enter The First Number: ");
            int.TryParse(Console.ReadLine(), out FirstNumber);

            Console.Write("Enter The Last Number: ");
            int.TryParse(Console.ReadLine(), out LastNumber);


            for (int num = FirstNumber; num <= LastNumber; num++)
            {
                bool isPrime = true;

                if (num < 2)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i * i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(num);
                }
            }*/
            #endregion
            #region Question 9
            /*
            int DecNumber;
            string BinaryNumber = ""; //String because it consists of zeros and ones concatenated with each other
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out DecNumber);
            while (DecNumber > 0)
            {
                BinaryNumber += (DecNumber % 2);
                DecNumber /= 2;
            }
        Console.WriteLine($"Binary: {BinaryNumber}");*/
            #endregion
            #region Question 11
            /*
            int MatrixSize;
            Console.Write("Enter matrix size : ");
            int.TryParse(Console.ReadLine(),out MatrixSize);
            //We Use Nested Loops For Matrices
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    if (i == j)
                        Console.Write("1");
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }*/
            #endregion

        }
    }
}
