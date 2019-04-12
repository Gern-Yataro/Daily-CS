using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(balanced("xxxyyyzzz"));
		Console.WriteLine(balanced("abccbaabccba"));
		Console.WriteLine(balanced("xxxyyyzzzz"));
		Console.WriteLine(balanced("abcdefghijklmnopqrstuvwxyz"));
		Console.WriteLine(balanced("pqq"));
		Console.WriteLine(balanced("fdedfdeffeddefeeeefddf"));
		Console.WriteLine(balanced("www"));
		Console.WriteLine(balanced("x"));
		Console.WriteLine(balanced(""));
	}
	
	static bool balanced(string sentence)
	{
		ArrayList repeats = new ArrayList();
		char[] sentence_letters = sentence.ToCharArray();
		//Get unique characters
		HashSet<char> unique_letters = new HashSet<char>(sentence_letters);	
		
		//Get the number of repeats of each character
		foreach(char i in unique_letters){
			repeats.Add(sentence_letters.Count(p => p == i));
		}
		
    //Check if repeats are the same
		for(int x = 0; x < repeats.Count; x++){
			if((int)repeats[x] != (int)repeats[0]){
				return false;
			}
		}
		return true;
	}
}
