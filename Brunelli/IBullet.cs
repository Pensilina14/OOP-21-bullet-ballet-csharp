using OOP21_bullet_ballet_cSharp.Rengo.EntityLevel;

namespace DefaultNamespace;


public interface IBullet
{
    double GetDamage();
    void SetDamage(double value);
    bool IsShot();
    void fire();
    EntityLevel.BulletType BulletType();
    
}