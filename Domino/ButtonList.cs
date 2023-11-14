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

		public ButtonList(Orientation orientation = Orientation.Horizontal, int startX = 50, int startY = 50)
		{
			buttons = new List<Button>();
			this.orientation = orientation;
			this.StartX = startX;
			this.StartY = startY;
		}

		public int StartX { get; set; }
		public int StartY { get; set; }

		public void AddButtons(string[] buttonTexts, Color buttonColor, Size buttonSize, EventHandler clickHandler = null)
		{
			foreach (string buttonText in buttonTexts)
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

		public void RemoveButton(Button button)
		{
			if (buttons.Contains(button))
			{
				int removedIndex = buttons.IndexOf(button);
				buttons.Remove(button);
				button.Parent.Controls.Remove(button);

				// Reposition the remaining buttons after the removed button
				for (int i = removedIndex; i < buttons.Count; i++)
				{
					int x = buttons[i].Location.X;
					int y = buttons[i].Location.Y;

					if (orientation == Orientation.Vertical)
					{
						y -= button.Size.Height + 10; // Adjust for the removed button
						buttons[i].Location = new Point(x, y);
					}
					else // Orientation.Horizontal
					{
						x -= button.Size.Width + 10; // Adjust for the removed button
						buttons[i].Location = new Point(x, y);
					}
				}
			}
		}

		public ContextMenuStrip CreateContextMenu(EventHandler headButtonClick, EventHandler tailButtonClick)
		{
			ContextMenuStrip contextMenu = new ContextMenuStrip();

			ToolStripMenuItem headButtonMenuItem = new ToolStripMenuItem("HeadButton");
			headButtonMenuItem.Click += headButtonClick;

			ToolStripMenuItem tailButtonMenuItem = new ToolStripMenuItem("TailButton");
			tailButtonMenuItem.Click += tailButtonClick;

			contextMenu.Items.Add(headButtonMenuItem);
			contextMenu.Items.Add(tailButtonMenuItem);

			return contextMenu;
		}
	}

	// public partial class TestButtonList : Form
	// {
	// 	private ButtonList buttonList;

	// 	public TestButtonList()
	// 	{
	// 		InitializeComponent();
	// 		// Set the form to fullscreen
	// 		this.WindowState = FormWindowState.Maximized;

	// 		// Initialize ButtonList
	// 		buttonList = new ButtonList(Orientation.Horizontal, 50, 50);

	// 		// Add buttons to ButtonList
	// 		buttonList.AddButtons(new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" },
	// 							  Color.Blue, new Size(24, 20), ClickButton);

	// 		// Add buttons to the form
	// 		buttonList.AddButtonsToForm(this);
	// 	}

	// 	private void ClickButton(object sender, EventArgs e)
	// 	{
	// 		Button btn = (Button)sender;
	// 		// MessageBox.Show("You clicked character [" + btn.Text + "]");

	// 		// Create and show context menu
	// 		ContextMenuStrip contextMenu = buttonList.CreateContextMenu(HeadButtonClick, TailButtonClick);
	// 		contextMenu.BackColor = Color.SeaGreen;
	// 		btn.ContextMenuStrip = contextMenu;
	// 		contextMenu.Show(btn, new Point(0, btn.Height));

	// 		// Example: Remove the clicked button
	// 		contextMenu.ItemClicked += (s, e) =>
	// 		{
	// 			if (e.ClickedItem.Text == "HeadButton" || e.ClickedItem.Text == "TailButton")
	// 			{
	// 				// Do something when HeadButton is clicked
	// 				buttonList.RemoveButton(btn);
	// 			}

	// 		};


	// 	}

	// 	private void HeadButtonClick(object sender, EventArgs e)
	// 	{
	// 		MessageBox.Show("HeadButton clicked!");
	// 	}

	// 	private void TailButtonClick(object sender, EventArgs e)
	// 	{
	// 		MessageBox.Show("TailButton clicked!");
	// 	}

	// 	private void InitializeComponent()
	// 	{
	// 		this.Text = "Button List Example";
	// 	}

	// 	[STAThread]
	// 	static void Main()
	// 	{
	// 		Application.EnableVisualStyles();
	// 		Application.SetCompatibleTextRenderingDefault(false);
	// 		Application.Run(new TestButtonList());
	// 	}
	// }

}
