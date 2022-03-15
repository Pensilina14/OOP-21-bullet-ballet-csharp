using OOP21_task_cSharp.Rengo;
using OOP21_task_cSharp.Baiocchi;
using OOP21_task_cSharp.Pioggia;


namespace OOP21_task_cSharp.Brunelli
{
    public class Weapon : GameEntity, IWeapon
    {
        private readonly static int DISTANCE_X = 15;
        private readonly static int DISTANCE_Y = 6;
		private readonly static double DMG_GUN = 5;
		private readonly static double DMG_AUTO = 3;
		private readonly static double DMG_SHOTGUN = 10;
        private readonly int _limitBullets;
        private readonly int _limitChargers;
        private bool _mode;
        private int _currentAmmo;
        private int _indexCharger;
        private List<List<Bullet>> _bandolier;
        private readonly WeaponType _weaponType;
		private double _damage;

        public Weapon(WeaponType weaponType, IDimension2D dimension,
            double mass, ISpeedVector2D vector, IEnvironment gameEnvironment) : base(vector, gameEnvironment, mass, dimension)
        {
            this._weaponType = weaponType;
            this._limitBullets = (int) weaponType;
            this._limitChargers = (int) weaponType;
            this._currentAmmo = this.GetLimitBullets();
            this._mode = false;
            this._indexCharger = 0;
            this._bandolier = new List<List<Bullet>>();
            InitializeWeapon();
        }

        private void InitializeWeapon()
        {
            switch (this._weaponType)
            {
                case WeaponType.GUN:
                    this._damage = DMG_GUN;
                    break;
                case WeaponType.AUTO:
					this._damage = DMG_AUTO;
                    break;
                case WeaponType.SHOTGUN:
					this._damage = DMG_SHOTGUN;
                    break;
                default: Console.WriteLine("Error");
                    return;
            }
			
			var charger = new List<Bullet>();
			
            var speedVector = new SpeedVector2DCore();
			for ( int i = 0; i < GetLimitBullets(); i++)
			{
				charger.Add(new Bullet(speedVector, this.GetGameEnvironment(), BulletType.CLASSIC));
			}
			charger.ForEach(delegate(Bullet b) { b.SetDamage(this._damage); });
            this._bandolier.Add(charger);
			for ( int y = 1; y < this.GetLimitChargers(); y++)
			{
				this._bandolier.Add(new List<Bullet>());
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
            if (this._bandolier[_indexCharger].Count == 0)
            {
                this.SwitchCharger();
            }
            return this._bandolier[this._indexCharger].Count > 0;
        }

        public void DecreaseAmmo()
        {
            if (this._mode)
            {
                if (!HasAmmo())
                {
                    SwitchCharger();
                }
                this._currentAmmo--;
                this._bandolier[_indexCharger].RemoveAt(_currentAmmo);
            }
        }

        public void Recharge()
        {
            var charger = new List<Bullet>();
            for (int i = 0; i < this._limitBullets; i++)
            {
                charger.Add(new Bullet(this.GetSpeedVector(), this.GetGameEnvironment(), BulletType.CLASSIC));
            }

            charger.ForEach(delegate(Bullet b)
            {
                b.SetDamage(this._damage);
            });
            this.SwitchCharger();
            this._bandolier.Add(charger);
            if (this._indexCharger == 0)
            {
                this._indexCharger = this._limitChargers;
            }
            this._indexCharger--;
            this._currentAmmo = this._bandolier[this._indexCharger].Count;
        }

        public BulletType? GetTypeOfBulletInUse()
        {
            if(!HasAmmo())
            {
                SwitchCharger();
                if (!HasAmmo())
                {
                    Console.WriteLine("Error - finished Bullets");
                    return null;
                }
            }

            int indexAmmo = _currentAmmo - 1;
            List <Bullet> charger = _bandolier[_indexCharger];
            BulletType? actualBullet = charger[indexAmmo].GetBulletType();
            return actualBullet;
        }

        public int TotalAmmo() => this.GetLimitChargers() * GetLimitBullets();

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

        public void SetMode(bool value) => this._mode = value;
        
        public void SetPosition(IMutablePosition2D newPos)
        {
            GetPosition().SetPosition(newPos.GetX() + DISTANCE_X, newPos.GetY() + DISTANCE_Y);
        }

        public WeaponType GetTypeOfWeapon() => this._weaponType;
        
        public int GetLimitBullets() => this._limitBullets;

        public int GetLimitChargers() => this._limitChargers;
    }
}