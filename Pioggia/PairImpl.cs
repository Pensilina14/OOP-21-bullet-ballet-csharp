using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class PairImpl : Pair
{
    private readonly double x;
    private readonly double y;

    public PairImpl(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    double getX() { return x; }
    double getY() { return y; }
    double getPair() { return new PairImpl(x, y)}
}
