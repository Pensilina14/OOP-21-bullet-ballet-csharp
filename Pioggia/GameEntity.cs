namespace OOP21_task_cSharp.Pioggia
{
    internal class GameEntity : PhysicalObject
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
            throw new NotImplementedException();
        }

        public bool MoveRight(double x)
        {
            throw new NotImplementedException();
        }

        public bool MoveUp(double y)
        {
            throw new NotImplementedException();
        }

        private bool move(bool condition, double x, double y)
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
