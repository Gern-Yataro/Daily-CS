//QUESTION
//Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, 
//there are exactly 6 routes to the bottom right corner. How many such routes are there through a 20×20 grid?

//SOLUTION
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(latticeGridV2(20));
	}
	
	public static long latticeGridV2(int gridSize)
	{
		long[,] nodePaths = new long[gridSize+1, gridSize+1];
		//Initialise grid with "1" paths
		for(int i=0; i<=gridSize; i++){
			nodePaths[i, gridSize] = 1;
			nodePaths[gridSize, i] = 1;
		}
		
		for(int x=gridSize-1; x>=0; x--){
			for(int y=gridSize-1; y>=0; y--){
				nodePaths[x, y] = nodePaths[x+1, y] + nodePaths[x, y+1];
			}
		}
		return nodePaths[0, 0];
	}
}
 
