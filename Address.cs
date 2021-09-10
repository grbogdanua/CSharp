using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
	internal class Address
	{
		public string Country { get; private set; }
		public string District { get; private set; }
		public string City { get; private set; }
		public string Street { get; private set; }
		public int Housenumber { get; private set; }

		public Address()
		{
			Console.Write("Country: ");
			Country = Console.ReadLine();
			Console.Write("District: ");
			District = Console.ReadLine();
			Console.Write("City: ");
			City = Console.ReadLine();
			Console.Write("Street: ");
			Street = Console.ReadLine();
			Console.Write("House number: ");
			var enteredhousenumber = Console.ReadLine();
			int num;
			while(!int.TryParse(enteredhousenumber, out num))
			{
				Console.Write("Housenumber isn`t number. Try again. Housenumber: ");
				enteredhousenumber = Console.ReadLine();
			}
			Housenumber = num;
		}
		public void GetInfo()
		{
			Console.WriteLine($"Country: {Country}, District: {District}, City: {City}, Street: {Street}, House number: {Housenumber}");
		}
	}
}
