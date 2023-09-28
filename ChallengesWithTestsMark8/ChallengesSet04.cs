using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int stringLength1 = str1.Trim().Length;
            int stringLength2 = str2.Trim().Length;
            int stringLength3 = str3.Trim().Length;
            int stringLength4 = str4.Trim().Length;

            List<int> lengthNumbers = new List<int>();
            lengthNumbers.Add(stringLength1);
            lengthNumbers.Add(stringLength2);
            lengthNumbers.Add(stringLength3);
            lengthNumbers.Add(stringLength4);

            return lengthNumbers.Min();
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);
            numbers.Add(number4);

            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            

            if (biz.Name == null)
            {
                biz.Name = "TrueCoders";
            }
           else if (biz.Name == "")
            {
                biz.Name = "TrueCoders";
            }

            biz.Name = "TrueCoders";
            

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int sideOne = sideLength1 + sideLength2;
            int sideTwo = sideLength1 + sideLength3;
            int sideThree = sideLength2 + sideLength3;            

            
            if (sideLength1 <0 || sideLength2 <0 || sideLength3 <0)
            {
                return false;
            }

            

            if (sideOne > sideLength3 && sideTwo > sideLength2 && sideThree > sideLength1) 
            
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
           bool numberCheck = Decimal.TryParse(input, out var number);

            return numberCheck;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCounter = 0;
            int notNullCounter = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCounter++; 
                }
                else
                {
                    notNullCounter++;
                }
            }

            if (nullCounter > notNullCounter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            int totalEvens = 0;
            double totalEvenNumbers = 0; //This must be a double type to return decimal values.

            double averageEvens = 0;

            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Length == 0)
            {
                return 0;
            }

            foreach(int number in numbers)
            {
                if (number % 2 == 0)
                {
                    totalEvens = (totalEvens + number);
                    totalEvenNumbers++;
                }
            }

            if (totalEvenNumbers == 0)
            {
                return 0;
            }
            else
            {
                averageEvens = totalEvens / totalEvenNumbers;
            }
            

            return averageEvens; 
        }

        public int Factorial(int number)
        {
            int facNum = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = 1; i <= number; i++)
            {
                facNum = facNum * i;
            }

            return facNum;
        }
    }
}
