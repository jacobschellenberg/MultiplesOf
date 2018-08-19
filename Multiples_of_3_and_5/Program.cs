using System;

namespace MultiplesOf
{
	/* 
	If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
	The sum of these multiples is 23.
	Find the sum of all the multiples of 3 or 5 below 1000.
	*/

	public class Program
	{
		private static int maxNaturalNumber = 10;
		private static int multipleOf01 = 3;
		private static int multipleOf02 = 5;
		
		public static void Main ()
		{
			int sumOf01 = GetSumOfMultiplesOf(maxNaturalNumber, multipleOf: multipleOf01);
			int sumOf02 = GetSumOfMultiplesOf(maxNaturalNumber, multipleOf: multipleOf02);
			int sumOfMultiples = sumOf01 + sumOf02;

			Console.WriteLine("Sum of {0}s and {1}s: {2}", multipleOf01, multipleOf02, sumOfMultiples);
		}

		private static int GetSumOfMultiplesOf(int maxNaturalNumber, int multipleOf)
		{
			int sum = 0;

			for (int i = 0; i < maxNaturalNumber; i++) 
			{
				int multiple = i * multipleOf;

				if (multiple < maxNaturalNumber && multiple > 0) 
				{
					sum += multiple;
					Console.WriteLine("Multiple of {0}: {1}", multipleOf, multiple);
				}
			}
			
			Console.WriteLine("Sum of multiples of {0}: {1}", multipleOf, sum);
			return sum;
		}
	}
}
