using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
	class TeacherList
	{
		public List<Teacher> Teachers { get; private set; }

		public TeacherList(List<Teacher> teachers)
		{
			Teachers.AddRange(teachers);
		}
		public TeacherList(Teacher teacher)
		{
			Teachers.Add(teacher);
		}
		public TeacherList()
		{
			
		}

		public void AddTeacher(Teacher teacher)
		{
			Teachers.Add(teacher);
		}
		public void AddTeacher()
		{
			Teacher teacher = new Teacher();
			Teachers.Add(teacher);
		}
		public void SortTechers()
		{
			Teachers.Sort();
		}
		public void GetInfo()
		{
			foreach(Teacher teacher in Teachers)
			{
				teacher.Getinfo();
			}
		}
		public void Serch(Teacher currentteacher)
		{
			foreach (Teacher teacher in Teachers)
			{
				if(teacher == currentteacher)
				{
					teacher.Getinfo();
				}
			}
		}
		public void WorkWithTeacher(Teacher currentteacher)
		{
			foreach (Teacher teacher in Teachers)
			{
				if (teacher == currentteacher)
				{
					teacher.WorkWith();
				}
			}
		}
	}
}
