using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLearnProgram
{
    public abstract class ChessPart
    {
        protected const int  MaxDistance = 7;
        
        // область ходов для пешки 
        protected bool canEnPassageLeft;
        protected bool canEnPassageRight;
        protected bool canEnDoubleJump;

        // область ходов для других фигур
        protected bool      canCastle;        // ход для ладьи и короля
        protected Point[][] availableMoves;   // массив для перемещений ([направление][расстояние])
        protected Point[][] availableAttacks; //Массив для атаки,если не пешка.
        private   int       player;
        public    Point[][] AvailableMoves   => availableMoves;
        public    Point[][] AvailableAttacks => availableAttacks;
        public int Player
        {
            get => player;
            set => player = value;
        } 
        public abstract ChessPart CalculateMoves();

        public static Point[] GetMovementArray(int distance, Direction direction)
        {
            var movement  = new Point[distance];
            int xPosition = 0;
            int yPosition = 0;
            for (int i = 0; i < distance; i++)
            {
                switch (direction)
                {
                    case Direction.Forward:
                        yPosition++;
                        break;
                    case Direction.Backward:
                        yPosition--;
                        break;
                    case Direction.Left:
                        xPosition++;
                        break;
                    case Direction.Right:
                        xPosition--;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
                }
                movement[i] = new Point(xPosition, yPosition);

            }
            return movement;

        }
        public static Point[] GetDiagnalMovementArray(int distance, DiagonalDirection direction)
        {
            Point[] attack    = new Point[distance];
            int     xPosition = 0;
            int     yPosition = 0;

            for (int i = 0; i < distance; i++)
            {
                switch (direction)
                {
                    case DiagonalDirection.ForwardLeft:
                        xPosition--;
                        yPosition++;
                        break;
                    case DiagonalDirection.ForwardRight:
                        xPosition++;
                        yPosition++;
                        break;
                    case DiagonalDirection.BackwardLeft:
                        xPosition--;
                        yPosition--;
                        break;
                    case DiagonalDirection.BackwardRight:
                        xPosition++;
                        yPosition--;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
                }
                attack[i] = new Point(xPosition, yPosition);
            }
            return attack;
        }
    }
}
