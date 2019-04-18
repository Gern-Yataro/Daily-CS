//QUESTION
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

//SOLUTION
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Sum of squares of first 100 numbers: " + sumOfSquares(100));
		Console.WriteLine("Squares of sum of first 100 numbers: " + squaresOfSum(100));
		Console.WriteLine("Difference between two calculations: " + (squaresOfSum(100) - sumOfSquares(100)));
	}
	
	public static long sumOfSquares(long x)
	{
		return x*(x+1)*(2*x + 1)/6;
	}
	
	public static long squaresOfSum(long x)
	{
		return (long)Math.Pow(x*(x+1)/2, 2);
	}
}
