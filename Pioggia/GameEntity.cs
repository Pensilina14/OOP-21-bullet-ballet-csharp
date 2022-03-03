namespace OOP21_task_cSharp.Pioggia
{
    internal class GameEntity : IPhysicalObject
    {
        private const double MS_TO_S = 1;
        private readonly SpeedVector2D speedVector;
        private readonly Baiocchi.Environment gameEnvironment;
        private readonly Dimension2D dimension;
        private readonly double mass;
        private bool landed;

        public GameEntity(SpeedVector2D speedVector, Baiocchi.Environment gameEnvironment, double mass
            , Dimension2D dimension)
        {

            this.speedVector = speedVector;
            this.gameEnvironment = gameEnvironment;
            this.dimension = dimension;
            this.mass = mass;
            this.landed = false;
        }


        public Dimension2D GetDimension()
        {
            return this.dimension;
        }

        public Baiocchi.Environment GetGameEnvironment()
        {
            return this.gameEnvironment;
        }

        public double GetMass()
        {
            return this.mass;
        }

        public IMutablePosition2D GetPosition()
        {
            return this.speedVector.GetPosition();
        }

        public SpeedVector2D GetSpeedVector()
        {
            return this.speedVector;
        }

        public bool HasLanded()
        {
            return this.landed;
        }

        public void Land()
        {
            this.landed = true;
        }

        public void MoveDown(double y)
        {
            this.speedVector.VectorSum(0, y);
        }

        public bool MoveLeft(double x)
        {
            return this.Move(this.GetPosition.getX() - x - this.GetDimension().GetWidth() >= 0);
        }

        public bool MoveRight(double x)
        {
            return this.Move(this.GetPosition().GetX() + x + this.GetDimension().GetWidth()
                <= this.gameEnvironment.GetDimension().GetWidth(), x, 0);
        }

        public bool MoveUp(double y)
        {
            return this.Move(this.GetPosition().getY() - y - this.GetDimension().GetHeight()
                >= this.gameEnvironment.getDimension().GetHeight(), 0, y);
        }

        private bool Move(bool condition, double x, double y)
        {
            if (condition)
            {
                this.speedVector.VectorSum(x, y);
                return true;
            }
            return false;
        }

        public void ResetLanding()
        {
            this.landed = false;
        }

        public void UpdateState()
        {
            this.speedVector.NoSpeedVectorSum(-MS_TO_S, 0);
        }
    }
}
