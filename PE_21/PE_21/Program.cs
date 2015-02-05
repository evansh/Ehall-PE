/* Amicable numbers
 * 
 * Let d(n) be defined as the sum of proper divisors of n 
 * (numbers less than n which divide evenly into n).
 * 
 * If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair 
 * and each of a and b are called amicable numbers.
 *
 * For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; 
 * therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
 * 
 * Evaluate the sum of all the amicable numbers under 10000.
 */
using System;
using System.Diagnostics;	//To measure computation time

namespace PE_21
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			const int limit = 10000;

			var math = new Math();
			var value1 = 0;
			var value2 = 0;
			var answer = 0;

			for (int i = 1; i <= limit; i++) 
			{
				value1 = math.sumOfProperDivisors (i);
				value2 = math.sumOfProperDivisors (value1);

				if (i == value2 && i != value1) 
				{
					answer += i;
				}
			}
			stopwatch.Stop();

			Console.WriteLine(stopwatch.ElapsedMilliseconds);
			Console.WriteLine (answer);
		}
	}
}
