namespace OOP21_task_cSharp.Pioggia
{
    public interface IPhysicalObject
    {
        IMutablePosition2D Position { get; }

        ISpeedVector2D SpeedVector { get; }

        bool MoveUp(double y);
        void MoveDown(double y);
        bool MoveLeft(double x);
        bool MoveRight(double x);
        void UpdateState();
        IDimension2D GetDimension();
        Baiocchi.IEnvironment GameEnvironment { get; }
        double Mass { get; }

        bool HasLanded { get; }

        void Land();
        void ResetLanding();
    }
}
