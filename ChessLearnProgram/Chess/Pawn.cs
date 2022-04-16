using System.Collections.Generic;

namespace Chess
{
    public class Pawn : ChessPiece
    {
        /// <inheritdoc />
        /// <summary>
        /// Текущая координата пешки.
        /// </summary>
        protected override ChessBoard.Coordinate       CurrentCoordinate { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Список корректных возможных ходов пешки.
        /// </summary>
        public override    List<ChessBoard.Coordinate> ValidMoves        { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Статус пешки. True – не срублена, False – срублена.
        /// </summary>
        public override    bool                        IsPlayable        { get; set; }
    }
}
