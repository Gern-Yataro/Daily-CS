using System;
					
public class Program {
	public static void Main() {
		Console.WriteLine(EANcheck(501234576421));
	}
	
	public static long EANcheck(long x) {
		int digitSum = 0;
		long output = x*10;
		x = x*10;
		long[] EAMarr = new long[13];
		for(int i = 12; i >= 0; i--){
			EAMarr[i] = x%10;
			x = x/10;
			int a = i % 2;
			digitSum += (i%2 == 0)? (int)EAMarr[i] : (int)EAMarr[i]*3;
		}
		return output + (10 - (digitSum % 10));
	}
}
