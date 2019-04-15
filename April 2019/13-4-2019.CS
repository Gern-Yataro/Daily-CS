//QUESTION
/*A number is input in computer 
  then a new no should get printed by adding one to each of its digit. 
  If you encounter a 9, insert a 10 (don't carry over, just shift things around).
  For example, 998 becomes 10109.*/

//SOLUTION
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(addOneEach(1249));
		Console.WriteLine(addOneEach2(1249));
	}
	
	//Solution 1
	public static long addOneEach(long x){	
		if(x < 10){
			return (x + 1);
		}
		long a = x%10 + 1;
		long b = addOneEach(x/10)*10;
		if(a == 10){
			return (b+1)*10;
		} else {
			return a+b;
		}
	}
	
	//Solution 2
	public static long addOneEach2(long x, int power = 0){
		if(x < 10){
			return (x+1)*(long)Math.Pow(10, power);
		}
		long a = (x%10) + 1;
		if(a == 10){
			a = 1;
			power ++;
		}
		return a*(long)Math.Pow(10, power) + addOneEach2(x/10, ++power);
	}
}
