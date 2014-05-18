using System;

namespace primeFinder0
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			long myMax = 12345;
			for (long j = 2; j <= myMax; j++) {
				//long x = long.MaxValue; // 99999999999999999999997;
				Console.Write (j + " is: ");
				if (isPrime (j)) {
					Console.WriteLine ("Prime");
				} else {
					Console.WriteLine ("Composite");
				}
			}
		}

		public static Boolean isPrime(long x){
			long max;
			if (x > 3) {
				max = (long)(Math.Sqrt (x) + 1);
			} else {
				max = x;
			}
			for (int i = 2; i < max; i++) {
				if (x % i == 0) {
					return false;
				}
			}
			return true;
		}

	}
}
