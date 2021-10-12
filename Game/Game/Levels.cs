using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class Levels
	{
		private List<RandomGame> levels;
		private int level = 0;
		private int Maxlevels = 0;
		public Levels()
		{
			levels = new List<RandomGame> { };
		}
		public void AddLevel(int tries)
		{
			levels.Add(new RandomGame(tries));
			Maxlevels += 1;
		}
		public void Game(int num,out string Text)
		{
			var curentGame = levels[level];
			curentGame.Start();
			curentGame.CheckTry(num, out bool win, out bool isGreater);
			if (win)
			{
				level += 1;
				if (level < Maxlevels)
				{
					Text = "Next level";
				}
				else
				{
					Text = "You won the game.";
				}
			}
			else
			{
				if (curentGame.HasTries)
				{
					if (isGreater)
					{
						Text = "You lost try \n Your number is greater";
					}
					else
					{
						Text = "You lost try \n Your number is smaller";
					}
				}
				else
				{
					Text = "You lose the level.";
					if (level == 0)
					{
						Text = Text + "\n You lose the game";
					}
					else
					{
						level -= 1;
					}
				}
			}

		}
		/*public void Game()
		{
			while (level < Maxlevels)
			{
				var curentGame = levels[level];
				curentGame.Start();
				bool isWin = false;
				do
				{
					Console.Write("Write your number:");
					var enterednum = Console.ReadLine();
					int num;
					while (!int.TryParse(enterednum, out num))
					{
						enterednum = Console.ReadLine();
					}
					isWin = curentGame.CheckTry(num);
				} while (curentGame.HasTries || !isWin);
				if (isWin)
				{
					level += 1;
					if(level < Maxlevels)
					{
						Console.WriteLine("Next level");
					}

				}
				else
				{
					if (level != 0)
					{
						level -= 1;
					}
					else
					{
						break;
					}
				}
			}
			if (level == Maxlevels)
			{
				Console.WriteLine("You won the game.");
			}
			else
			{
				Console.WriteLine("You lose the game.");
			}
		}*/
	}
}
