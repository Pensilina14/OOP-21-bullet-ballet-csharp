using OOP21_task_cSharp.Baiocchi;

namespace OOP21_task_cSharp.Pioggia
{
    public interface IPhysicalObject
    {
        IMutablePosition2D GetPosition();
        ISpeedVector2D GetSpeedVector();
        bool MoveUp(double y);
        void MoveDown(double y);
        bool MoveLeft(double x);
        bool MoveRight(double x);
        void UpdateState();
        IDimension2D GetDimension();
        IEnvironment GetGameEnvironment();
        double GetMass();
        bool HasLanded();
        void Land();
        void ResetLanding();
    }
}
