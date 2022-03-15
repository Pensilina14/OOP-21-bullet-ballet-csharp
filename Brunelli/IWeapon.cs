using OOP21_task_cSharp.Pioggia;
using OOP21_task_cSharp.Rengo;
using System;

namespace OOP21_task_cSharp.Brunelli
{
    public interface IWeapon
    {
        int GetAmmoLeft();//done

        int TotalAmmo();//done

        void DecreaseAmmo();//done

        bool HasAmmo();//done

        void Recharge();//done

        int GetLimitBullets();//done

        int GetLimitChargers();//done

        BulletType? GetTypeOfBulletInUse();
        WeaponType GetTypeOfWeapon();//done

        bool GetMode();//done
        
        void SetMode(bool value);
        
        void SetPosition(IMutablePosition2D newPos);//done
    }
}
