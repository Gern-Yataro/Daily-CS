//QUESTION
//What is the sum of the digits of the number 2^1000?

//SOLUTION
using System;
using System.Numerics;
					
public class Program
{
	public static void Main()
	{
		
		Console.WriteLine(sumOfDigits(2, 1000));
	}
	
	public static int sumOfDigits(int numBase, long numPower)
	{
		int sum = 0;
		BigInteger number = new BigInteger(Math.Pow(numBase, numPower));
		string numberStr = number.ToString();
		for(int i=0; i < numberStr.Length; i++){
			sum += ((int)numberStr[i] - 48);
		}
		return sum;
	}
}
