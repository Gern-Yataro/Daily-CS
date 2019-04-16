//QUESTION
/*Find the sum of the given terms in a fibonacci sequence and the sum of even and odd valued terms in the sequence*/

//SOLUTION
using System;
					
public class Program {
	public static void Main() {
    Console.WriteLine(fibonacciSum(10));
    Console.WriteLine(evenFibonacciSum(10));
		Console.WriteLine(oddFibonacciSum(10));
	}
	
  //Sum of terms (starts from 1)
	public static int fibonacciSum(int terms, int prevNum2=0, int prevNum=1){
		if(terms == 0){
			return 0;
		}
        return (prevNum + prevNum2) + fibonacciSum(--terms, prevNum, (prevNum + prevNum2));
	}
	
  //Sum of even valued terms (starts from 1)
	public static int evenFibonacciSum(int terms, int prevNum2=0, int prevNum=1){
		if(terms == 0){
			return 0;
		}
		int currentNum = ((prevNum + prevNum2)%2 == 0)? (prevNum + prevNum2) : 0;
        return currentNum + evenFibonacciSum(--terms, prevNum, (prevNum + prevNum2));
	}
	
  //Sum of odd valued terms (starts from 1)
	public static int oddFibonacciSum(int terms, int prevNum2=0, int prevNum=1){
		if(terms == 0){
			return 0;
		}
		int currentNum = ((prevNum + prevNum2)%2 != 0)? (prevNum + prevNum2) : 0;
        return currentNum + oddFibonacciSum(--terms, prevNum, (prevNum + prevNum2));
	}
}
