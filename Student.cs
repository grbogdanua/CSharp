using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
	class Student: Human
	{
		public Mark Grade { get; private set; }

		public Student(string name, string surname, int age, Address address, Mark mark)
		{
			Name = name;
			Surname = surname;
			Age = age;
			HumanAdress = address;
			Grade = mark;
		}
		public Student(string surname)
		{
			Surname = surname;
		}
		public Student()
		{
			Console.Write("Name: ");
			Name = Console.ReadLine();

			Console.Write("Surname: ");
			Surname = Console.ReadLine();

			Console.Write("Age: ");
			var enteredAge = Console.ReadLine();
			int num;
			while (!int.TryParse(enteredAge, out num))
			{
				Console.Write("Age isn`t number. Try again. Age: ");
				enteredAge = Console.ReadLine();
			}
			Age = num;

			Console.WriteLine("Address:");
			HumanAdress = new Address();

			Grade = new Mark();
		}
		public void ChengeHuman()
		{
			bool cycle = true;
			while (cycle)
			{

			}
		}
		public void Getinfo()
		{
			GetInfo();
			Grade.GetInfo();
			
		}
	}
}
