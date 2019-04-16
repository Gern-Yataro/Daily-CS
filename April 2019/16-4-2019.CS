//QUESTION
/*Given an 12-digit number, find the 13th digit that would make a valid EAM13.
  You may need to consider the case of leading 0's to get up to 11 digits. 
  That is, an input of 12345 would correspond to a UPC start of 00000012345.*/

//SOLUTION
using System;
					
public class Program {
	public static void Main() {
		Console.WriteLine(EANcheck(238695431209));
	}
	
	public static string EANcheck(long x) {
		int digitSum = 0;
		int checkDigit = 0;
		x = x*10;
		long[] EAMarr = new long[13];
		for(int i = 12; i >= 0; i--){
			EAMarr[i] = x%10;
			x = x/10;
			int a = i % 2;
			digitSum += (i%2 == 0)? (int)EAMarr[i] : (int)EAMarr[i]*3;
		}
		checkDigit = (digitSum%10 == 0)? 0 : (10 - (digitSum % 10));
		string output = string.Join("", EAMarr);
		return output + checkDigit;
	}
}
