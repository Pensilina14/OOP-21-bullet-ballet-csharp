namespace OOP21_task_cSharp.Pioggia
{
    internal interface PhysicalObject
    {
        MutablePosition2D GetPosition();
        SpeedVector2D GetSpeedVector();
        bool MoveUp(double y);
        void MoveDown(double y);
        bool MoveLeft(double x);
        bool MoveRight(double x);
        void UpdateState();
        Dimension2D GetDimension();
        OOP21_task_cSharp.Baiocchi.Environment GetGameEnvironment();
        double GetMass();
        bool HasLanded();
        void Land();
        void ResetLanding();
    }
}
