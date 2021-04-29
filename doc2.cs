using System;
using System.Collections.Generic;
public class program
{
	
	public static void Main()
	{
		int n;
		int[] arr1 = new int[5];
		Console.Write("Enter the number of elements to be stored in the array :");
	   n = Convert.ToInt32(Console.ReadLine()); 	   
   
       Console.Write("Input {0} elements in the array :\n",n);
		List<int> mylist = new List<int> ();
		
		for(int i=0; i<n; i++)
		{
			 Console.Write("element - {0} : ",i);
    	  arr1[i] = Convert.ToInt32(Console.ReadLine()); 
		if(i%2==0)
		{
		Console.WriteLine("Even Number");
		}
		else
		{
		Console.WriteLine("Odd Number");
		}
	}
}
}