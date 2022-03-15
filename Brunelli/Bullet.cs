using OOP21_bullet_ballet_cSharp.Pioggia;
using OOP21_task_cSharp.Pioggia;
using OOP21_task_cSharp.Baiocchi;
using OOP21_task_cSharp.Rengo;
using System;

namespace OOP21_task_cSharp.Brunelli
{
	public class Bullet : GameEntity, IBullet 
	{
		private static readonly double _FACTOR = 10.0;
		protected static readonly double _MASS = 2.5;
		private static readonly IDimension2D Dimension = new Dimension2DCore(1, 1);
		private double _damage;
		private BulletType _bulletType;

		public Bullet(ISpeedVector2D vector, IEnvironment gameEnvironment
			, BulletType bulletType) : base(vector, gameEnvironment, _MASS, Dimension)
		{
			this._bulletType = bulletType;
			this._damage = _FACTOR;
		}
		
		public double GetDamage() => this._damage;

    	public void SetDamage(double value) => this._damage = value;

        public BulletType GetBulletType() => this._bulletType;
	}
}