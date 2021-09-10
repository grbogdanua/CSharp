﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
	class Human
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public Address HumanAdress { get; set; }

		public Human(string name, string surname, int age, Address address)
		{
			Name = name;
			Surname = surname;
			Age = age;
			HumanAdress = address;
		}
		public Human()
		{
			Console.Write("Name: ");
			Name = Console.ReadLine();

			Console.Write("Surname: ");
			Surname = Console.ReadLine();

			Console.Write("Age: ");
			var enteredAge = Console.ReadLine();
			int num;
			while(!int.TryParse(enteredAge,out num))
			{
				Console.Write("Age isn`t number. Try again. Age: ");
				enteredAge = Console.ReadLine();
			}
			Age = num;

			Console.WriteLine("Address:");
			HumanAdress = new Address();
		}
		public void GetInfo()
		{
			Console.WriteLine($"Name: {Name} Sername: {Surname} Age: {Age}");
			Console.WriteLine("Address: ");
			HumanAdress.GetInfo();
		}
		public static bool operator <(Human humanA, Human humanB)
		{
			return ((humanA.Surname.CompareTo(humanB.Surname)) < 0);
		}
		public static bool operator ==(Human humanA, Human humanB)
		{
			return ((humanA.Surname.CompareTo(humanB.Surname)) == 0);
		}
		public static bool operator !=(Human humanA, Human humanB)
		{
			return ((humanA.Surname.CompareTo(humanB.Surname)) != 0);
		}
		public static bool operator >(Human humanA, Human humanB)
		{
			return ((humanA.Surname.CompareTo(humanB.Surname)) > 0);
		}
	}
}