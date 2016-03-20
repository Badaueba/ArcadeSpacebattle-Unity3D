namespace FATEC.ArcadeSpaceBattle.Abstractions {
    /// <summary>
    /// Representes a movable object.
    /// </summary>
    public interface IMover {
        /// <summary>
        /// Moves the object on X and Y axis by a given amount.
        /// </summary>
        /// <param name="x">Amount to move on X axis.</param>
        /// <param name="y">Amount to move on Y axis.</param>
        void Move(float x, float y);
    }
}