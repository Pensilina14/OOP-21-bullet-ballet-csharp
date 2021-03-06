using OOP21_task_cSharp.Baiocchi;

namespace OOP21_task_cSharp.Pioggia
{
    public class GameEntity : IPhysicalObject
    {
        private const double MS_TO_S = 1;
        private readonly ISpeedVector2D _speedVector;
        private readonly Baiocchi.IEnvironment _gameEnvironment;
        private readonly IDimension2D _dimension;
        private readonly double _mass;
        private bool _landed;

        public GameEntity(ISpeedVector2D speedVector, Baiocchi.IEnvironment gameEnvironment, double mass
            , IDimension2D dimension)
        {
            this._speedVector = speedVector;
            this._gameEnvironment = gameEnvironment;
            this._dimension = dimension;
            this._mass = mass;
            this._landed = false;
        }

        public IDimension2D GetDimension()
        {
            return this._dimension;
        }

        public IEnvironment GetGameEnvironment()
        {
            return this._gameEnvironment;
        }

        public double GetMass()
        {
            return this._mass;
        }

        bool IPhysicalObject.HasLanded()
        {
            return this._landed;
        }
        
        public void Land() => this._landed = true;

        public void MoveDown(double y) => this._speedVector.VectorSum(0, y);

        public bool MoveLeft(double x) => this.Move(this.GetPosition().GetX() - x - this.GetDimension().GetWidth() >= 0, x, 0);

        public bool MoveRight(double x) => this.Move(this.GetPosition().GetX() + x + this.GetDimension().GetWidth()
                <= this._gameEnvironment.GetDimension().GetWidth(), x, 0);

        public IMutablePosition2D GetPosition()
        {
            return this._speedVector.GetPosition();
        }

        public ISpeedVector2D GetSpeedVector()
        {
            return this._speedVector;
        }

        public bool MoveUp(double y) => this.Move(this.GetPosition().GetY() - y - this.GetDimension().GetHeight()
                                                  >= this._gameEnvironment.GetDimension().GetHeight(), 0, y);

        private bool Move(bool condition, double x, double y)
        {
            if (condition)
            {
                this._speedVector.VectorSum(x, y);
                return true;
            }
            return false;
        }

        public void ResetLanding()
        {
            this._landed = false;
        }

        public virtual void UpdateState() => this._speedVector.NoSpeedVectorSum(-MS_TO_S, 0);
    }
}
