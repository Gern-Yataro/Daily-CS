//QUESTION
//There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.

//SOLUTION
using System;
					
public class Program
{
	public static void Main()
	{
		pythagoreanTriple answer = pythagoreanGenerator(1000);
		Console.WriteLine("There exists a triplet A + B + C = 1000 which:");
		Console.WriteLine();
		Console.WriteLine(" Side A: " + answer.a);
		Console.WriteLine(" Side B: " + answer.b);
		Console.WriteLine(" Side C: " + answer.c);
		Console.WriteLine();
		Console.WriteLine("The product of A, B, C is " + (answer.a*answer.b*answer.c));
	}
	
	//Returns a pythagorean triplet with a perimeter (matching/nearest to) requested perimeter
	public static pythagoreanTriple pythagoreanGenerator(int perimeter){
		int m = 2;
		pythagoreanTriple bestTriple = new pythagoreanTriple(0, 0, 0);
		while(bestTriple.perimeter() != perimeter){
			for(int n=1; n<m; ++n){
				bestTriple.a = m*m - n*n;
				bestTriple.b = 2*m*n;
				bestTriple.c = m*m + n*n;
				if(bestTriple.perimeter() >= perimeter){
					goto End;
				}
			}
			m++;
		}
		End:
		return bestTriple;
	}
	
	public class pythagoreanTriple {
		public int a, b, c;
		
		public pythagoreanTriple(int a, int b, int c){
			this.a = a;
			this.b = b;
			this.c = c;
		}
		
		public int perimeter(){
			return a+b+c;
		}
	}
}
