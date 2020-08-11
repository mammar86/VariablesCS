using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {

            // first part of the assignment 


            int numberOfCupsOfCoffee = 3;
            string fullName = "Mohamed Ammar";
            string today = "August 11th";
            Console.WriteLine(fullName + " " + numberOfCupsOfCoffee + " " + today);

            Console.WriteLine($"Hello, My name is {fullName}. I usually drink around {numberOfCupsOfCoffee} cups of coffee a day. Ohh I forgot to tell you that today's date is {today}.");

            Console.Write("\n");



            // second part of the assignment

            Console.Write("What is your name? ");
            string userName = Console.ReadLine();

            Console.Write("\n");

            Console.WriteLine($"Welcome to SDG {userName}!");

            Console.Write("\n");



            // third part of the assignment 


            Console.Write($"Hey {userName} what is the first number? ");
            string firstNumberAsString = Console.ReadLine();

            Console.Write($"Hey {userName} what is the second number? ");
            string secondNumberAsString = Console.ReadLine();

            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;


            Console.WriteLine($"Today {userName} arrived to SDG thinking he is smart, he challenged us to do math on our own using two numbers the first number is {firstOperand} and the second one is {secondOperand}.\nwe lied to him and used C#, the sum of the two number was {sum} while the difference between them is {difference}.\nIf we multiplied the two numbers we will get {product} also the division came out equals {quotient} and the remainder was {remainder}.");







        }
    }
}
