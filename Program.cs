using System;
using System.IO;
using System.Xml.Serialization;

namespace CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			TeacherList teachers = new TeacherList();
			XmlSerializer serializer = new XmlSerializer(typeof(TeacherList));
			while (true)
			{
				Console.WriteLine("1 <- Load from XML File.\n2 <- Add teacher. \n3 <- serch Teacher.\n4 <- selekt Teacher \n5 <- Get info from all.\n6 <- save in XML File. ");
				var choise = Console.ReadLine();
				switch (choise)
				{
					case "1":
						using (FileStream fs = new FileStream("Teachers.xml", FileMode.OpenOrCreate))
						{
							teachers = (TeacherList)serializer.Deserialize(fs);

							Console.WriteLine("The object is deserialized");
						}
						using (FileStream fs= new FileStream("Teachers.xml", FileMode.OpenOrCreate))
						{
							serializer.Serialize(fs, teachers);
						}
						break;
					case "2":
						teachers.AddTeacher();
						break;
					case "3":
						Console.Write("Surname: ");
						teachers.Serch(Console.ReadLine());
						break;
					case "4":
						Console.Write("Surname: ");
						teachers.WorkWithTeacher(Console.ReadLine());
						break;
					case "5":
						teachers.GetInfo();
						break;
					case "6":
						using (FileStream fs = new FileStream("Teachers.xml", FileMode.OpenOrCreate))
						{
							serializer.Serialize(fs, teachers);
						}
						break;
					default:
						Console.WriteLine("You write something wrong");
						break;
				}
			}

		}
	}
}
