//QUESTION
/*Find the largest palindrome made from the product of two 3-digit numbers.*/

//SOLUTION
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(largestPalindrome());
	}
	
	public static string largestPalindrome()
	{
		int firstNum = 0, secondNum = 0;
		int p = 998001;
		for(int i=p; i >= 10000; i--){		
			if(checkPalindrome(i) == true){
				for(int x=(int)Math.Sqrt(i); x <= 999; x++){
					if(i%x == 0 ){
						firstNum = x;
						secondNum = i/x;
						return "Largest palindrome is " + i + ", made with " + firstNum + " x " + secondNum;
					}
				}
			}
		}
		return "none";
	}
	
	public static bool checkPalindrome(int x){
		int a = x, b = 0;
		while(a > 0){
			b = b*10 + a%10;
			a /= 10;
		}
		if(b == x){
			return true;
		}
		return false;
	}
}
