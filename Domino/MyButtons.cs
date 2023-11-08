using System.Drawing;
namespace Domino;

using System;
using System.Windows.Forms;

class MyButton : Button
{
	private Label text;
	public MyButton()
	{
		// Initialize the button properties, such as size, text, and other settings.
		this.Size = new System.Drawing.Size(100, 30);
		this.Text = "Click Me";
		this.Click += Button_Click;  // Event handler for the click event
		this.MouseEnter += Button_MouseEnter;  // Event handler for mouse enter
		this.MouseLeave += Button_MouseLeave;  // Event handler for mouse leave
	}

	public MyButton(string name)
	{
		this.Size = new Size(200, 50);
		this.BackColor = Color.Red;
		
		text = new Label();
		text.Text = name;
		text.AutoSize = true;
		text.ForeColor = Color.White;
		text.BackColor = Color.Transparent;
		
		int xPosition = (this.Width / 2) - (text.Width / 2);
		int yPosition = (this.Height / 2) - (text.Height / 2);
		text.Location = new Point(xPosition, yPosition);
		
		this.Controls.Add(text);
		
		this.MouseClick += Button_Click;
		this.MouseEnter += Button_MouseEnter;
		this.MouseLeave += Button_MouseLeave;
	}
	
	public void SetPos(int x, int y)
	{
		this.Location = new Point(x, y);
	}
	
	public void SetScale(float scale)
	{
		this.Width = (int)(this.Width * scale);
		this.Height = (int)(this.Height * scale);
		
		text.Font = new Font(text.Font.FontFamily, text.Font.Size * scale);
		
		int xPosition = (this.Width / 2) - (text.Width / 2);
		int yPosition = (this.Height / 2) - (text.Height / 2);
		text.Location = new Point(xPosition, yPosition);
	}
	private void Button_Click(object sender, EventArgs e)
	{
		OnClick(EventArgs.Empty);
		// Handle the button click event
		// You can put your code here
	}

	private void Button_MouseEnter(object sender, EventArgs e)
	{
		// Handle the mouse enter event
		// You can put your code here
		this.BackColor = Color.Blue;
	}

	private void Button_MouseLeave(object sender, EventArgs e)
	{
		// Handle the mouse leave event
		// You can put your code here
		this.BackColor = Color.Red;
	}
}

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

