using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("please enter number integer then print all numbers between 1 to that number.");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine($"input : {num}");
            //Console.Write($"output : ");
            //for (int i = 1; i <= num; i++)
            //    Console.Write($"{i} ");

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("please enter number integer then print a multiplication table up to 12.");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine($"input : {num}");
            //Console.Write($"output : ");
            //for ( int i = 1; i <= 12; i++ )
            //    Console.Write($"{num * i} ");
            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number.
            //Console.WriteLine("please enter number then print all even numbers between 1 to this number.");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine($"input : {num}");
            //Console.Write($"output : ");
            //for ( int i = 1; i <= num; i++ )
            //{
            //    if (i % 2 == 0)
            //        Console.Write($"{i} ");
            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //Console.WriteLine("please enter two integers then prints the power.");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.WriteLine($"input : {num1} {num2}");
            //int result = 1;
            //for ( int i = 1; i <= num2; i++ )
            //{
            //    result *= num1;
            //};
            //Console.Write($"output : {result}");


            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.  
            //Console.WriteLine("please enter five subjects and calculate total, average and percentage.");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //int.TryParse(Console.ReadLine(), out int num3);
            //int.TryParse(Console.ReadLine(), out int num4);
            //int.TryParse(Console.ReadLine(), out int num5);
            //int total = num1 + num2 + num3 + num4 + num5;
            //int average = total / 5;
            //float percentage = (total /500.0f) * 100;
            //Console.WriteLine($"total : {total}");
            //Console.WriteLine($"average : {average}");
            //Console.WriteLine($"percentage : {percentage} %");

            #endregion

            #region 6- Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("please enter month number");
            //int.TryParse(Console.ReadLine(), out int number_of_month);
            //switch (number_of_month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28 or 29");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    default:
            //        Console.WriteLine("invuled month");
            //             break;
            //}
            #endregion

            #region 7- Write a program to create a Simple Calculator.
            //Console.Write("please enter number 1 :");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("please enter number 2 :");
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.Write("please enter (+ , - , * , /) : ");
            //char ch = Convert .ToChar(Console.ReadLine());
            //switch (ch)
            //{
            //    case '+':
            //        Console.WriteLine($"Sum = {num1} + {num2} = {num1 + num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"Sub = {num1} - {num2} = {num1 - num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"Multi = {num1} * {num2} = {num1 * num2}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"por = {num1} / {num2} = {num1 / num2}");
            //        break;
            //    default:
            //        Console.WriteLine("invuled");
            //        break;

            //}

            #endregion

            #region 8- Write a program to allow the user to enter int and print the REVERSED of it.
            //string st = Console.ReadLine();
            //for (int i = st.Length - 1; i >= 0; i--)
            //    Console.Write(st[i]);

            #endregion

            #region 9- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int.TryParse(Console.ReadLine(), out int start);
            //int.TryParse(Console.ReadLine(), out int end);
            //bool isPrime = true;

            //if (start > 1)
            //{
            //    for (int i = start; i <= end; i++)
            //    {
            //        for (int j = 2; j <= i / 2; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }

            //        if (isPrime)
            //            Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("not found prime number");


            #endregion

            #region 10- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //int.TryParse(Console.ReadLine(), out int num);
            //string st = "";
            //int r = num;
            //while (r > 0)
            //{
            //    if (r % 2 == 0)
            //        st = "0" + st;
            //    else if (r % 2 != 0)
            //        st = "1" + st;
            //    r /= 2;
            //}
            //Console.WriteLine(st);

            #endregion
        }
    }
}
