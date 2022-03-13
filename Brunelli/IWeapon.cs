using OOP21_task_cSharp.Pioggia.IMutablePosition2D;
using OOP21_task_cSharp.Rengo.EntityLevel;

namespace OOP21_task_cSharp.Brunelli
{
    public interface IWeapon
    {
        int GetAmmoLeft();//done

        int TotalAmmo();//done

        void DecreaseAmmo();//done

        bool HasAmmo();//done

        string GetName();//done

        void Recharge();//done

        int GetLimitBullets();//done

        int GetLimitChargers();//done

        EntityLevel.BulletType? GetTypeOfBulletInUse();
        EntityLevel.Weapons GetTypeOfWeapon();//done

        void Mode();//done

        void SetPosition(IMutablePosition2D newPos);//done
        
        int IndexCharger();//done
    }
}
