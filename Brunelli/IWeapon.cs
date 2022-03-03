namespace OOP21_task_cSharp.Brunelli
{
    public interface Weapon
    {
        int AmmoLeft();

        int TotalAmmo();

        void DecreaseAmmo();

        bool HasAmmo();

        string Name();///done

        void Recharge(List<Bullet> charher);

        void SmartRecharge();

        int LimitBullets();///done

        int LimitChargers();///done

        Optional<BulletType> TypeOfBulletInUse();

        EntityList.Weapons TypeOfWeapon();///done

        void Mode();///done

        void Position(OOP21_task_cSharp.Pioggia.IMutablePosition2D newPos);///done
        
        int IndexCharger();///done
    }
}
