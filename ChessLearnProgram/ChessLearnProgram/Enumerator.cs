namespace ChessLearnProgram
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => ($"{this.x},{this.y}");

        
    }
    public enum Direction
    {
        Forward,
        Backward,
        Left,
        Right,
    }
    public enum DiagonalDirection
    {
        ForwardLeft,
        ForwardRight,
        BackwardLeft,
        BackwardRight,
    }
}
