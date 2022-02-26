namespace OOP21_task_cSharp.Pioggia
{
    internal interface SpeedVector2D
    {
        double GetSpeed();
        void VectorSum(double x, double y);
        void NoSpeedVectorSum(double x, double y);
        MutablePosition2D GetPosition();
    }
}
