using OOP21_task_cSharp.Rengo;

namespace OOP21_task_cSharp.Brunelli
{
    public interface IBullet
    {
        double GetDamage();
        void SetDamage(double value);
        bool IsShot();
        void fire();
        BulletType GetBulletType();
    }
}