using System;
					
public class Program
{
	public static void Main()
	{
		var name = Console.ReadLine();
		var volume = int.Parse(Console.ReadLine());
		var energy_content_per100ml = int.Parse(Console.ReadLine());
		var sugar_content_per100ml = int.Parse(Console.ReadLine());
		
		Console.WriteLine(
					volume + "ml" + " " + name + ":\n" +
					energy_content_per100ml * (volume / 100.0) + "kcal," + " " + sugar_content_per100ml * (volume / 100.0) + "g sugars"
					);
	}
}