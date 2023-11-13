using System;
using System.Windows.Forms;
using System.Drawing;

namespace Domino
{
	public class GameController : Form1
	{
		public Board board;
		public CsDomino dominoOBJ;
		public CsPlayer[] playerOBJ;
		private int turn;
		public Graphics scene;
		Panel drawingPanel;

		public GameController()
		{
			this.DoubleBuffered = true;
			this.Width = 1024;
			this.Height = 768;
			this.BackgroundImageLayout = ImageLayout.Stretch;

			dominoOBJ = new CsDomino(2);
			dominoOBJ.API();
			playerOBJ = new CsPlayer[2];
			Board board = null;

			if (dominoOBJ != null)
			{
				board = new Board(playerOBJ, dominoOBJ);
				playerOBJ[0] = new CsPlayer(dominoOBJ);
				playerOBJ[1] = new CsPlayer(dominoOBJ);
				playerOBJ[0].API(dominoOBJ);
				playerOBJ[1].API(dominoOBJ);
			}

			CsRandom n = new CsRandom();
			turn = n.GetRandomPublic(0, 1);

			drawingPanel = new Panel();
			drawingPanel.Dock = DockStyle.Fill;
			this.Controls.Add(drawingPanel);

			DisplayMainMenu();
		}

		private void clearBoard()
		{
			this.Controls.Clear();
		}

		private void start()
		{
			clearBoard();

			System.Media.SoundPlayer player = new System.Media.SoundPlayer("domino.wav");
			player.Play();

			long ticks = DateTime.Now.Ticks;
			Random random = new Random((int)(ticks & 0xFFFFFFFF));

			board.API(playerOBJ, dominoOBJ, ref turn);
		}

		public void DisplayMainMenu()
		{
			// Form form = new Form();
			// InitializeComponent();
			Label titleText = new Label();
			titleText.Text = "Oh, Domino!";
			titleText.Font = new Font("Comic Sans MS", 50, FontStyle.Regular);
			int txPos = (this.Width - titleText.PreferredWidth) / 2;
			int tYpos = 150;
			titleText.Location = new Point(txPos, tYpos - 27);
			this.Controls.Add(titleText);

			StartButton playButton = new StartButton("Start Game");
			int bxPos = (this.Width - playButton.PreferredSize.Width) / 2;
			int byPos = 275;
			playButton.Location = new Point(bxPos, byPos);
			playButton.Click += new EventHandler(StartButton_Click);
			this.Controls.Add(playButton);

			StartButton quitButton = new StartButton("Quit");
			int qxPos = (this.Width - quitButton.PreferredSize.Width) / 2;
			int qyPos = 350;
			quitButton.Location = new Point(qxPos, qyPos);

			quitButton.Click += new EventHandler(QuitButton_Click);
			this.Controls.Add(quitButton);
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			OnClick(EventArgs.Empty);
			start();
		}

		private void QuitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	// 	[STAThread]
	// 	public static void Main()
	// 	{
	// 		Application.EnableVisualStyles();
	// 		Application.SetCompatibleTextRenderingDefault(false);
	// 		GameController gameController = new GameController();

	// //         // Display the main menu
	// 		gameController.DisplayMainMenu();

	// 		// Run the application
	// 		Application.Run(gameController);
	// 		// Application.Run(new GameController());
	// 	}
	}
}
