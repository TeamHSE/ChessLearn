namespace Chess
{
    /// <summary>
    ///     Интерфейс, описывающий координату.
    /// </summary>
    public interface ICoordinate
    {
        /// <summary>
        ///     Координата столбца.
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        ///     Координата строки.
        /// </summary>
        public int Row { get; set; }
    }
}
