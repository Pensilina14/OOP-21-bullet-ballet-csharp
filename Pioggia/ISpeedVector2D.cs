namespace OOP21_task_cSharp.Pioggia
{
    public interface ISpeedVector2D
    {
        double GetSpeed();
        void VectorSum(double x, double y);
        void NoSpeedVectorSum(double x, double y);
        IMutablePosition2D GetPosition();
    }
}
