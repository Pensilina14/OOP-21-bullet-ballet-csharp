using OOP21_task_cSharp.Pioggia;

namespace OOP_21_bullet_ballet_csharp.Pioggia
{
    public class MutablePosition2DCore : IMutablePosition2D
    {
        private double _x;
        private double _y;

        public MutablePosition2DCore(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public IPair GetCoordinates()
        {
            throw new System.NotImplementedException();
        }

        public double GetX()
        {
            return this._x;
        }

        public double GetY()
        {
            return this._y;
        }

        public void SetPosition(double x, double y)
        {
            this._x = x;
            this._y = y;
        }
    }
}