using System;

namespace PE_21
{
	public class Math
	{
		public int sumOfProperDivisors(int value)
		{
			int sum = 0;
			for (int i = 1; i <= (value / 2); i++) 
			{
				if (value % i == 0) 
				{
					sum += i;
				}
			}
			return sum;
		}
	}
}

