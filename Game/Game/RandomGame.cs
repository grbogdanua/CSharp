using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class RandomGame
	{
		private int defaultTryes;
		private int leftTryes;
		private int randomNum;
		public RandomGame(int newnum)
		{
			defaultTryes = newnum;
			Random num = new Random();
			randomNum = num.Next(0, 100);
		}
		public bool HasTries
		{
			get
			{
				return leftTryes > 0;
			}
		}
		public void Start()
		{
			leftTryes = defaultTryes;
		}
		public void CheckTry(int num,out bool win,out bool isGreater)
		{
			if (num == randomNum)
			{
				//Console.WriteLine("You won");
				win = true;
				isGreater = false;
			}
			else
			{
				if (num > randomNum)
				{
					isGreater = true;
				}
				else
				{
					isGreater = false;
				}
				//Console.WriteLine("You lost try");
				leftTryes -= 1;
				//Console.WriteLine($"Your Tryes:{leftTryes}");
				win = false;
			}
		}
	}
}
