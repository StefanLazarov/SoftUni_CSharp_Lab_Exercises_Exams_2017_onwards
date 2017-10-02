using System;
					
public class Program
{
	public static void Main()
	{
		var width = float.Parse(Console.ReadLine());
		var height = float.Parse(Console.ReadLine());
		
		Console.WriteLine("{0:0.00}", width * height);
	}
}