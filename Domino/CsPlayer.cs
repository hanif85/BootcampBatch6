namespace Domino;

using System;
using System.Collections.Generic;

public class CsPlayer : CsRandom
{
	private CsDomino player_pDominoOBJ;

	public LinkedList<data_domino> GotHand = new LinkedList<data_domino>();//Player inside the GameController, not have the object on the game

	public CsPlayer(CsDomino receive_dominoPointerOBJ)
	{
		player_pDominoOBJ = receive_dominoPointerOBJ;
	}

	public void API(CsDomino receive_dominoPointerOBJ)
	{
		// int pieceID;
		player_pDominoOBJ = receive_dominoPointerOBJ;
	}
	public int TakePiece(int pieceNo)
	{
		int number_wasAvailable = 0;

		data_domino takenPiece = player_pDominoOBJ.GetPiece(pieceNo);

		// Check if the piece is available (your original code had a comment to handle this, but the code was commented out)
		number_wasAvailable = takenPiece.available;

		// Set the piece as not available from the dominoes pile (commented out in your original code)
		// takenPiece.available = 0;

		// Add the piece to the player's hand
		takenPiece.available = 1;
		GotHand.AddLast(takenPiece);
		// gotHand.

		// Remove the piece from the dominoes pile
		player_pDominoOBJ.RemovePiece(pieceNo);

		Console.WriteLine("[" + takenPiece.left + "|" + takenPiece.right + "]" + " just taken - no longer available from pile = " + takenPiece.available);

		return number_wasAvailable;
	}
}

// class Program
// {
// 	static void Main()
// 	{
// 		// Create an instance of CsDomino
// 		CsDomino csDomino = new CsDomino(20);

// 		// Create an instance of CsPlayer and pass the CsDomino instance
		// CsPlayer player = new CsPlayer(csDomino);

// 		// Take a piece from the domino pile (change the pieceNo as needed)
// 		int pieceNo = 3;
// 		int wasAvailable = player.TakePiece(pieceNo);

// 		// Display information about the taken piece
// 		Console.WriteLine($"\nPiece No. {pieceNo} was {(wasAvailable == 1 ? "available" : "not available")}");

// 		// Display the player's hand
// 		Console.WriteLine("\nPlayer's Hand:");
// 		foreach (var handPiece in player.GotHand)
// 		{
// 			Console.WriteLine($"Left: {handPiece.left}, Right: {handPiece.right}, Available: {handPiece.available}");
// 		}
// 	}
// }

