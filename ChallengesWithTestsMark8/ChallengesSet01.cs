using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double total = minuend - subtrahend;
            return total;
        }

        public int Add(int number1, int number2)
        {
            int total = number1 + number2;
            return total;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int smallNumber;

            if (number1 > number2)
            {
                smallNumber = number2;
                return smallNumber;
            }
            else
            {
                smallNumber = number1;
                return smallNumber;
            }

        }

        public long Multiply(long factor1, long factor2)
        {
            long total = factor1 * factor2;
            return total;

        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
