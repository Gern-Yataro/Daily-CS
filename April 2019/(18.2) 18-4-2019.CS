//QUESTION
//What is the 10 001st prime number?

//SOLUTION
using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(nthPrime(10001));
	}
	
	public static int nthPrime(int nthNumber)
	{
		List<int> primes = new List<int>(){2};
		int j;
		int number = 1;
		bool isPrime;
		while(primes.Count < nthNumber){
			j = 0;
			number += 2;
			isPrime = true;
			while(primes[j]*primes[j] <= number){
				if(number % primes[j] == 0){
					isPrime = false;
					break;
				}
				j++;
			}
			if(isPrime == true){
				primes.Add(number);
			}
		}
		return primes[primes.Count - 1];
	}
}
