using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            int falseCounter = 0;


            foreach (var val in vals)
            {

                if (val == false)

                {
                    falseCounter++;
                }
            }
            
            if (falseCounter == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int oddSum = 0;

            if (numbers == null) 
            {
                return false;
            }


            foreach (var val in numbers)
            {
                if (val % 2 != 0) 
                
                {
                    oddSum += val; //It's important to add the + in front of the equal sign or it will not return the proper value for all tests.
                }
            }

            if (oddSum % 2 != 0)
            {
                return true;
            }    
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            char[] inputPass = password.ToCharArray();
            
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNum = false;

            foreach (char c in inputPass)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }

                if (char.IsLower(c))
                {
                    hasLower = true;
                }

                if (char.IsNumber(c))
                {
                    hasNum = true;
                }
                    

            }

            if (hasUpper == true && hasLower == true && hasNum == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            
            char c = val.FirstOrDefault();


            return c;  

            
        }

        public char GetLastLetterOfString(string val)
        {
            char c = val.LastOrDefault();

            return c;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
           
            var oddsBelow100 = from r in Enumerable.Range(0, 100).Where(num => num % 2 != 0)
                         select r; 

            return oddsBelow100.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            //var allUpperCase = from word in words
            //                   let upperCase = word.ToUpper()
            //                   select word;


            //foreach (var word in words)
            //{
            //    word.ToUpper();
            //}

            //words = words.Select(word => word.ToUpper()).ToArray();

            for (var index = 0; index < words.Length; index++)
            {
                words[index] = words[index].ToUpper(); //Make sure that you select the index of the word to make the conversion.
            }

           



        }
    }
}
