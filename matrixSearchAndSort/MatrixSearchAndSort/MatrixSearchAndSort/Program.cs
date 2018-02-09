using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Suzanne Townsend
// Purpose: Demonstrate understanding of matrix'
// date: 2017/09/22
namespace MatrixSearchAndSort
{
	class Program
	{
		static void Main(string[] args)
		{
			//declare matrix
			int max_size = 5;
			int[,] matrixArray = new int[max_size, max_size];

			FillArray(max_size, ref matrixArray);
			Console.WriteLine("Before sorting");
			PrintArray(max_size, ref matrixArray);


			SortArray(max_size, ref matrixArray);
			Console.WriteLine("After sorting");
			PrintArray(max_size, ref matrixArray);

			SearchArray(max_size, ref matrixArray, 0, 0, 0, 0);
			Console.ReadLine();
		}


		//fill matrix with random, non duplicate integers
		public static void FillArray(int max_size, ref int[,] matrixArray)
		{

			Random rndNum = new Random();
			List<int> tempList = new List<int>();

			for (int x = 0; x < max_size; x++)
			{

				for (int y = 0; y < max_size; y++)
				{
					int num = rndNum.Next(10, 100);

					if (!tempList.Contains(num))
					{
						matrixArray[x, y] = num;
						tempList.Add(num);
					}
					else
					{
						y--;
					}
				}
			}
		}

		//loop through matrix and print.
		public static void PrintArray(int max_size, ref int[,] matrixArray)
		{

			for (int x = 0; x < max_size; x++)
			{
				for (int y = 0; y < max_size; y++)
				{
					Console.Write(" [" + matrixArray[x, y] + "] ");
				}
				Console.WriteLine();
			}
		}

		//sortin the matrix with four for loops
		public static void SortArray(int max_size, ref int[,] matrixArray)
		{
			int temp = 0;

			for (int x = 0; x < max_size; x++)
			{
				for (int y = 0; y < max_size; y++)
				{
					for (int i = 0; i < max_size; i++)
					{
						for (int j = 0; j < max_size; j++)
						{
							if (matrixArray[i, j] > matrixArray[x, y])
							{
								temp = matrixArray[x, y];
								matrixArray[x, y] = matrixArray[i, j];
								matrixArray[i, j] = temp;
							}
						}
					}
				}
			}
		}

		//a step-wise linear search, checks whether or not the matrix holds a user defined integer.
		public static bool SearchArray(int max_size, ref int[,] matrixArray, int N, int input,
			  int row, int col)
		{
			Console.WriteLine("please enter the integer you wish to search for.");
			input = Int32.Parse(Console.ReadLine());

			if ((input < matrixArray[0, 0] || (input > matrixArray[max_size - 1, max_size - 1])))
			{
				Console.WriteLine(input + " was not found!");
				Console.WriteLine("Press enter to exit......");
				Console.ReadLine();
				return false;
			}
			row = 0;
			col = N - 1;

			while ((row <= max_size - 1) && (col >= 0))
			{
				if (matrixArray[row, col] < input)
				{
					row++;
				}
				else if (matrixArray[row, col] > input)
				{
					col--;
				}
				else
				{

					return true;
				}

			}
			Console.WriteLine(input + " Found");
			Console.WriteLine("please enter to exit");
			Console.ReadLine();

			return false;
		}
	}
}


		
	

