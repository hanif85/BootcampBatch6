namespace Domino;

using System;
using System.Collections.Generic;
using System.Drawing;

public class CsDomino
{
    private List<data_domino> myDomino = new List<data_domino>();

    public CsDomino(int SCALE_BY)
    {
        List<PointF> dominoPoints = new List<PointF>
        {
            new PointF(0, 0),
            new PointF(2, 0),
            new PointF(2, 1),
            new PointF(0, 1)
        };

        for (int i = 0; i < dominoPoints.Count; i++)
        {
            dominoPoints[i] = new PointF(dominoPoints[i].X * SCALE_BY, dominoPoints[i].Y * SCALE_BY);
        }

        Polygon = dominoPoints.ToArray();
    }

    public PointF[] Polygon { get; private set; }

    public void API()
    {
        Init();
    }

    public data_domino GetPiece(int pieceID)
    {
        data_domino mypiece = myDomino[pieceID];
        Console.WriteLine("[" + mypiece.left + "|" + mypiece.right + "]" + " available = " + mypiece.available);
        myDomino[pieceID] = mypiece;
        return mypiece;
    }

    public void RemovePiece(int pieceNo)
    {
        myDomino.RemoveAt(pieceNo);
    }

    private void Init()
    {
        data_domino mypiece = new data_domino();
        for (int right = 0; right < 7; right++)
        {
            for (int left = right; left < 7; left++)
            {
                mypiece.right = right;
                mypiece.left = left;
                mypiece.available = 1;
                Console.WriteLine("[" + mypiece.left + "|" + mypiece.right + "]  ");
                myDomino.Add(mypiece);
            }
            Console.WriteLine();
        }
        Console.WriteLine("myDomino stores " + myDomino.Count + " pieces.");
    }
}

public class data_domino
{
    public int left { get; set; }
    public int right { get; set; }
    public int available { get; set; }
}
