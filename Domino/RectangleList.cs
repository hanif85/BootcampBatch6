using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Domino
{
	public class RectangleList
	{
		private List<Rectangle> rectangles;

		public RectangleList()
		{
			rectangles = new List<Rectangle>();
		}
		public RectangleList(int startX, int startY, int gap)
		{
			rectangles = new List<Rectangle>();
			StartX = startX;
			StartY = startY;
			Gap = gap;
		}

		public int StartX { get; set; }
		public int StartY { get; set; }
		public int Gap { get; set; }
		public void AddRectangle(int x, int y, int width, int height, Color color, string text)
		{
			Rectangle rectangle = new Rectangle(x, y, width, height, color, text);
			rectangles.Add(rectangle);
			
			UpdatePositions();
		}

		public void AddRectangleToFront(int x, int y, int width, int height, Color color, string text)
		{
			Rectangle rectangle = new Rectangle(x, y, width, height, color, text);
			rectangles.Insert(0, rectangle);
			UpdatePositions();
		}

		public void AddRectangleToBack(int x, int y, int width, int height, Color color, string text)
		{
			Rectangle rectangle = new Rectangle(x, y, width, height, color, text);
			rectangles.Add(rectangle);
			UpdatePositions();
		}

		public void RemoveRectangle(int index)
		{
			if (index >= 0 && index < rectangles.Count)
			{
				rectangles.RemoveAt(index);
				UpdatePositions();
			}
		}

		public void RemoveFirstRectangle()
		{
			if (rectangles.Count > 0)
			{
				rectangles.RemoveAt(0);
				UpdatePositions();
			}
		}

		public void RemoveLastRectangle()
	{
		if (rectangles.Count > 0)
		{
			rectangles.RemoveAt(rectangles.Count - 1);
		}
	}
private void UpdatePositions()
{
	int currentX = StartX;
	int currentY = StartY;

	foreach (Rectangle rectangle in rectangles)
	{
		rectangle.X = currentX;
		rectangle.Y = currentY;

		currentX += rectangle.Width + Gap;

		if (currentX + rectangle.Width > Screen.PrimaryScreen.Bounds.Width)
		{
			currentX = StartX;
			currentY += rectangle.Height + Gap;
		}
	}
}


		public void DrawRectangles(Graphics graphics)
		{
			foreach (Rectangle rectangle in rectangles)
			{
				rectangle.Draw(graphics);
			}
		}
	}

	public class Rectangle
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; }
		public int Height { get; }
		public Color Color { get; }
		public string Text { get; }

		public Rectangle(int x, int y, int width, int height, Color color, string text)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
			Color = color;
			Text = text;
		}

		public void Draw(Graphics graphics)
		{
			Brush brush = new SolidBrush(Color);
			graphics.FillRectangle(brush, X, Y, Width, Height);
			brush.Dispose();

			// Draw text that fits within the rectangle with bold font
			using (Font originalFont = new Font("Arial", 15, FontStyle.Bold))
			{
				Font adjustedFont = originalFont;

				SizeF textSize = graphics.MeasureString(Text, adjustedFont);

				// Adjust the font size to fit within the rectangle
				while (textSize.Width > Width || textSize.Height > Height)
				{
					adjustedFont = new Font("Arial", adjustedFont.Size - 1, FontStyle.Bold);
					textSize = graphics.MeasureString(Text, adjustedFont);
				}

				float textX = X + (Width - textSize.Width) / 2;
				float textY = Y + (Height - textSize.Height) / 2;

				graphics.DrawString(Text, adjustedFont, Brushes.White, textX, textY);
			}
		}
	}

// How to use RectangleList:

	// public class MainForm : Form
	// {
	// 	public RectangleList rectangleList;
	// 	private Button btnAddToFront;
	// 	private Button btnAddToBack;
	// 	private Button btnRemove;
	// 	private Button btnRemoveFirst;

	// 	public MainForm()
	// 	{
	// 		InitializeComponent();

	// 		rectangleList = new RectangleList();
	// 		rectangleList.AddRectangle(20, 20, 100, 80, Color.Blue, "This is a Blue Rectangle with Long Text");
	// 		rectangleList.AddRectangle(150, 20, 120, 60, Color.Green, "Green Rectangle");

	// 		Rectangle fullScreenRectangle = new Rectangle(20, 150, 100, 80, Color.Red, "Red Rectangle");

	// 		rectangleList.AddRectangle(fullScreenRectangle.X, fullScreenRectangle.Y, fullScreenRectangle.Width, fullScreenRectangle.Height, fullScreenRectangle.Color, fullScreenRectangle.Text);

	// 		btnAddToFront = new Button();
	// 		btnAddToFront.Text = "Add to Front";
	// 		btnAddToFront.Location = new Point(20, 20);
	// 		btnAddToFront.Click += BtnAddToFront_Click;

	// 		btnAddToBack = new Button();
	// 		btnAddToBack.Text = "Add to Back";
	// 		btnAddToBack.Location = new Point(120, 20);
	// 		btnAddToBack.Click += BtnAddToBack_Click;

	// 		btnRemove = new Button();
	// 		btnRemove.Text = "Remove Last";
	// 		btnRemove.Location = new Point(220, 20);
	// 		btnRemove.Click += BtnRemove_Click;

	// 		btnRemoveFirst = new Button();
	// 		btnRemoveFirst.Text = "Remove First";
	// 		btnRemoveFirst.Location = new Point(320, 20);
	// 		btnRemoveFirst.Click += BtnRemoveFirst_Click;

	// 		Controls.Add(btnAddToFront);
	// 		Controls.Add(btnAddToBack);
	// 		Controls.Add(btnRemove);
	// 		Controls.Add(btnRemoveFirst);
	// 	}

	// 	private void BtnAddToFront_Click(object sender, EventArgs e)
	// 	{
	// 		rectangleList.AddRectangleToFront(0, 0, 100, 80, Color.Orange, "Added to Front");
	// 		Refresh(); // Refresh the form to trigger repaint
	// 	}

	// 	private void BtnAddToBack_Click(object sender, EventArgs e)
	// 	{
	// 		rectangleList.AddRectangleToBack(0, 0, 100, 80, Color.Purple, "Added to Back");
	// 		Refresh(); // Refresh the form to trigger repaint
	// 	}

	// 	private void BtnRemove_Click(object sender, EventArgs e)
	// 	{
	// 		// Remove the last rectangle
	// 		rectangleList.RemoveLastRectangle();
	// 		Refresh(); // Refresh the form to trigger repaint
	// 	}

	// 	private void BtnRemoveFirst_Click(object sender, EventArgs e)
	// 	{
	// 		// Remove the first rectangle
	// 		rectangleList.RemoveFirstRectangle();
	// 		Refresh(); // Refresh the form to trigger repaint
	// 	}

	// 	private void InitializeComponent()
	// 	{
	// 		Text = "Rectangle List Example";
	// 		WindowState = FormWindowState.Maximized;
	// 		Paint += MainForm_Paint;
	// 	}

	// 	// Inside the MainForm class
	// 	private void MainForm_Paint(object sender, PaintEventArgs e)
	// 	{
	// 		rectangleList.DrawRectangles(e.Graphics);
	// 	}

	// 	// [STAThread]
	// 	// static void Main()
	// 	// {
	// 	// 	Application.EnableVisualStyles();
	// 	// 	Application.SetCompatibleTextRenderingDefault(false);
	// 	// 	Application.Run(new MainForm());
	// 	// }
	// }
}
