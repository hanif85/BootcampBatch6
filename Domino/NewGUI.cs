using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Domino
{
	public class NewGUI : Form1
	{
		private RectangleList rectangleList;
		private RectangleList listHeader;
		private RectangleList listFooter;
		private ButtonList verticalButtonList;
		private ButtonList horizontalButtonList;
		private int screenWidth = Screen.PrimaryScreen.Bounds.Width ;
		private int screenHeight = Screen.PrimaryScreen.Bounds.Height;

		public NewGUI()
		{

			InitializeComponent();
			listHeader = new RectangleList(0, 0, 0);
			rectangleList = new RectangleList(0, 400, 10);
			// Add the starting point (100, 50) for the first rectangle with text "Blue Rectangle"
			listHeader.AddRectangle(0, 0, screenWidth, screenHeight / 8, Color.Blue, "Dominos let Start");
			listHeader.AddRectangle(0, (screenHeight / 8), screenWidth, (screenHeight / 8), Color.Blue, "the machine card n Left");
			listFooter = new RectangleList(0, (screenHeight / 2 + screenHeight / 4), 0);
			// Add a rectangle with text "Green Rectangle"
			// rectangleList.AddRectangle(0, (screenHeight / 2 + screenHeight / 4) - 50, 120, 60, Color.Green, "0 | 0");
			// rectangleList.AddRectangle(130, (screenHeight / 2 + screenHeight / 4) - 50, 120, 60, Color.Green, "4 | 3");
			// rectangleList.AddRectangle(260, (screenHeight / 2 + screenHeight / 4) - 50, 120, 60, Color.Green, "5 | 1");
			// rectangleList.AddRectangle(390, (screenHeight / 2 + screenHeight / 4) - 50, 120, 60, Color.Green, "6 | 3");


			// Add a new rectangle with height 1/4 of the screen height and width equal to screen width, and text "Red Rectangle"
			Rectangle fullScreenRectangle = new Rectangle(0, (screenHeight* 3/ 4) , screenWidth, screenHeight/ 4, Color.Red, "You still have n Card");

			listFooter.AddRectangle(fullScreenRectangle.X, fullScreenRectangle.Y, fullScreenRectangle.Width, fullScreenRectangle.Height, fullScreenRectangle.Color, fullScreenRectangle.Text);


			// verticalButtonList = new ButtonList(Orientation.Vertical, 50, 50);
			// verticalButtonList.AddButton("Vertical Button 1", VerticalButton1_Click, Color.Blue, new Size(80, 30));
			// verticalButtonList.AddButton("Vertical Button 2", VerticalButton2_Click, Color.Green, new Size(120, 40));

			// verticalButtonList.AddButtonsToForm(this);

			horizontalButtonList = new ButtonList(Orientation.Horizontal, 0, (Screen.PrimaryScreen.Bounds.Height / 2 + Screen.PrimaryScreen.Bounds.Height / 4) + 20);
			String[] textButton = { "1 | 6", "2 | 5", "3 | 4", "4 | 3", "5 | 2", "6 | 1"};
			horizontalButtonList.AddButtons(textButton, Color.DarkOrange, new Size(120, 60), HorizontalButton_Click);
			// horizontalButtonList.AddButton("Card 2", HorizontalButton2_Click, Color.DarkOrange, new Size(120, 60));
			// horizontalButtonList.AddButton("Card 3", HorizontalButton1_Click, Color.DarkOrange, new Size(120, 60));
			// horizontalButtonList.AddButton("Card 4", HorizontalButton2_Click, Color.DarkOrange, new Size(120, 60));
			// horizontalButtonList.AddButton("Card 5", HorizontalButton1_Click, Color.DarkOrange, new Size(120, 60));
			// horizontalButtonList.AddButton("Card 6", HorizontalButton2_Click, Color.DarkOrange, new Size(120, 60));
			horizontalButtonList.AddButtonsToForm(this);
		}

		private void InitializeComponent()
		{
			this.Text = "Dominos";
			this.WindowState = FormWindowState.Maximized; // Make the form fullscreen
			this.Paint += MainForm_Paint;
		}

		private void MainForm_Paint(object? sender, PaintEventArgs e)
		{
			// Draw rectangles when the form is painted
			rectangleList.DrawRectangles(e.Graphics);
			listHeader.DrawRectangles(e.Graphics);
			listFooter.DrawRectangles(e.Graphics);
		}

		private void VerticalButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Vertical Button 1 clicked!");
		}

		private void VerticalButton2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Vertical Button 2 clicked!");
		}

		private void HorizontalButton_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			// MessageBox.Show("You clicked character [" + btn.Text + "]");

			// Create and show context menu
			ContextMenuStrip contextMenu = horizontalButtonList.CreateContextMenu(HeadButtonClick, TailButtonClick);
			contextMenu.BackColor = Color.SeaGreen;
			btn.ContextMenuStrip = contextMenu;
			contextMenu.Show(btn, new Point(0, btn.Height));

			// Example: Remove the clicked button
			contextMenu.ItemClicked += (s, e) =>
			{

				if (e.ClickedItem?.Text == "HeadButton")
				{
					// Do something when HeadButton is clicked
					// MessageBox.Show("Card 1 clicked!");
					rectangleList.AddRectangleToFront(0, (screenHeight / 2 + screenHeight / 4) - 50, 100, 80, Color.Orange, $"{btn.Text}");
					horizontalButtonList.RemoveButton(btn);
					Refresh();
				}
				else if (e.ClickedItem?.Text == "TailButton")
				{
					// Do something when HeadButton is clicked
					// MessageBox.Show("Card 1 clicked!");
					rectangleList.AddRectangleToBack(0, (screenHeight / 2 + screenHeight / 4)-50, 100, 80, Color.Orange, $"{btn.Text}Back");
					horizontalButtonList.RemoveButton(btn);
					Refresh();
				}

			};

		}
		private void BtnAddToFront_Click(object? sender, EventArgs e)
		{
			rectangleList.AddRectangleToFront(0, 0, 100, 80, Color.Orange, "Added to Front");
			Refresh(); // Refresh the form to trigger repaint
		}

		private void BtnAddToBack_Click(object? sender, EventArgs e)
		{
			rectangleList.AddRectangleToBack(0, 0, 100, 80, Color.Purple, "Added to Back");
			Refresh(); // Refresh the form to trigger repaint
		}

		private void HeadButtonClick(object? sender, EventArgs e)
		{
			// MessageBox.Show("HeadButton clicked!");
		}

		private void TailButtonClick(object? sender, EventArgs e)
		{
			// MessageBox.Show("TailButton clicked!");
		}


		// [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new NewGUI());
		}

	}
}
