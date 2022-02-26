namespace OOP21_task_cSharp.Pioggia
{
    internal interface MutablePosition2D
    {
        Pair GetCoordinates();
        double GetX();
        double GetY();
        void SetPosition(double x, double y);
    }
}
