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
		int n;
		long sum = 0;
		bool[] sieve = new bool[range];
		sieve[2] = true; 
		sieve[3] = true; 
		for(int x=1; x*x < range; x++){
			for(int y=1; y*y < range; y++){
				n = (4*x*x)+(y*y);
				if(n <= range && (n % 12 == 1 || n % 12 == 5)){
					sieve[n] ^= true;
				}
				
				n = (3*x*x)+(y*y);
				if(n <= range && n % 12 == 7){
					sieve[n] ^= true;
				}
				
				n = (3*x*x)-(y*y);
				if(x > y && n <= range && n % 12 == 11){
					sieve[n] ^= true;
				}
			}
		}
		
 	  	for (int r = 5; r * r < range; r++) { 
        	if (sieve[r]) { 
         	   for (int i = r * r; i < range; i += r * r){
          	      sieve[i] = false; 
  	  	    	} 
			}
  	  	} 
		
		for(int a = 5; a < range; a++){
			if(sieve[a] == true){
				sum += a;
			}
		}
		
		return sum;
	}
}
