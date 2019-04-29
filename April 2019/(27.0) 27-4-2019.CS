//QUESTION
//Starting in the top left corner of a 2×2 grid, 
//and only being able to move to the right and down, 
//there are exactly 6 routes to the bottom right corner.
//How many such routes are there through a 20×20 grid?

//SOLUTION
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(latticePaths(20));
	}
	
	public static long latticePaths(int gridSize)
	{
		if(gridSize <= 0){
			return 0;
		}
		int requiredSteps = gridSize*2;
		long possibleSteps = 1;
		for (int i = 0; i < gridSize; i++) {
    		possibleSteps *= (2 * gridSize) - i;
    		possibleSteps /= i + 1;
		}
		return possibleSteps;
	}
}
