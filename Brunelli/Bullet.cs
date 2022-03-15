using OOP21_bullet_ballet_cSharp.Pioggia;
using OOP21_task_cSharp.Pioggia;
using OOP21_task_cSharp.Baiocchi;
using OOP21_task_cSharp.Rengo;

namespace OOP21_task_cSharp.Brunelli
{
	public class Bullet : GameEntity, IBullet 
	{
		private static readonly double _FACTOR = 10.0;
		protected static readonly double _MASS = 2.5;
		private static readonly IDimension2D _DIMENSION = new Dimension2DCore(1, 1);
		private bool _fired;
		private double _damage;
		private BulletType _bulletType;

		public Bullet(ISpeedVector2D vector, IEnvironment gameEnvironment
			, BulletType bulletType) : base(vector, gameEnvironment, _MASS, _DIMENSION)
		{
			this._fired = false;
			this._bulletType = bulletType;
			this._damage = _FACTOR;
		}

		

		public double GetDamage() => this._damage;

    	public void SetDamage(double value) => this._damage = value;

    	public bool IsShot() => this._fired;
        public void fire()
        {
	        throw new NotImplementedException();
        }

        public void Fire() => this._fired = true;

    	public BulletType GetBulletType() => this._bulletType;
	}
}