using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
	public enum StudentTipe
	{
		excellent,
		good,
		bad,
		stupid,
		verystupid
	}
	class Mark
	{
		public int[] Marks {  get;  set; }
		public StudentTipe AverageMark { get; private set; }

		public Mark(int[] marks)
		{
			Marks = marks;
			AverageMark = Average(Marks);
		}
		public Mark()
		{
			Console.WriteLine("Please write 5 marks.");
			Console.Write("Mark: ");
			Marks = new int[5];
			var enteredMark = Console.ReadLine();
			for (int i=0; i < 5;i++)
			{
				int num;
				if (!int.TryParse(enteredMark, out num))
				{
					Console.WriteLine("Mark isn`t number. Try again.");
				}
				else
				{
					Marks[i]=num;
				}
				Console.Write("Mark: ");
				enteredMark = Console.ReadLine();
			}
			AverageMark = Average(Marks);
		}
		private StudentTipe Average(int[] marks)
		{
			int summ = 0;
			int count = 0;
			foreach (int mark in Marks)
			{
				summ += mark;
				count += 1;
			}
			switch (summ / count)
			{
				case 5:
					return (StudentTipe.excellent);
				case 4:
					return (StudentTipe.good);
				case 3:
					return (StudentTipe.bad);
				case 2:
					return (StudentTipe.stupid);
				default:
					return (StudentTipe.verystupid);
			}
		}
		public void GetInfo()
		{
			Console.WriteLine($"Average Mark: {AverageMark}.");
		}
	}
}
