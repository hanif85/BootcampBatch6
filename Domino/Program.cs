namespace Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
 
	public partial class MainForm : Form
	{
		public MainForm()
		{
	//  InitializeComponent();

	// Create a StartButton instance
			StartButton startButton = new StartButton("Start Game");
			StartButton exitButton = new StartButton("Exit Game");

			// Set button properties
			//startButton.Size = new Size(100, 130);
			//exitButton.Size = new Size(100, 130);
			
			// Set button locations
			startButton.Location = new Point(50, 50);  // Adjust the location as needed
			exitButton.Location = new Point(50, 100);   // Adjust the location as needed

			// Add the StartButton to the form's controls
			this.Controls.Add(startButton);
			this.Controls.Add(exitButton);

			// Wire up the click event handler for the StartButton
			startButton.Click += StartButton_Click;
			exitButton.Click += ExitButton_Click;
		}
		

		private void StartButton_Click(object sender, EventArgs e)
		{
			// Handle the StartButton click event
			MessageBox.Show("Game Started!!!");
		   // MessageBox.Show("Game Started!!!");
		}
		private void ExitButton_Click(object sender, EventArgs e)
		{
			// Handle the StartButton click event
			MessageBox.Show("Game Ended!!!");
			System.Windows.Forms.Application.Exit( );
			// MessageBox.Show("Game Started!!!");
		}

		// Other form initialization code and event handlers
	}

	// static class Program
	// {
	// 	[STAThread]
	// 	static void Main()
	// 	{
	// 		Application.EnableVisualStyles();
	// 		Application.SetCompatibleTextRenderingDefault(false);
	// 		            // Create an instance of GameController
    //         GameController gameController = new GameController();

    //         // Display the main menu
    //         gameController.DisplayMainMenu();

    //         // Run the application
    //         Application.Run(gameController);
	// 		// Application.Run(new MainForm());
	// 	}
	// }