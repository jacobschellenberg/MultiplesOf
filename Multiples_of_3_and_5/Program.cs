using System;
using System.Collections;
using System.Collections.Generic;

namespace Multiples_of_3_and_5
{

	/// <summary>
	/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
	/// The sum of these multiples is 23.
	/// Find the sum of all the multiples of 3 or 5 below 1000.
	/// </summary>
	class MainClass
	{
		public static void Main (string[] args)
		{
			int max = 10;
			int sum = 0;
			int multipleOf3 = 0;
			int multipleOf5 = 0;

			for (int i = 0; i < max; i++) {
				multipleOf3 = i * 3;
				multipleOf5 = i * 5;

				if (multipleOf3 < max && multipleOf3 > 0) {
					sum += multipleOf3;
					Console.WriteLine ("Multiple of 3: " + multipleOf3);
				}

				if (multipleOf5 < max && multipleOf5 > 0) {
					sum += multipleOf5;
					Console.WriteLine ("Multiple of 5: " + multipleOf5);
				}
			}

			Console.WriteLine ("Sum: " + sum);
		}
	}
}
