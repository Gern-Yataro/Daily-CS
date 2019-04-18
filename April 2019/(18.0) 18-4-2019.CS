//QUESTION
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

//SOLUTION
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(lcmMultiple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20));
	}
	
	
	public static long gcd(long a, long b)
	{
		while(a != 0 && b != 0){
			if(a>b){
				a %= b;
			} else{
				b %= a;
			}
		}
		return a == 0 ? b : a;
	}
	
	public static long lcm(long a, long b)
	{
		return (a*b)/gcd(a, b);
	}
	
	public static long lcmMultiple(long a, long b, params long[] numbers)
	{
		long final = lcm(a, b);
		for(int x=0; x < numbers.Length; x++){
			final = lcm(final, numbers[x]);
		}
		return final;
	}
}
