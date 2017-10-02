using System;
					
public class Program
{
	public static void Main()
	{
		var name = Console.ReadLine();
		var current_health = int.Parse(Console.ReadLine());
		var maximum_health = int.Parse(Console.ReadLine());
		var current_energy = int.Parse(Console.ReadLine());
		var maximum_energy = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Name: " + name);
		Console.WriteLine("Health: " + "|" + new string('|', current_health) + new string('.', maximum_health - current_health) + "|");
		Console.WriteLine("Energy: " + "|" + new string('|', current_energy) + new string('.', maximum_energy - current_energy) + "|");
	}
}