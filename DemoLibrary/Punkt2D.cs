namespace NewElements.DemoLibrary
{
    /// <summary>
    /// Repräsentiert einen Punkt im 2 dimensionalen Koordinatensystem
    /// </summary>
    public struct Punkt2D
    {
        /// <summary>
        /// Stellt den X Wert unseres Punktes dar
        /// </summary>
        public float X;

        /// <summary>
        /// Stellt den Y Wert unseres Punktes dar
        /// </summary>
        public float Y;

        /// <summary>
        /// Addiert einen Vektor auf einen bestehenden Punkt2D
        /// </summary>
        /// <param name="x">Der x Wert des zu addierenden Vektory</param>
        /// <param name="y">Der y Wert des zu addierenden Vektory</param>
        /// <returns>Der neue Punkt2D im Koordinatensystem</returns>
        public Punkt2D AddiereVektor(float x, float y)
        {
            Punkt2D ergebnis;
            ergebnis.X = X + x;
            ergebnis.Y = Y + y;
            return ergebnis;
        }

        /// <summary>
        /// Addiert einen Vektor in Form eines Punktes auf einen bestehenden Punkt2D
        /// </summary>
        /// <param name="vektor">Der Vektor in Form eines Punkt2D</param>
        /// <returns>Der neue Punkt2D im Koordinatensystem</returns>
        public Punkt2D AddiereVektor(Punkt2D vektor)
        {
            return AddiereVektor(vektor.X, vektor.Y);
        }
    }
}