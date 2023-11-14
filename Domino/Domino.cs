namespace Domino;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Shapes;
using System.Windows;

public class CsDomino
{
	private Polygon _polygon;
	public LinkedList<data_domino> myDomino = new LinkedList<data_domino>();

	public CsDomino(int SCALE_BY)
	{
		// _polygon = new Polygon();
		// List<PointF> dominoPoints = new List<PointF>
		// {
		// 	new PointF(0, 0),
		// 	new PointF(2, 0),
		// 	new PointF(2, 1),
		// 	new PointF(0, 1)
		// };

		// for (int i = 0; i < dominoPoints.Count; i++)
		// {
		// 	dominoPoints[i] = new PointF(dominoPoints[i].X * SCALE_BY, dominoPoints[i].Y * SCALE_BY);
		// }

		// Polygon = dominoPoints.ToArray();
		API();

	}

	public PointF[] Polygon { get; private set; }

	public void API()
	{
		Init();
	}

	public void SetPos(int x, int y)
	{
		// Set position using Margin
		_polygon.Margin = new Thickness(x, y, 0, 0);
	}

	public data_domino GetPiece(int pieceID)
	{
		if (pieceID >= 0 && pieceID < myDomino.Count)
		{
			int currentIndex = 0;
			data_domino mypiece = new data_domino();
			foreach (data_domino piece in myDomino)
			{
				if (currentIndex == pieceID)
				{
					Console.WriteLine("[" + piece.left + "|" + piece.right + "] available = " + piece.available);
					return piece;
				}
				currentIndex++;
			}
		}

		// Handle the case where pieceID is out of bounds or myDomino is empty.
		Console.WriteLine("Piece with ID " + pieceID + " does not exist or the list is empty.");
		return new data_domino(); // Or another appropriate default value for data_domino
	}


	public void RemovePiece(int pieceNo)
	{
		if (pieceNo < 0)
		{
			throw new ArgumentOutOfRangeException("pieceNo", "Piece number must be non-negative.");
		}

		// Start from the first node
		LinkedListNode<data_domino>? currentNode = myDomino.First;

		for (int i = 0; i < pieceNo; i++)
		{
			// Move to the next node
			currentNode = currentNode?.Next;

			// Check if the index is out of range
			if (currentNode == null)
			{
				throw new ArgumentOutOfRangeException("pieceNo", "Piece number is out of range.");
			}
		}

		// Remove the node at the specified index
		if (currentNode != null)
		{
			myDomino.Remove(currentNode);
		}
	}


	private void Init()
	{
		data_domino mypiece = new data_domino();
		for (int right = 0; right < 7; right++)//Avoid hardcode, use enum
		{
			for (int left = right; left < 7; left++)
			{
				mypiece.right = right;
				mypiece.left = left;
				mypiece.available = 1;
				Console.WriteLine("[" + mypiece.left + "|" + mypiece.right + "]  ");
				myDomino.AddLast(mypiece);
			}
			Console.WriteLine();
		}
		Console.WriteLine("myDomino stores " + myDomino.Count + " pieces.");
	}
}
// Class must be PascalCase -> DataDomino
// Property or getset variable must be PascalCase
public class data_domino
{
	public int left { get; set; }
	public int right { get; set; }
	public int available { get; set; }
}


// using System;


// class Program
// {
// 	static void Main()
// 	{
// 		// Create an instance of CsDomino
// 		CsDomino csDomino = new CsDomino(2);

// 		// Access and display information about a specific piece
// 		data_domino piece = csDomino.GetPiece(5);

// 		// Set the position of the CsDomino
// 		// csDomino.SetPos(10, 10);

// 		// Display information about the piece
// 		Console.WriteLine("Piece Information:");
// 		Console.WriteLine($"Left: {piece.left}, Right: {piece.right}, Available: {piece.available}");

// 		// Remove a piece
// 		csDomino.RemovePiece(3);
// 		Console.WriteLine($"\nRemoved piece 3 {piece.left}, Right: {piece.right}, Available: {piece.available}");

// 		// Access and display information about the remaining pieces
// 		Console.WriteLine("\nRemaining Pieces:");
// 		foreach (var remainingPiece in csDomino.myDomino)
// 		{
// 			Console.WriteLine($"Left: {remainingPiece.left}, Right: {remainingPiece.right}, Available: {remainingPiece.available}");
// 		}
// 	}
// }

