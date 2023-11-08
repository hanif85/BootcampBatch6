namespace Domino;

using System;
using System.Collections.Generic;

public class CsPlayer
{
	private CsDomino player_pDominoOBJ;

	public List<data_domino> gotHand = new List<data_domino>();

	public CsPlayer(CsDomino receive_dominoPointerOBJ)
	{
		player_pDominoOBJ = receive_dominoPointerOBJ;
	}

	public void API(CsDomino receive_dominoPointerOBJ)
{
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
		gotHand.Add(takenPiece);

		// Remove the piece from the dominoes pile
		player_pDominoOBJ.RemovePiece(pieceNo);

		Console.WriteLine("[" + takenPiece.left + "|" + takenPiece.right + "]" + " just taken - no longer available from pile = " + takenPiece.available);

		return number_wasAvailable;
	}
}

// public class data_domino
// {
//     public int left { get; set; }
//     public int right { get; set; }
//     public int available { get; set; }
// }

