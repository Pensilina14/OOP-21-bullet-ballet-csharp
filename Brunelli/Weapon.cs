using System;
using OOP21_task_cSharp.Pioggia.GameEntity;
using OOP21_task_cSharp.Rengo.EntityLevel;
using OOP21_task_cSharp.Pioggia.IDimension2D;
using OOP21_task_cSharp.Pioggia.ISpeedVector2D;
using OOP21_task_cSharp.Baiocchi.IEnvironment;
using Brunelli.Bullet;



namespace OOP21_task_cSharp.Brunelli
{
    public class Weapon : IWeapon, GameEntity
    {
        private readonly static int DISTANCE_X = 15;
        private readonly static int DISTANCE_Y = 6;
		private readonly static double DMG_GUN = 5;
		private readonly static double DMG_AUTO = 3;
		private readonly static double DMG_SHOTGUN = 10;
        private readonly int _limitBullets;
        private readonly int _limitChargers;
        private readonly string _name;
        private readonly bool _mode;
        private int _currentAmmo;
        private int _indexCharger;
        private List<List<Bullet>> _bandolier;
        private readonly EntityLevel.Weapons _weaponType;
		private readonly double _damage;

        public Weapon(EntityLevel.WeaponType weaponType, IDimension2D dimension, IEnvironment gameEnv,
        double mass, ISpeedVector2D vector)
        {
            base(vector, gameEnvironment, mass, dimension);
            this._weaponType = weaponType;
            this.Set_limitBullets(weaponType.getLimBullets());
            this.Set_limitChargers(weaponType.getLimChargers());
            this._currentAmmo = Get_limitBullets();
            this._mode = false;
            this.Set_indexCharger(0);   
        }

        private void initializeWeapon()
        {
            switch (this._weaponType)
            {
                case EnityList.WeaponType.GUN:
                    this.Set_limitBullets((int) this._weaponType);
					this._damage = DMG_GUN;
                    break;
                case EnityList.WeaponType.AUTO:
                    this.Set_limitBullets((int) this._weaponType);
					this._damage = DMG_AUTO;
                    break;
                case EnityList.WeaponType.SHOTGUN:
                    this.Set_limitBullets((int) this._weaponType);
					this._damage = DMG_SHOTGUN;
                    break;
                default: Console.WriteLine("Error");
                    return;
            }
			
			var charger = new List<IBullet>();
			
			for ( int i = 0; i < Get_limitBullets(); i++)
			{
				charger.Add(new Bullet(vector, this._gameEnvironment, EntityLevel.BulletType.CLASSIC));
			}
			charger.ForEach( b -> b.Damage(this._damage));
			
			this._bandolier = new List<List<IBullet>>();
			this._bandolier.Add(charger);
			for ( int y = 1; y < this.Get_limitChargers(); y++)
			{
				this._bandolier.Add(new List<IBullet>());
			}
        }

        private void SwitchCharger()
        {
            if (_indexCharger == _limitChargers-1)
            {
                this._indexCharger = 0;
            } else 
            {
                this._indexCharger++;
            }
            this._currentAmmo = this._bandolier[_indexCharger].Count;
        }

        public bool HasAmmo(){
            if (this._bandolier.get(_indexCharger).Count == 0)
            {
                this.SwitchCharger;
            }
            return this._bandolier[this._indexCharger].Count > 0;
        }

        public void DecreaseAmmo()
        {
            if (this._mode)
            {
                if (!HasAmmo)
                {
                    SwitchCharger;
                }
                this._currentAmmo--;
                this._bandolier[this._indexCharger].Remove(this._currentAmmo);
            }
        }

        public async void Recharge()
        {
            List<IBullet> charger = new List<IBullet>();
            for (int i = 0; i < this._limitBullets; i++)
            {
                charger.Add(new Bullet(vector, this._gameEnvironment, EntityLevel.BulletType.CLASSIC));
            }
            charger.ForEach( b -> b.SetDamage(this._damage));
            SwitchCharger;
            this._bandolier.Add(chaarger);
            if (this._indexCharger == 0)
            {
                this._indexCharger = this._limitChargers;
            }
            this._indexCharger--;
            this._currentAmmo = this._bandolier[this._indexCharger].Count;
        }

        public EntityLevel.BulletType? GetTypeOfBulletInUse()
        {
            if(!HasAmmo)
            {
                SwitchCharger;
                if (!HasAmmo)
                {
                    Console.WriteLine("Error - finished Bullets");
                    return null;
                }
            }

            int indexAmmo = this._currentAmmo - 1;
            List <Bullet> charger = this._bandolier[this._indexCharger];
            Bullet? actualBullet = charger[indexAmmo].GetBulletType;
            return actualBullet;
        }

        public int TotalAmmo() => this.Get_limitChargers() * this.Get_limitBullets();

        public int GetAmmoLeft()
        {
            int sum = 0;
            foreach (var x in this._bandolier)
            {
                sum += x.Count;
            }

            return sum;
        }

        public bool GetMode() => this._mode;

        public void SetMode() => this._mode = value;

        public int Get_indexCharger() => this.Get_indexCharger();

        public void SetPosition(IMutablePosition2D newPos) => this.getPosition..get().setPosition(newPos.getX + DISTANCE_X, newPos.getY + DISTANCE_Y);

        public override bool Equals(object obj)
        {
            return obj is Weapon impl &&
                   GetName() == impl.GetName();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GetName());
        }

        public EntityLevel.Weapons GetTypeOfWeapon() => this.GetTypeOfWeapon();

        public int GetLimitBullets() => this.Get_limitBullets();

        public int GetLimitChargers() => this.Get_limitChargers();
    }
}