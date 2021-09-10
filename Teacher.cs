using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
	class Teacher: Human
	{
		public List<Student> Students { get; private set; }

		public Teacher(string name, string surname, int age, Address address)
		{
			Name = name;
			Surname = surname;
			Age = age;
			HumanAdress = address;
		}
		public Teacher(string surname)
		{
			Surname = surname;
		}
		public Teacher()
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
		}
		public void AddStudent(Student student)
		{
			Students.Add(student);
		}
		public void AddStudent()
		{
			Student student = new Student();
			Students.Add(student);
		}
		public void SerchStudent(Student currentstudent)
		{
			foreach(Student student in Students)
			{
				if(student == currentstudent)
				{
					student.Getinfo();
				}
			}
		}
		public void ChengeStudent(Student currentstudent)
		{
			foreach (Student student in Students)
			{
				if (student == currentstudent)
				{
					student.ChengeHuman();
				}
			}
		}
		public void Getinfo()
		{
			Console.WriteLine("Teacher:");
			GetInfo();
			Console.WriteLine("Students: ");
			foreach(Student student in Students)
			{
				Console.WriteLine("\n");
				student.Getinfo();
			}
		}
		public void WorkWith()
		{
			bool cycle = true;
			while (cycle)
			{
				Console.WriteLine("1 <- add student\n2 <- serch student\n3 <- Chenge student\n4 <- Chenge Teacher`s address\n5 <- Stop");
				var enterednumber = Console.ReadLine();
				switch (enterednumber)
				{
					case "1":
						AddStudent();
						break;
					case "2":
						Console.Write("Students Sername please: ");
						SerchStudent(new Student(Console.ReadLine()));
						break;
					case "3":
						Console.Write("Students Sername please: ");
						ChengeStudent(new Student(Console.ReadLine()));
						break;
					case "4":
						break;
					case "5":
						cycle = false;
						break;
					default:
						Console.WriteLine("You write something wrong");
						break;
				}
			}
		}
	}
}
