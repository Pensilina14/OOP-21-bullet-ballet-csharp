namespace OOP21_task_cSharp.Pioggia
{
    public class SpeedVector2DCore : ISpeedVector2D
    {
        private readonly IMutablePosition2D _position;
        private readonly double _speed;

        public SpeedVector2DCore(IMutablePosition2D position, double speed)
        {
            this._position = position;
            this._speed = speed;
        }
        
        public IMutablePosition2D GetPosition()
        {
            return this._position;
        }

        public double GetSpeed()
        {
            return this._speed;
        }

        public void NoSpeedVectorSum(double x, double y)
        {
            this._position.SetPosition(this._position.GetX() + x, this._position.GetY() + y);
        }

        public void VectorSum(double x, double y)
        {
            this.NoSpeedVectorSum(x * this._speed, y * this._speed);
        }
    }
}
