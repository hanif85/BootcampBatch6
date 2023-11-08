

using System;
using System.Windows.Forms;
using System.Drawing;
// using Domino;
namespace Domino;

public partial class GameController : Form1
{
	private Board board;
	private CsDomino dominoOBJ;
	private CsPlayer[] playerOBJ;
	private int turn;

	public GameController()
	{
		this.DoubleBuffered = true;
		this.Width = 1024;
		this.Height = 768;
		this.BackgroundImage = Image.FromFile("wood.jpg");
		this.BackgroundImageLayout = ImageLayout.Stretch;

		CsDomino  dominoOBJ = new CsDomino(2);
		dominoOBJ.API();
		playerOBJ = new CsPlayer[2];
		Board board = new Board(playerOBJ, dominoOBJ);
		
		playerOBJ[0] = new CsPlayer(dominoOBJ);
		playerOBJ[1] = new CsPlayer(dominoOBJ);
		playerOBJ[0].API(dominoOBJ);
		playerOBJ[1].API(dominoOBJ);

		CsRandom n = new CsRandom();
		turn = n.GetRandomPublic(0, 1);

		start();
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
		// board.InitializeComponents();//test this line has error
		
		// board.In
	}

	private void displayMainMenu()
	{
		Label titleText = new Label();
		titleText.Text = "Oh, Domino!";
		titleText.Font = new Font("Comic Sans MS", 50, FontStyle.Regular);
		int txPos = (this.Width - titleText.PreferredWidth) / 2;
		int tYpos = 150;
		titleText.Location = new Point(txPos, tYpos - 27);
		this.Controls.Add(titleText);

		StartButton playButton = new StartButton("Play");
		// playButton.Text = "Play";
		int bxPos = (this.Width - playButton.PreferredSize.Width) / 2;
		int byPos = 275;
		playButton.Location = new Point(bxPos, byPos);
		playButton.Click += new EventHandler(StartButton_Click);
		this.Controls.Add(playButton);

		StartButton quitButton = new StartButton("Quit");
		// quitButton.Text = "Quit";
		int qxPos = (this.Width - quitButton.PreferredSize.Width) / 2;
		int qyPos = 350;
		quitButton.Location = new Point(qxPos, qyPos);
		quitButton.Click += new EventHandler(QuitButton_Click);
		this.Controls.Add(quitButton);
	}

	private void StartButton_Click(object sender, EventArgs e)
	{
		start();
	}

	private void QuitButton_Click(object sender, EventArgs e)
	{
		this.Close();
	}

	// [STAThread]
	// public static void Main()
	// {
	// 	Application.Run(new GameController());
	// }
}
