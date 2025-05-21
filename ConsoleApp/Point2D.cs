namespace ConsoleApp.CustomTypes
{
    struct Point2D
    {
        public float X;
        public float Y;

        public delegate void VectorAddedHandler();
        public event VectorAddedHandler VectorAdded;
        //public event EventHandler Click;



        public Point2D AddVector(float x, float y)
        {
            Point2D result = new();
            result.X = X + x;
            result.Y = Y + y;

            if (VectorAdded != null)
            {
                VectorAdded.Invoke();
            }

            return result;
        }
    }
}