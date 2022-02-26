using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP21_task_cSharp.Rengo
{
    public interface ICharacters
    {
        double GetHealth();

        bool IsAlive();

        void SetHealth(double setHealth);

        // Weapon getWeapon();

        // void SetWeapon(Weapon weapon);

        string GetName();

        void IncreaseHealth(double increaseHealth);

        void DecreaseHealth(double decreaseHealth);
    }
}
