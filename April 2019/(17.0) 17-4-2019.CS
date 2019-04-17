//QUESTION
/*What is the largest prime factor of the number 600851475143?*/

//SOLUTION

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(largestPrimeFactor(600851475143));
	}
	
	public static long largestPrimeFactor(long x)
	{
		long i = 2;
		long largestFactor = 2;
		while(i*i <= x){
			if(x%i == 0){
				x /= i;
				largestFactor = i;
			} else {
				i = (i==2)? 3 : i+2;
			}
		}
		if(x > i){
			return x;
		}
		return largestFactor; 
	}
}
