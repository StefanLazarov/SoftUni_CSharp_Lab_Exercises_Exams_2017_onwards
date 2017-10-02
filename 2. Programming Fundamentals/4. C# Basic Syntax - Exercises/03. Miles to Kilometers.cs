using System;
					
public class Program
{
	public static void Main()
	{
		var miles = float.Parse(Console.ReadLine());
		var kilometers = miles * 1.60934;
		
		Console.WriteLine("{0:0.00}", kilometers);
	}
}