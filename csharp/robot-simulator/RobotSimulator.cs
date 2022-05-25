using System;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    public Direction Direction { get; private set; }
    public int X { get; private set; }
    public int Y { get; private set; }

    public RobotSimulator(Direction direction, int x, int y)
    {
        this.Direction = direction;
        this.X = x;
        this.Y = y;
    }

    public void Move(string instructions)
    {
        foreach (var command in instructions)
        {
            switch (command)
            {
                case 'R':
                    TurnRight();
                    break;
                case 'L':
                    TurnLeft();
                    break;
                case 'A':
                    Advance();
                    break;
                default:
                    throw new ArgumentException("Invalid command: '" + command + "'");
            }
        }
    }

    void TurnRight()
    {
        Direction = (Direction)(((int)Direction + 1) % 4);
    }
    void TurnLeft()
    {
        Direction = (Direction)(((int)Direction + 3) % 4);
    }

    void Advance()
    {
        switch (Direction)
        {
            case Direction.North:
                Y += 1;
                break;
            case Direction.East:
                X += 1;
                break;
            case Direction.South:
                Y -= 1;
                break;
            case Direction.West:
                X -= 1;
                break;
        }
    }

}