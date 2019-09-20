using System;
using System.Collections.Generic;
using System.Linq;
namespace weeklyChallenges04
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    total += item;
                }
                else
                {
                    total -= item;
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> Thane = new List<string>();
            Thane.Add(str1);
            Thane.Add(str2);
            Thane.Add(str3);
            Thane.Add(str4);
            string[] Neymor = Thane.ToArray() ;
            int minLength = Neymor.Min(y => y.Length);
            return minLength;
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> Bobby = new List<int>(number1);
            Bobby.Add(number1);
           Bobby.Add(number2);
           Bobby.Add(number3);
           Bobby.Add(number4);
            int[] Greg = Bobby.ToArray();
            return Greg.Min(x => x);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
           biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1+sideLength3 > sideLength2 && sideLength2+sideLength3>sideLength1)
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
            decimal i;
            if (decimal.TryParse(input, out i))
            {
                return true;
            }
            else
                return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nulls = 0;
            int others = 0;
            foreach (var item in objs)
            {
                if (item == null)
                {
                    nulls++;
                }
                else
                    others++;
            }
            if (nulls > others)
                return true;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {

            if(numbers == null)
            {
                return 0;
            }
            double sandy = numbers.Select(x => x).Where(x => x % 2 == 0).Sum();
            double randy = numbers.Select(x => x).Where(x => x % 2 == 0).Count();
            if(randy == 0)
            {
                return 0;
            }
            return sandy / randy;
            
        }

        public int Factorial(int number)
        {

            if (number < 0)
                throw new ArgumentOutOfRangeException();
            if (number == 0)
            {
                return 1;
            }
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            
            return factorial;
        }
    }

}
