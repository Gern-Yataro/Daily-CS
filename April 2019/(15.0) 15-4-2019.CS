//QUESTION
/* calculate the additive persistence of a number, 
   defined as how many loops you have to do summing its digits 
   until you get a single digit number.
   Take an integer N:
    1.Add its digits
    2.Repeat until the result has 1 digit */

//SOLUTION
using System;
					
public class Program {
	public static void Main() {
    		Console.WriteLine(addPersistence(13));
    		Console.WriteLine(addPersistence(1234));
    		Console.WriteLine(addPersistence(9876));
		Console.WriteLine(addPersistence(199));
	}
	
	public static int addPersistence(long x) {
		if(x < 10){
			return 0;
		}		
		return 1 + addPersistence(sumNum(x));
	}
	
	public static long sumNum(long y) {
		long b = 0;
		while(y >= 1){
			b += y%10;
			y /= 10;
		}
		return b;
	}
}
