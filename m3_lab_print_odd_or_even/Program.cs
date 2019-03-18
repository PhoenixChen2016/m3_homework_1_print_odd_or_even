using System;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine();
		Random rn = new Random();
		//  fix #1 觀察下一行
		// d 為 0.0 和 1.0 (不包含1.0) 之間的亂數
		double d = rn.NextDouble();
		Console.WriteLine();

		//  fix #2 觀察下一行
		Console.WriteLine("d 為 " + d);
		Console.WriteLine();
		Console.Write(" x 的值 是 ");

		//  fix #3 如何讓使得 x 存有 6 或 7 的值
		//  請寫在下面 
		var x = 6 + (rn.Next(1, 10) & 0x1);

		Console.WriteLine(x);
		Console.WriteLine("##########################");
		//  fix #4 如何讓使得 x 存有 6 的值時,印出 x為偶數
		//                 而 x 存有 7 的值時,印出 x為奇數
		//  請寫在下面

		Console.WriteLine((x & 0x1) > 0 ? "x為奇數" : "x為偶數");

		Console.WriteLine("??????????????????????????");
		Console.WriteLine();
		Console.WriteLine("結束");
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine();

	}
}
