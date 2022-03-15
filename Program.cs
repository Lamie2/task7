using System;

namespace ConsoleApp1
{
	class Program
	{

		static void Main(string[] args)
		{

			//int count = 0;
			//for (int i = 0; i <8000; i++)
			//{
			//	if (i%2==0)

			//	{
			//		count++;
			//	}
			//}
			//Console.WriteLine("3e bolunenlerin sayi: " +count);




			//		int[] array1 = new int[] { 196, 35, 57, 77, 90 };
			//		int count = 0;
			//		for (int i = 0; i <5; i++) 
			//		{
			//			int s = 0;
			//			int N = array1[i];
			//			while (N>0)
			//			{
			//				int P = N % 10; 
			//				s = s  + P;
			//				N = N / 10;
			//			}
			//			Console.WriteLine("array1["+i+"] = "+ array1[i] + " -> reqemleri cemi = " + s);
			//			if (s<10)
			//			{
			//				count++;
			//			}
			//		}
			//		Console.WriteLine("Cavab: " + count);


			int n = 20;
			double kokalti = Math.Sqrt(n);
			double kokaltiYuvarla = Math.Round(kokalti);
			double ededinKvadrati = Math.Pow(kokaltiYuvarla, 2);
			double ededinKvadratininKokaltisi = Math.Sqrt(ededinKvadrati);
			Console.WriteLine("Cavab: " + ededinKvadratininKokaltisi);
			//Console.WriteLine("Cavab: " + Math.Sqrt(Math.Pow(Math.Round(Math.Sqrt(n)), 2)));



		}
	}


}








