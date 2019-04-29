//QUESTION
//If all the numbers from 1 to 1000 (one thousand) 
//inclusive were written out in word form, 
//how many letters would be used?

//SOLUTION 
using System;
					
public class Program
{
	public static void Main()
	{
		int letterSum = 0;
		for(int i=1; i<=1000; i++){
			letterSum += numberLetterCounts(i);
		}
		Console.WriteLine(letterSum);
	}
	
	public static int numberLetterCounts(int number)
	{
		int totalCount = 0;
		int tempCount = 0;
		string[] numberNames = new string[]
		{"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", 
		 "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", 
		 "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred", "thousand"};
		
		int[] numberValues = new int[]
		{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 30, 40, 50, 60, 70, 80, 90, 100, 1000};
		
		if(number==1000){
			return 11;
		}
		
		if(number>=100){
			tempCount = 0;
			while(number - 100 >= 0){
				number -= 100;
				tempCount ++;
			}
			//Add digit length, and the length of "hundred"
			totalCount += (numberNames[tempCount].Length + 7);
			if(number>0){
				//Since there are hundreds and tens, "and" must exist
				totalCount += 3;
			}
		}
		
		for(int x = 27; x >= 1; x--){
			while(number - numberValues[x] >= 0){
				number -= numberValues[x];
				totalCount += numberNames[x].Length;	
			}
		}
		
		return totalCount;
	}
} 
