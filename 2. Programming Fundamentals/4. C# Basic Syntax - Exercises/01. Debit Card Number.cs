using System;
					
public class Program
{
	public static void Main()
	{
		var a = Console.ReadLine();
		var b = Console.ReadLine();
		var c = Console.ReadLine();
		var d = Console.ReadLine();
		Console.WriteLine(a.PadLeft(4, '0') + " " + b.PadLeft(4, '0') + " " + c.PadLeft(4, '0') + " " + d.PadLeft(4, '0'));
	}
}