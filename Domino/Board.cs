

using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Domino;

	public partial class Board: Form1                                                                
	{
		private LinkedList<CsDomino> dominos = new LinkedList<CsDomino>();
		private LinkedList<data_domino> board = new LinkedList<data_domino>();
		private bool gameOver = false;
		private CsPlayer[] playerOBJ = new CsPlayer[2];
		private CsDomino player_pDominoOBJ;

		public Board(CsPlayer[] players, CsDomino domino)
		{
			playerOBJ = players;
			player_pDominoOBJ = domino;
		}

		public void KeyPressEvent(KeyEventArgs e)
		{
			Console.WriteLine("Pressed.");
		}

		public void ClearBoard()
		{
			// Clear the game scene or do any necessary cleanup.
		}

		public void PlaceDominos(int x, int y, int num, int size, Queue<data_domino> stack)
		{
			CreateDominoRow(x, y, num, size, stack);
		}
		
		
		public void CreateDominoRow(int x, int y, int numDominos, int size, Queue<data_domino> stack)
		{
			int gap = size * 2 + 5;
			for (int i = 0; i < numDominos; i++)
			{
				CsDomino csdomino = new CsDomino( size);
				csdomino.SetPos(x + gap * i, y);
				dominos.AddLast(csdomino);
				// Add csdomino to the game scene or display it as appropriate.
				PlaceNumber(x + gap * i, y, size, stack.Dequeue());
			}
		}
		public void PrintBoard()
		{
			int i = 0;
			Queue<data_domino> stack = new Queue<data_domino>(board);
			foreach (var domino in board)
			{
				PlaceDominos(10, 525, i++, 15, stack);
			}
		}
		public void PlaceNumber(int x, int y, int size, data_domino dom)
		{
			string left, right;
			if (dom.left == 1)
				left = ":/img/1.png";
			else if (dom.left == 2)
				left = ":/img/2.png";
			else if (dom.left == 3)
				left = ":/img/3.png";
			else if (dom.left == 4)
				left = ":/img/4.png";
			else if (dom.left == 5)
				left = ":/img/5.png";
			else if (dom.left == 6)
				left = ":/img/6.png";
			else
				left = ":/img/huh.png";

			if (dom.right == 1)
				right = ":/img/1.png";
			else if (dom.right == 2)
				right = ":/img/2.png";
			else if (dom.right == 3)
				right = ":/img/3.png";
			else if (dom.right == 4)
				right = ":/img/4.png";
			else if (dom.right == 5)
				right = ":/img/5.png";
			else if (dom.right == 6)
				right = ":/img/6.png";
			else
				right = ":/img/huh.png";

			MyButton myItem = new MyButton(left);
			myItem.SetPos(x, y);
			if (size == 40)
				myItem.SetScale(2);
			else
			{
				myItem.SetScale(0.75f);
				// Set up other properties for the button as needed.
			}

			// Add myItem to the game scene or display it as appropriate.

			MyButton myItem2 = new MyButton(right);
			if (size == 40)
				myItem2.SetPos(x + 40, y);
			else
				myItem2.SetPos(x + 15, y);

			if (size == 40)
				myItem2.SetScale(2);
			else
			{
				myItem2.SetScale(0.75f);
				// Set up other properties for the button as needed.
			}

			// Add myItem2 to the game scene or display it as appropriate.
		}

		public class CsDomino
		{
			public List<data_domino> myDomino = new List<data_domino>();
			public CsDomino()
			{
				for (int i = 0; i <= 6; i++)
				{
					for (int j = i; j <= 6; j++)
					{
						myDomino.Add(new data_domino(i, j));
					}
				}
			}
		}

		public bool GoodPiece(int move, int playerID)
		{
			if (playerOBJ[playerID].GotHand.ElementAt(move).left == board.Last().right ||
				playerOBJ[playerID].GotHand.ElementAt(move).right == board.Last().right ||
				playerOBJ[playerID].GotHand.ElementAt(move).left == board.First().left ||
				playerOBJ[playerID].GotHand.ElementAt(move).right ==board.First().left)
				
			{
				
				return true;
			}

			return false;
		}

		public bool GoodSpot(int move, int playerID, char pos)
		{
			if (pos == 't')
			{
				if (playerOBJ[playerID].GotHand.ElementAt(move).left == board.Last().right ||
					playerOBJ[playerID].GotHand.ElementAt(move).right == board.Last().right)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				if (playerOBJ[playerID].GotHand.ElementAt(move).left == board.First().left ||
					playerOBJ[playerID].GotHand.ElementAt(move).right == board.First().left)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		public void SelectingPieces()
		{
			int pieceNO, pieceWasAvailable;
			int totalPlayer = 2;
			Console.WriteLine("Selecting pieces and giving 12 pieces to each player");

			for (int playerID = 0; playerID < totalPlayer; playerID++)
			{
				for (int i = 0; i < 10; i++)
				{
					pieceNO = playerOBJ[playerID].GetRandomPublic(0, player_pDominoOBJ.myDomino.Count - 1);
					
					Console.WriteLine("pieceNO: " + pieceNO);
					pieceWasAvailable = playerOBJ[playerID].TakePiece(pieceNO);

					if (pieceWasAvailable == 1)
					{
						Console.WriteLine("Piece available");
					}
					else
					{
						Console.WriteLine("////////////////////////////////////////////////");
						Console.WriteLine("Piece not available - try to take a piece again");
						i--;
					}
				}
			}
		}

		public void NextTurn(ref int turn)
		{
			if (turn == 1)
				turn = 0;
			else
				turn = 1;
			Console.WriteLine("Player " + turn + "'s turn.");
		}

		public void ShowPlayerHand()
		{
			int totalPlayer = 2;
			for (int playerID = 0; playerID < totalPlayer; playerID++)
			{
				Console.WriteLine("Player ID = " + playerID + " stores " + playerOBJ[playerID].GotHand.Count + " pieces.");
				Console.WriteLine("Player " + playerID + "'s remaining hand:");
				foreach (var piece in playerOBJ[playerID].GotHand)
				{
					Console.WriteLine("[" + piece.left + " | " + piece.right + "] available = " + piece.available);
				}
			}
		}

		public void ShowPlayerHand(int playerID)
		{
			data_domino showpiece;
			if (playerID == 0)
			{
				Console.WriteLine("Player ID = " + playerID + " has " + playerOBJ[playerID].GotHand.Count + " pieces.");
				Console.WriteLine("Player " + playerID + "'s remaining hand:");

				for (int pieceNo = 0; pieceNo < playerOBJ[playerID].GotHand.Count; pieceNo++)
				{
					showpiece = playerOBJ[playerID].GotHand.ElementAt(pieceNo);
					PlaceDominos(50, 600, playerOBJ[playerID].GotHand.Count, 40, new Queue<data_domino>(playerOBJ[playerID].GotHand));

					// Create and display other UI elements as needed.

					// Example: Display the piece number at the top of the dominos.
					string pieceNumberText = pieceNo.ToString();
					Console.WriteLine(pieceNumberText);
				}
			}

			if (gameOver)
			{
				PlaceDominos(50, 100, playerOBJ[1].GotHand.Count, 40, new Queue<data_domino>(playerOBJ[1].GotHand));

				// Display other UI elements and game state when the game is over.
			}

			// Display other UI elements for player 1 as needed.
		}

		public void InitialMove(int playerID)
		{
			int move = 0;
			bool isAi = playerID == 1;
			if (isAi)
				move = 0;
			else
			{
				bool isInputValid = false;
				while (!isInputValid)
				{
					Console.WriteLine("Enter piece number to play: ");
					string numStr = Console.ReadLine();
					if (int.TryParse(numStr, out move) && move >= 0 && move < playerOBJ[playerID].GotHand.Count)
					{
						isInputValid = true;
					}
					else
					{
						Console.WriteLine("Invalid input. Please enter a valid piece number.");
					}
				}
			}
			
			playerOBJ[playerID].GotHand.ElementAt(move).available = 0;
			board.AddLast(playerOBJ[playerID].GotHand.ElementAt(move));
			playerOBJ[playerID].GotHand.Remove(playerOBJ[playerID].GotHand.ElementAt(move));
			ClearBoard();
		}
		public void Move(int playerID, ref char pos)
{
	int move;
	const string r = "";
	bool isMove = false;
	bool isAi = (playerID == 1);
	AI bob = new AI();

	if (MoveAvailable(playerID))
	{
		if (player_pDominoOBJ.myDomino.Count != 0 && playerOBJ[0].GotHand.Count != 0 && playerOBJ[1].GotHand.Count != 0)
		{
			while (true)
			{
				Console.WriteLine("Enter piece number to play: ");
				if (isAi)
				{
					move = bob.CounterMoves;
					bob.CounterMoves++;
				}
				else
				{
					bool isInputValid = false;
					while (!isInputValid)
					{
						Console.WriteLine("Enter piece number to play: ");
						string numStr = Console.ReadLine();
						if (int.TryParse(numStr, out move) && move >= 0 && move < playerOBJ[playerID].GotHand.Count)
						{
							isInputValid = true;
						}
						else
						{
							Console.WriteLine("Invalid input. Please enter a valid piece number.");
						}
					}
				}

				isMove = GoodPiece(move, playerID);
				if (isMove)
					break;
				else
					Console.WriteLine("That is not a valid move.");
			}

			isMove = false;
			playerOBJ[playerID].GotHand.ElementAt(move).available = 0;

			while (true)
			{
				Console.WriteLine("Play domino at head or tail? (h/t)");
				if (isAi)
				{
					if (pos % 2 == 1)
						pos = 't';
					else
					{
						pos = bob.CounterHeads;
						bob.CounterHeads++;
					}
				}
				else
				{
					string num;
					bool ok;
					Console.WriteLine("Enter 'h' or 't': ");
					string input = Console.ReadLine();
					if (input.Length > 0)
					{
						num = input;
						r = num;
						pos = r[0];
					}
				}

				isMove = GoodSpot(move, playerID, pos);
				if (isMove)
					break;
				else
					Console.WriteLine("That is not a valid spot.");
			}

			if (pos == 't')
			{
				if (playerOBJ[playerID].GotHand.ElementAt(move).left == board.Last().right)
				{
					board.AddLast(playerOBJ[playerID].GotHand.ElementAt(move));
				}
				else
				{
					int tmp = playerOBJ[playerID].GotHand.ElementAt(move).left;
					playerOBJ[playerID].GotHand.ElementAt(move).left = playerOBJ[playerID].GotHand.ElementAt(move).right;
					playerOBJ[playerID].GotHand.ElementAt(move).right = tmp;
					board.AddLast(playerOBJ[playerID].GotHand.ElementAt(move));
				}
			}

			playerOBJ[playerID].GotHand.Remove(playerOBJ[playerID].GotHand.ElementAt(move));
			{
				if (playerOBJ[playerID].GotHand.ElementAt(move).right == board.First().left)
					board.AddFirst(playerOBJ[playerID].GotHand.ElementAt(move));
				else
				{
					int tmp = playerOBJ[playerID].GotHand.ElementAt(move).left;
					playerOBJ[playerID].GotHand.ElementAt(move).left = playerOBJ[playerID].GotHand.ElementAt(move).right;
					playerOBJ[playerID].GotHand.ElementAt(move).right = tmp;
					board.AddFirst(playerOBJ[playerID].GotHand.ElementAt(move));
				}
				playerOBJ[playerID].GotHand.Remove(playerOBJ[playerID].GotHand.ElementAt(move));
			}
		}
		else
			gameOver = true;
	}
	else
	{
		if (player_pDominoOBJ.myDomino.Count != 0 && CsDomino.myDomino.Count != 0 && playerOBJ[1].GotHand.Count != 0)
		{
			while (!MoveAvailable(playerID) && player_pDominoOBJ.myDomino.Count != 0)
			{
				DrawAPiece(playerID);
				ShowPlayerHand(playerID);
				PrintBoard();
			}

			if (MoveAvailable(playerID))
			{
				while (true)
				{
					Console.WriteLine("Enter piece number to play: ");
					if (isAi)
					{
						move = bob.CounterMoves;
						bob.CounterMoves++;
					}
					else
					{
						bool isInputValid = false;
						while (!isInputValid)
						{
							Console.WriteLine("Enter piece number to play: ");
							string numStr = Console.ReadLine();
							if (int.TryParse(numStr, out move) && move >= 0 && move < playerOBJ[playerID].GotHand.Count)
							{
								isInputValid = true;
							}
							else
							{
								Console.WriteLine("Invalid input. Please enter a valid piece number.");
							}
						}
					}

					isMove = GoodPiece(move, playerID);
					if (isMove)
						break;
					else
						Console.WriteLine("That is not a valid move.");
				}

				isMove = false;
				playerOBJ[playerID].GotHand.ElementAt(move).available = 0;

				while (true)
				{
					Console.WriteLine("Play domino at head or tail? (h/t)");
					if (isAi)
					{
						if (pos % 2 == 1)
							pos = 't';
						else
						{
							pos = bob.CounterHeads;
							bob.CounterHeads++;
						}
					}
					else
					{
						string num;
						bool ok;
						Console.WriteLine("Enter 'h' or 't': ");
						string input = Console.ReadLine();
						if (input.Length > 0)
						{
							num = input;
							r = num;
							pos = r[0];
						}
					}

					isMove = GoodSpot(move, playerID, pos);
					if (isMove)
						break;
					else
						Console.WriteLine("That is not a valid spot.");
				}

				if (pos == 't')
				{
					if (playerOBJ[playerID].GotHand.ElementAt(move).left == board.Last.Value.right)
						board.AddLast(playerOBJ[playerID].GotHand.ElementAt(move));
					else
					{
						int tmp = playerOBJ[playerID].GotHand.ElementAt(move).left;
						playerOBJ[playerID].GotHand.ElementAt(move).left = playerOBJ[playerID].GotHand.ElementAt(move).right;
						playerOBJ[playerID].GotHand.ElementAt(move).right = tmp;
						board.AddLast(playerOBJ[playerID].GotHand.ElementAt(move));
					}

					playerOBJ[playerID].GotHand.Remove(playerOBJ[playerID].GotHand.ElementAt(move));
				}
				else
				{
					if (playerOBJ[playerID].GotHand.ElementAt(move).right == board.First.Value.left)
						board.AddFirst(playerOBJ[playerID].GotHand.ElementAt(move));
					else
					{
						int tmp = playerOBJ[playerID].GotHand.ElementAt(move).left;
						playerOBJ[playerID].GotHand.ElementAt(move).left = playerOBJ[playerID].GotHand.ElementAt(move).right;
						playerOBJ[playerID].GotHand.ElementAt(move).right = tmp;
						board.AddFirst(playerOBJ[playerID].GotHand.ElementAt(move));
					}
					playerOBJ[playerID].GotHand.Remove(playerOBJ[playerID].GotHand.ElementAt(move));
				}
			}
		}
		else
			gameOver = true;
	}
}

public void API(CsPlayer[] receivePlayersOBJ, CsDomino receiveDominoPointerOBJ, ref int turn)
{
	playerOBJ = receivePlayersOBJ;
	player_pDominoOBJ = receiveDominoPointerOBJ;
	SelectingPieces();
	ShowPlayerHand();
	ShowPlayerHand(turn);
	InitialMove(turn);
	ShowPlayerHand(turn);
	NextTurn(ref turn);
	ShowPlayerHand(turn);
	PrintBoard();

	while (playerOBJ[0].GotHand.Count > 0 && playerOBJ[1].GotHand.Count > 0)
	{
		char pos = 'h';
		Move(turn, ref pos);
		if (gameOver)
			break;
		else
		{
			ClearBoard();
			NextTurn(ref turn);
			ShowPlayerHand(turn);
			if (turn == 1)
				ShowPlayerHand(0);
			else
				ShowPlayerHand(1);
			PrintBoard();
		}
	}

	DeclareWinner();
}
}