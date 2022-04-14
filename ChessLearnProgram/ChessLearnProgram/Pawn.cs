using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLearnProgram
{
    public class Pawn: ChessPart
    {
        public Pawn()
        {
            this.canEnDoubleJump = true;
            CalculateMoves();
        }

        public Pawn(int player)
        {
            base.Player          = player;
            this.canEnDoubleJump = true;
            CalculateMoves();   
        }

        public override ChessPart CalculateMoves()
        {
            Direction         forward;
            DiagonalDirection forwardLeft, forwardRight;
            if (base.Player == 1)
            {
                forward     = Direction.Backward;
                forwardLeft = DiagonalDirection.BackwardLeft;
                forwardRight = DiagonalDirection.BackwardRight;
            }

            else
            {
                forward = Direction.Forward;
                forwardLeft = DiagonalDirection.ForwardLeft;
                forwardRight = DiagonalDirection.ForwardRight;
            }
            availableMoves = new Point[1][];
            if (this.canEnDoubleJump)
            {
                availableMoves[0] = GetMovementArray(2, forward);
            }
            else
            {
                availableMoves[0] = GetMovementArray(1, forward);
            }
            availableAttacks    = new Point[2][];
            availableAttacks[0] = GetDiagnalMovementArray(1, forwardLeft);
            availableAttacks[1] = GetDiagnalMovementArray(1, forwardRight);
            return this;

        }
        public bool CanDoubleJump 
        {
            get => this.canEnDoubleJump;
            set => this.canEnDoubleJump = value;
        }
        public bool CanEnPassageLeft
        {
            get => this.canEnPassageLeft;
            set => this.canEnPassageLeft = value;
        }
        public bool CanEnPassageRight
        {
            get => this.canEnPassageRight;
            set => this.canEnPassageRight = value;
        }
    }
}
