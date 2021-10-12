
namespace Game
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Cancel = new System.Windows.Forms.Button();
			this.Ok = new System.Windows.Forms.Button();
			this.Number = new System.Windows.Forms.Label();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.richTextBoxAnsver = new System.Windows.Forms.RichTextBox();
			this.ExceptionLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(216, 281);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 1;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// Ok
			// 
			this.Ok.Location = new System.Drawing.Point(464, 281);
			this.Ok.Name = "Ok";
			this.Ok.Size = new System.Drawing.Size(75, 23);
			this.Ok.TabIndex = 2;
			this.Ok.Text = "Ok";
			this.Ok.UseVisualStyleBackColor = true;
			this.Ok.Click += new System.EventHandler(this.Ok_Click);
			// 
			// Number
			// 
			this.Number.AutoSize = true;
			this.Number.Location = new System.Drawing.Point(17, 40);
			this.Number.Name = "Number";
			this.Number.Size = new System.Drawing.Size(44, 13);
			this.Number.TabIndex = 3;
			this.Number.Text = "Number";
			this.Number.Click += new System.EventHandler(this.Number_Click);
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Location = new System.Drawing.Point(95, 40);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
			this.textBoxNumber.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxNumber);
			this.groupBox1.Controls.Add(this.Number);
			this.groupBox1.Location = new System.Drawing.Point(263, 113);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(216, 139);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// richTextBoxAnsver
			// 
			this.richTextBoxAnsver.Location = new System.Drawing.Point(559, 93);
			this.richTextBoxAnsver.Name = "richTextBoxAnsver";
			this.richTextBoxAnsver.Size = new System.Drawing.Size(203, 176);
			this.richTextBoxAnsver.TabIndex = 7;
			this.richTextBoxAnsver.Text = "";
			// 
			// ExceptionLabel
			// 
			this.ExceptionLabel.AutoSize = true;
			this.ExceptionLabel.Location = new System.Drawing.Point(355, 62);
			this.ExceptionLabel.Name = "ExceptionLabel";
			this.ExceptionLabel.Size = new System.Drawing.Size(0, 13);
			this.ExceptionLabel.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 450);
			this.Controls.Add(this.ExceptionLabel);
			this.Controls.Add(this.richTextBoxAnsver);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Ok);
			this.Controls.Add(this.Cancel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Ok;
		private System.Windows.Forms.Label Number;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox richTextBoxAnsver;
		private System.Windows.Forms.Label ExceptionLabel;
	}
}

