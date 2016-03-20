namespace FATEC.ArcadeSpaceBattle.Abstractions {
	/// <summary>
	/// Represents a joystick input device.
	/// </summary>
	public interface IJoystick {
		/// <summary>
		/// Gets the value of a given axis (-1, 1).
		/// </summary>
		/// <param name="index">Axis index.</param>
		/// <returns>>The axis value (-1, 1).</returns>
		float GetAxis(int index);

		/// <summary>
		/// Checks whether a button is being pressed.
		/// </summary>
		/// <param name="index">Button index.</param>
		/// <returns>
		/// <c>true</c>, if button is pressed, 
		/// <c>false</c> otherwise.
		/// </returns>
		bool GetButton(int index);
	}
}