using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c) == true) 
            {
                return true;
            }
            else
            { 
                return false; 
            }

        }

        public bool CountOfElementsIsEven(string[] vals)
        {

            int count = 0;

                foreach (var val in vals)
                {
                    count++;
                }

                if (count % 2 == 0)
                {
                    return true;
                }
                else if (count == 0)
                {
                    return true;

                }
                else 
                {
                    return false;
                }
            

            
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double min = double.MaxValue;
            double max = double.MinValue; 

            if (numbers == null || numbers.Sum() == 0)
            {
                return 0;
            }
            else
            {
                foreach (var number in numbers)
                {
                    double inputNum = number;
                    
                    if (inputNum < min)
                        {
                            min = number;
                        }
                    if (inputNum > max || inputNum == max)
                        {
                            max = number;
                        }
                }



                return min + max;
            }
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int stringLength1 = str1.Length;
            int stringLength2 = str2.Length;

            if (stringLength1 > stringLength2)
            {
                return stringLength2;
            }
            else
            {
                return stringLength1;
            }
        }

        public int Sum(int[] numbers)
        {
            int totalSum = 0;

            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (var number in numbers)
                {
                    totalSum += number;
                }

                return totalSum;
            }
        }

        public int SumEvens(int[] numbers)
        {

            int evenSum = 0;

            if (numbers == null)
            {
                return 0;
            }

            for(int i  = 0; i < numbers.Length; i++)
            {
               
                if ( numbers[i] % 2 == 0)
                {
                    evenSum = evenSum + numbers[i];
                }
            }

            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int totalSum = 0;

            if (numbers == null)
            {
                return false;
            }

            foreach (var number in numbers)
            {
                totalSum += number;
            }

            if (totalSum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            List<int> oddNum = new List<int>();

            for (int i = 0; i < number;  i++)
            {
                if (i % 2 != 0)
                {
                    oddNum.Add(i);
                }    
            }

            return oddNum.Count;
        }
    }
}
