namespace OOP21_task_cSharp.Pioggia
{
    public interface IMutablePosition2D
    {
        IPair GetCoordinates();
        double GetX();
        double GetY();
        void SetPosition(double x, double y);
    }
}
