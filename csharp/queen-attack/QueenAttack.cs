using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        int dy = white.Column - black.Column;
        int dx = white.Row - black.Row;
        return dx == 0 || dy == 0 || Math.Abs(dx) == Math.Abs(dy);
    }

    public static Queen Create(int row, int column)
    {
        return (row < 0 || column < 0 || row >= 8 || column >= 8) ? throw new ArgumentOutOfRangeException("Invalid position.") : new Queen(row, column);
    }
}