//QUESTION
//Referring to the Collatz Conjecture, which starting number, under one million, produces the longest chain?

//SOLUTION
using System;
using System.Linq;
using System.Collections.Generic;

//Compiler version 4.0, .NET Framework 4.5

namespace Dcoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(collatzLongest(1000000));
        }
        
        public static int collatzLongest(long range)
        {
            Dictionary<long, int> testedNum = new Dictionary<long, int>();
            long number = 1;
            long tempNumber;
            int steps = 0;
            while(number < range){
                steps = 0;
                tempNumber = number;
                while(tempNumber !=1){
                    if(tempNumber % 2 == 0){
                        tempNumber /= 2;
                        steps++;
                    } else {
                        tempNumber = tempNumber*3 + 1;
                        steps++;
                    }
                    if(testedNum.ContainsKey(tempNumber)){
                        steps += testedNum[tempNumber];
                        break;
                    }
                    
                }
                testedNum.Add(number, steps);
                number++;
            }
            int maxValue = testedNum.Values.Max();
            var myKey = testedNum.FirstOrDefault(x => x.Value == maxValue).Key;
            Console.WriteLine(myKey);
            return maxValue;
        }
    }
}
