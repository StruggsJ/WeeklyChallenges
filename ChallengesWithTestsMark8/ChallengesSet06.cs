using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            if (words == null)
            {
                return false;
            }

            string searchWord = word;
            string listedWord = "";

            if (ignoreCase == true)
            {
                
                searchWord = searchWord.ToLower();

                foreach (string listed in words) 
                {
                    if (listed == null)
                    {

                    }
                    else
                    {
                        listedWord = listed.ToLower();

                        if (listedWord == searchWord)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            else
            {
                foreach (string listed in words)
                {
                    if (listed == null)
                    {

                    }
                    else
                    {
                        listedWord = listed;
                        if (listed == searchWord)
                        {
                            return true;
                        }
                    }
                   
                }

                return false;
            }
        }

        public bool IsPrimeNumber(int num)
        {
            int a = 0;

            if (num <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        a++;
                    }
                }

                if (a == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {

            //Get the index of (.IndexOf) a character after listing distinct characters (.Distinct) and go through the list backwards (.Reverse).
            //in which that character only occurs once in the string (.FirstOrDefault(x => str.Count(y => y.Equals(x)) == 1))


            return str.IndexOf(str.Distinct().Reverse().FirstOrDefault(x => str.Count(y => y.Equals(x)) == 1));
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            
            int count = 0;
            

            for(int i = 0; i < numbers.Length; i++)
            {

               int currentCount = 1;
                

                for (int j = i +1 ; j < numbers.Length; j++)
                {
                  
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
            
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {

            var retrievedDouble = new List<double>();

            if (elements == null || n <= 0 || elements.Count <= 0)
            {
                return new double[0];
            }
            else
            {
                // use i +=n instead of n++ or i will remain same number. (review loop parts; incrementers & operators); n - 1 instead of 0 to actually get the nth element since first index is 0.
                for (int i = n - 1; i < elements.Count; i += n) //releated to OutOfMemory Exception (Array dimensions exceeded supported range) if using n++ | find a way to check for end of list
                {
                    retrievedDouble.Add(elements[i]);

                }
            }

            var countedDoubles = retrievedDouble.Count();
            var listedDouble = new double[countedDoubles];

            retrievedDouble.CopyTo(listedDouble, 0);


            return listedDouble;

        }


       
    }
}
    

