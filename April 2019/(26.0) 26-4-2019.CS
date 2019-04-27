//QUESTION
//Create a Tower of Hanoi steps solver with recursion (divide and conquer algorithm)

//SOLUTION
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(towerHanoi(3, 'A', 'B', 'C'));
	}
	
	public static int stepsHanoi(int height)
	{
		return (int)Math.Pow(2, height) - 1;
	}
	
	public static int towerHanoi(int height, char source, char dest, char temp, int steps = 0)
	{
		if(height==1){
			Console.WriteLine("Move disk " + height + " from " + source + " to " + dest);
			return ++steps;
		}
		steps+= towerHanoi(height-1, source, temp, dest);
		Console.WriteLine("Move disk " + height + " from " + source + " to " + dest);
		++steps;
		steps+= towerHanoi(height-1, temp, dest, source);
		return steps;
	}
}
