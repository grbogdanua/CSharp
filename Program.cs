using System;

namespace CSharp
{
	class Program
	{
		public void WorkWithTeacher(string teachersername)
		{

		}
		static void Main(string[] args)
		{
			TeacherList teachers = new TeacherList();
			while (true)
			{
				Console.WriteLine("1 <- Load from XML File.\n2 <- Add teacher. \n3 <- serch Teacher.\n4 <- selekt \n5 <- Get info from all.\n6 <- save in XML File. ");
				var choise = Console.ReadLine();
				switch (choise)
				{
					//case 1:

					case "2":
						teachers.AddTeacher();
						break;
					case "3":
						Console.Write("Surname: ");
						teachers.Serch(new Teacher(Console.ReadLine()));
						break;
					case "4":
						Console.Write("Surname: ");
						teachers.WorkWithTeacher(new Teacher(Console.ReadLine()));
						break;
					case "5":
						teachers.GetInfo();
						break;
					//case 5:
				}
			}

		}
	}
}
