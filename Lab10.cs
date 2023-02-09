using System;
using System.Collections.Generic;
					
public class Program
{
	//Lab Day 10
	public struct Car
	{
		public int doors;
		public double price;
		public string streetCred;
		
		public Car(int d, double p, string sc)
		{
			doors = d;
			price = p;
			streetCred = sc;
		}
	}
	
	public static void Main()
	{
		//#1 struc for a car object
		Car coolTruck = new Car(4,40000,"cool Truck");
		Console.WriteLine("this car is called: " + coolTruck.streetCred + " and costs $" + coolTruck.price);
		
		//#2 one dimensional int array
		int[] myArray = new int[10] {1,4,1,5,9,2,6,5,3,5};
		foreach (int i in myArray)
		{
			Console.Write(i);
		}
		Console.WriteLine();
		
		//#3 2d Array and foreach loop to print it
		int[,] myArray2 = { {1,4,1,5,9} , {2,6,5,3,5} };
		foreach (int i in myArray2)
		{
			Console.Write(i);
		}
			
		
		//Part 3 Challenges
		int[] challengeArray = {1,5,10,5,4,1,4,2,8,10,11,12};
		//also added using System.Collections.Generic; at the top
		
		List<int> evenList = new List<int>();
		List<int> oddList = new List<int>();
		foreach (int elem in challengeArray)
		{
			if (elem % 2 == 0)
			{
				// add to even list
				evenList.Add(elem);
			}
			else
			{
				oddList.Add(elem);
			}
		}
		
		Console.WriteLine();
		foreach (int elem in evenList)
		{
			Console.Write(elem);
		}
		Console.WriteLine();
		foreach (int elem in oddList)
		{
			Console.Write(elem);
		}
		
		
		//Challenge 2
		int[]  array_1 = {1,2,3,4,5};
		int[] array_2 = {1,2,10,11};
		int len = 0;
		
		//should chose whichever is the shortest array... 
		if (array_1.Length < array_2.Length)
		{
			len = array_1.Length;
		}
		else
		{
			len = array_2.Length;
		}
		
		for (int i = 0; i < len; i++)
		{
			if (array_1[i] == array_2[i])
			{
				Console.WriteLine("these are the same at location "+ i);
			}
			else
			{
				continue;
			}
		}
		
		
	}
}
