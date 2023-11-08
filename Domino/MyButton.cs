namespace Domino;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
// using System.

class MyButton : Button
{
	public MyButton()
	{
		// Initialize the button properties, such as size, text, and other settings.
		this.Size = new System.Drawing.Size(100, 30);
		this.Text = "Click Me";
		this.MouseClick += Button_Click;  // Event handler for the click event
		this.MouseEnter += Button_MouseEnter;  // Event handler for mouse enter
		this.MouseLeave += Button_MouseLeave;  // Event handler for mouse leave
	}
			private Label text;

		public MyButton(string name)
		{
			this.Size = new Size(200, 50);
			this.BackColor = Color.DarkCyan;

			text = new Label();
			text.Text = name;
			text.AutoSize = true;
			text.ForeColor = Color.White;
			text.BackColor = Color.Transparent;

			int xPos = (this.Width - text.Width) / 2;
			int yPos = (this.Height - text.Height) / 2;
			text.Location = new Point(xPos, yPos);

			this.Controls.Add(text);

			this.MouseClick += Button_Click;
			this.MouseEnter += Button_MouseEnter;
			this.MouseLeave += Button_MouseLeave;
		}
		public void SetPos(int x, int y)
		{
			this.Size = new Size(x, y);
		}
		public void SetScale(float scale)
		{
			SizeF sizeF = new SizeF();
			sizeF = scale * sizeF;
			 
		}

	private void Button_Click(object sender, MouseEventArgs e)
	{
		OnClick(EventArgs.Empty);
	}

	private void Button_MouseEnter(object sender, EventArgs e)
	{
		this.BackColor = Color.Cyan;
	}

	private void Button_MouseLeave(object sender, EventArgs e)
	{
		this.BackColor = Color.DarkCyan;
	}
}


//Example Program for access MyButton
// class Program
// {
//     [STAThread]
//     static void Main()
//     {
//         Application.EnableVisualStyles();
//         Application.SetCompatibleTextRenderingDefault(false);

//         // Create a Form and add the custom button to it
//         Form form = new Form();
//         MyButton button = new MyButton();
//         form.Controls.Add(button);

//         Application.Run(form);
//     }
// }
