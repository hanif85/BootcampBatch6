using System;
using System.Drawing;
using System.Windows.Forms;

namespace Domino
{
	public class NewGUI : Form1
	{
		private StartButton startButton;
		private StartButton exitButton;
		private Label label1;

		public NewGUI()
		{
			InitializeComponent();

			startButton = new StartButton("Start Game");
			exitButton = new StartButton("Exit Game");
			label1 = new Label();
			// ButtonList buttonList = new ButtonList();
			// buttonList.init
			CenterControls();

			this.Controls.Add(startButton);
			this.Controls.Add(exitButton);
			this.Controls.Add(label1);
			

			// Wire up the click event handler for the StartButton
			startButton.Click += StartButton_Click;
			exitButton.Click += ExitButton_Click;
		}

		private void InitializeComponent()
		{
			this.Text = "NewGUI";
			this.Size = new Size(400, 300);
			this.Resize += NewGUI_Resize;
		}

		private void CenterControls()
		{
			CenterControl(startButton, 50);
			CenterControl(exitButton, 100);

			label1.Text = "Dominos Game";
			label1.Font = new Font(label1.Font.FontFamily, 20, FontStyle.Bold);
			CenterControl(label1, 150);
			label1.AutoSize = true; // Ensure label adjusts its size based on content
		}

		private void CenterControl(Control control, int y)
		{
			int x = (ClientSize.Width - control.Width) / 2;
			control.Location = new Point(x, y);
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			// // Clear the form
			// this.Controls.Clear();
			
			// ButtonList buttonList = new ButtonList();
			
			// // buttonList.ControlAddButton(buttonList.InitializeButtonList());
			// // Display "Let's play" in a new label
			// var listButton = new ButtonList();
			// Label playLabel = new Label();
			// // playLabel.Text = "Let's play";
			// playLabel.Font = new Font(playLabel.Font.FontFamily, 30, FontStyle.Bold);
			// CenterControl(playLabel, 150);
			// playLabel.AutoSize = true;
			// this.BackColor = Color.BurlyWood;
			// this.Controls.Add(playLabel);
			// foreach (var n in new ButtonList())
			// {
			// 	this.Controls.Add(listButton);
			// }
			
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			// Handle the ExitButton click event
			MessageBox.Show("Game Ended!!!");
			System.Windows.Forms.Application.Exit();
		}

		private void NewGUI_Resize(object sender, EventArgs e)
		{
			// Handle the form resize event
			CenterControls();
		}
	}

	// static class Program
	// {
	// 	[STAThread]
	// 	static void Main()
	// 	{
	// 		Application.EnableVisualStyles();
	// 		Application.SetCompatibleTextRenderingDefault(false);
	// 		Application.Run(new NewGUI());
	// 	}
	// }
}
