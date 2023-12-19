using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearningClass
{
    internal class Program
    {
        static string WriteText(string text) 
        {
            Console.Write("Please, type something text: ");
            return text;
        }
        static int Method(ref int a)
        {
            int b = a * 2;
            a = 5;
            return b;
        }
        static string Compare(int operandOne, int operandTwo) 
        {
            if (operandOne < operandTwo)
            {
                return operandOne + " is less "+ operandTwo;
            }
            if (operandOne > operandTwo)
            {
                return operandOne +" is greater " + operandTwo;
            }
            if(operandOne == operandTwo)
            {
                return operandOne + " is equally " + operandTwo;
            }
            return "The task decided";
        }
        static string Greeting(string name)
        {
            if(name == "fool")
            {
                return "The name isn`t correctly!";
            }

            string sentence = "Hello " + name + "!";

            return sentence;
        }
        static int LearnOut(out int a)
        {
            a = 2;
            return a * 2;
        }
        static int Add(int numberOne, int numberTwo, ref int sum)
        {
          return sum = numberOne + numberTwo;
        }
        static void Main(string[] args)
        {
            Console.Write($"Введите номер метода: ");
            bool numberOfMethod = int.TryParse(Console.ReadLine(), out int number);

            if (numberOfMethod==true)
            {
                if (number == 1)
                {
                    string phrase = WriteText(Console.ReadLine());
                    Console.WriteLine(phrase);
                }
                if (number == 2)
                {
                    int operand = 2;
                    int result = Method(ref operand);

                    Console.WriteLine($"{0};{1};", operand, result);
                }
                if (number == 3)
                {
                    string s = Compare(5, 7);
                    Console.WriteLine(s);
                }
                if (number == 4)
                {
                    Console.WriteLine(Greeting("fool"));
                }
                if (number == 5)
                {
                    int result = LearnOut(out int a);
                    Console.WriteLine("{0};{1};",a, result);
                }
                if (number == 6)
                {
                    Console.Write("Введите первое число: ");
                    int numberOne=Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    int numberTwo = Convert.ToInt32(Console.ReadLine());

                     int sum=0;

                    Add(numberOne, numberTwo, ref sum);
                    Console.WriteLine($"The sum of the two numbers is "+sum);
                }



            }
            Console.ReadLine();
        }
    }
}
