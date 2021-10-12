using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
	public partial class Form1 : Form
	{
		public Levels Levels { get; set; }
		public Form1(Levels newlevels)
		{
			InitializeComponent();
			//this.Ok.Enabled = false;
			this.Levels = newlevels;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Number_Click(object sender, EventArgs e)
		{

		}

		private void Ok_Click(object sender, EventArgs e)
		{
			IntFromTextBox(out bool isParseable, out int number);
			if (isParseable)
			{
				Levels.Game(number,out string Text);
				this.richTextBoxAnsver.Text = Text;
				this.ExceptionLabel.Text = "";
			}
			else
			{
				this.ExceptionLabel.Text = "number is invalid";
			}
		}
		private void IntFromTextBox(out bool isParseable,out int num)
		{
			var enterednum = this.textBoxNumber.Text;
			isParseable = int.TryParse(enterednum, out num);
		}
	}
}
