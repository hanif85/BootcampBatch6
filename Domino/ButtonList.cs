using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Domino
{
	public class ButtonList
	{
		private List<Button> buttons;
		private Orientation orientation;

		public Orientation Orientation
		{
			get { return orientation; }
			set { orientation = value; }
		}

		public ButtonList(Orientation orientation = Orientation.Vertical, int startX = 50, int startY = 50)
		{
			buttons = new List<Button>();
			this.orientation = orientation;
			this.StartX = startX;
			this.StartY = startY;
		}

		public int StartX { get; set; }
		public int StartY { get; set; }

		public void AddButton(string buttonText, EventHandler clickHandler, Color buttonColor, Size buttonSize)
		{
			Button button = new Button();
			button.Text = buttonText;
			button.Size = buttonSize;
			button.BackColor = buttonColor;
			buttons.Add(button);

			if (clickHandler != null)
			{
				button.Click += clickHandler;
			}
		}

		public void AddButtonsToForm(Form form)
		{
			int x = StartX;
			int y = StartY;

			foreach (Button button in buttons)
			{
				button.Location = new Point(x, y);

				if (orientation == Orientation.Vertical)
				{
					y += button.Size.Height + 10; // Add some spacing between vertical buttons
				}
				else // Orientation.Horizontal
				{
					x += button.Size.Width + 10; // Add some spacing between horizontal buttons
				}

				form.Controls.Add(button);
			}
		}
	}


// How to Use
	// public class TestButtonList : Form
	// {
	// 	private ButtonList verticalButtonList;
	// 	private ButtonList horizontalButtonList;

	// 	public TestButtonList()
	// 	{
	// 		InitializeComponent();
	// 		// Set the form to fullscreen
	// 		this.WindowState = FormWindowState.Maximized;

	// 		verticalButtonList = new ButtonList(Orientation.Vertical, 50, 50);
	// 		verticalButtonList.AddButton("Vertical Button 1", VerticalButton1_Click, Color.Blue, new Size(80, 30));
	// 		verticalButtonList.AddButton("Vertical Button 2", VerticalButton2_Click, Color.Green, new Size(120, 40));

	// 		verticalButtonList.AddButtonsToForm(this);

	// 		horizontalButtonList = new ButtonList(Orientation.Horizontal, 50, 200);
	// 		horizontalButtonList.AddButton("Horizontal Button 1", HorizontalButton1_Click, Color.Red, new Size(80, 30));
	// 		horizontalButtonList.AddButton("Horizontal Button 2", HorizontalButton2_Click, Color.Orange, new Size(120, 40));

	// 		horizontalButtonList.AddButtonsToForm(this);
	// 	}

	// 	private void InitializeComponent()
	// 	{
	// 		this.Text = "Button List Example";
	// 	}

	// 	private void VerticalButton1_Click(object sender, EventArgs e)
	// 	{
	// 		MessageBox.Show("Vertical Button 1 clicked!");
	// 	}

	// 	private void VerticalButton2_Click(object sender, EventArgs e)
	// 	{
	// 		MessageBox.Show("Vertical Button 2 clicked!");
	// 	}

	// 	private void HorizontalButton1_Click(object sender, EventArgs e)
	// 	{
	// 		MessageBox.Show("Horizontal Button 1 clicked!");
	// 	}

	// 	private void HorizontalButton2_Click(object sender, EventArgs e)
	// 	{
	// 		MessageBox.Show("Horizontal Button 2 clicked!");
	// 	}

		// [STAThread]
		// static void Main()
		// {
		//     Application.EnableVisualStyles();
		//     Application.SetCompatibleTextRenderingDefault(false);
		//     Application.Run(new TestButtonList());
		// }
	// }
}
