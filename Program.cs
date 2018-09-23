using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zabawaZNullami
{
	class Program
	{
		
			static void Main(string[] args)
			{
				bool? brakDanych = null;
				bool? prawda = true;
				bool? falsz = false;
				// | - lub
				// & - i

				bool? wynik = brakDanych | prawda;

				//		Console.WriteLine(wynik);
				if (wynik == true)
					Console.WriteLine("prawda");

				if (wynik == false)
					Console.WriteLine("fałsz");

				if (wynik == null)
					Console.WriteLine("nie wiem");

				Console.ReadLine();
			}
	}
}
