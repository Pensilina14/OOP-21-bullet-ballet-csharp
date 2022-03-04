using OOP21_task_cSharp.Pioggia;
/// <summary>
/// Summary description for Class1
/// </summary>
public class PairCore : IPair
{
    private readonly double _x;
    private readonly double _y;

    public PairCore(double x, double y)
    {
        this._x = x;
        this._y = y;
    }

    double IPair.X => this._x;

    double IPair.Y => this._y;
}
