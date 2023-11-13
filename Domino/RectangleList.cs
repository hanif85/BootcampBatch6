namespace Domino;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


	public class RectangleList
	{
		private List<Rectangle> rectangles;

		public RectangleList()
		{
			rectangles = new List<Rectangle>();
		}

		public void AddRectangle(int x, int y, int width, int height, Color color)
		{
			Rectangle rectangle = new Rectangle(x, y, width, height, color);
			rectangles.Add(rectangle);
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
		public int X { get; }
		public int Y { get; }
		public int Width { get; }
		public int Height { get; }
		public Color Color { get; }

		public Rectangle(int x, int y, int width, int height, Color color)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
			Color = color;
		}

		public void Draw(Graphics graphics)
		{
			Brush brush = new SolidBrush(Color);
			graphics.FillRectangle(brush, X, Y, Width, Height);
			brush.Dispose();
		}
	}


// How to use
	// public class MainForm : Form
	// {
	// 	private RectangleList rectangleList;

	// 	public MainForm()
	// 	{
	// 		InitializeComponent();

	// 		rectangleList = new RectangleList();
	// 		// Add the starting point (100, 50) for the first rectangle
	// 		rectangleList.AddRectangle(100, 50, 100, 80, Color.Blue);
	// 		rectangleList.AddRectangle(200, 100, 120, 60, Color.Green);

	// 		// Add a new rectangle with height 1/4 of the screen height and width equal to screen width
	// 		Rectangle fullScreenRectangle = new Rectangle(0, Screen.PrimaryScreen.Bounds.Height/2 + Screen.PrimaryScreen.Bounds.Height/4 , Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height / 4, Color.Red);
			
	// 		rectangleList.AddRectangle(fullScreenRectangle.X, fullScreenRectangle.Y, fullScreenRectangle.Width, fullScreenRectangle.Height, fullScreenRectangle.Color);
	// 	}

	// 	private void InitializeComponent()
	// 	{
	// 		this.Text = "Rectangle List Example";
	// 		this.WindowState = FormWindowState.Maximized; // Make the form fullscreen
	// 		this.Paint += MainForm_Paint;
	// 	}

	// 	private void MainForm_Paint(object sender, PaintEventArgs e)
	// 	{
	// 		// Draw rectangles when the form is painted
	// 		rectangleList.DrawRectangles(e.Graphics);
	// 	}

	// 	[STAThread]
	// 	static void Main()
	// 	{
	// 		Application.EnableVisualStyles();
	// 		Application.SetCompatibleTextRenderingDefault(false);
	// 		Application.Run(new MainForm());
	// 	}
	// }
