namespace DefaultNamespace;

public interface IBullet
{
    enum BulletType
    {
        CLASSIC("Classic"),
        TOXIC("Toxic"),
        SOPORIFIC("Soporific")
    };

    string Name();
    double Damage();
    bool IsShot();
    void fire();
    BulletType BulletType();
    
}