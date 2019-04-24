//QUESTION
//What is the value of the first triangle number
//to have over five hundred divisors?

//SOLUTION
using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(findTriNumwithFactorsOf(500));
	}
	
	public static long findTriNumwithFactorsOf(int numOfFactors)
	{
		int exponent = 1;
		int factorSum = 1;
		long triNum = 0;
		bool[] primes = sieveOfE(75000);
		for(int x=1;;x++){
			factorSum = 1;
			triNum = triangleNumber(x);
			long triNumTemp = triNum;
			for(int y=2; y <= triNumTemp; y++){
				exponent = 1;
				if(primes[y]==true){
					while(triNumTemp%y==0){
						triNumTemp /= y;
						exponent++;
					}
					factorSum *= exponent;
				}
				if(factorSum >= numOfFactors){
					return triNum;
				}
			}
		}
	}
	
	public static long findFactors(long y)
	{
		long factors = 0;
		for(int i=1; i*i <= y; i++){
			if(y%i == 0){
				factors += 2;
			}
			if(i*i == y){
				factors -= 1;
			}
		}
		return factors;
	}
	
	public static bool[] sieveOfE(int limit){
		bool[] primes = new bool[limit];	
		for(int x=2; x<limit; x++){
			primes[x] = true;
		}
		for(int i=2; i*i <= limit-1; i++){
			if(primes[i] == true){
				for(int j=i*2; j < limit; j+=i){
					primes[j] = false;
				}
			}
		}
		return primes;
	}
	
	public static long triangleNumber(long x)
	{
		return x*(x+1)/2;
	}
}
