//QUESTION
//Find the sum of all the multiples of 3 or 5 below 1000.

//SOLUTION
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(sumMultiple(3) + sumMultiple(5) - sumMultiple(15));
	}
	
	public static long sumMultiple(long multiple, long maxMultiple = 1000)
	{
		long currentMultiple = 0;
		long sum = 0;
		while(currentMultiple + multiple < maxMultiple){
			currentMultiple += multiple;
			sum += currentMultiple;
		}
		return sum;
	}
}
