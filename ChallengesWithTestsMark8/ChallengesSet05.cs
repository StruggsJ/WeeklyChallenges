using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int endNumber = startNumber;
            do
            {
                endNumber++;
            } while (endNumber % n != 0); //stoping point to reach divisible number.

            return endNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            var amountBusiness = businesses.Length;

            for (int i = 0; i < amountBusiness; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }

        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            var isOrderedAsc = numbers.OrderBy(n => n); //creates another enumerable that is ordered

            if (numbers.SequenceEqual(isOrderedAsc)) //checks if input is equal to above.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int totalLength = numbers.Length;
            int totalsum = 0;
            int lastnum = 0;
            for (int i = 0; i < totalLength; i++)
            {
                if (i == 0) // assigns first number of the element to look at.
                {
                    lastnum = numbers[i];

                }
                else if (lastnum % 2 == 0) //if true, adds the number to the total sum.
                {
                    totalsum += numbers[i];
                    lastnum = numbers[i];
                }
                else //otherwise, skips it.
                {
                    lastnum = numbers[i];
                }

            }


            

            return totalsum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {

            if (words == null || words.Length == 0)
            {
                return "";
            }

            var listWords = new List<string>();
           

            foreach (var word in words)
            {
                

                if (!string.IsNullOrWhiteSpace(word))
                {

                  listWords.Add(word.Trim());

                }

            }

            
            var converted = String.Join(" ", listWords);


            if (converted == "")
            {
                return converted;
            }
           
            converted = converted + ".";
            return converted;
            

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var listedFourth = new List<double>();

            if (elements == null)
            {
                return listedFourth.ToArray();
            }
            
            for (int i = 4 - 1; i < elements.Count; i += 4) // 4 - 1; skips first element | i +=4; goes to every fourth element
            {
                listedFourth.Add(elements[i]);
            }
            
            return listedFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int totalSize = nums.Length;

            for(int i = 0; i < (totalSize - 1); i++) //First number (totalSize - 1 ; ending at end of array)
            {
                for (int j = (i + 1); j < totalSize; j++) // Second number (j < totalSize; ending at second number of end of the array)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
