using OOP21_task_cSharp.Rengo;
using System;

namespace OOP21_task_cSharp.Brunelli
{
    public interface IBullet
    {
        double GetDamage();
        
        void SetDamage(double value);
        
        BulletType GetBulletType();
    }
}