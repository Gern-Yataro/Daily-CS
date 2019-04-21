using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(sumOfPrime(2000000));
	}
	
	public static long sumOfPrime(int range)
	{
		List<int> primes = new List<int>(){2};
		int j;
		long sum = 2;
		int number = 1;
		bool isPrime;
		while(number < range){
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
			if(isPrime == true && number < range){
				primes.Add(number);
				sum += number;
				if(primes[primes.Count - 1] >= range){
					primes.Remove(number);
				}
			}
		}
		return sum;
	}
}
