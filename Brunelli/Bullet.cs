using OOP21_task_cSharp.Rengo.EntityLevel;
using OOP21_task_cSharp.Pioggia.ISpeedVector2D;
using OOP21_task_cSharp.Baiocchi.IEnvironment;

namespace OOP21_task_cSharp.Brunelli;

public class Bullet : IBullet, OOP21_task_cSharp.Pioggia.GameEntity
{
	private static readonly double _FACTOR = 10.0;
	protected static readonly double _MASS = 2.5;
	protected static readonly int _DIMENSION = 20;
	private bool _fired;
	private double _damage;
	private EntityLevel.BulletType _bulletType;

	public Bullet(ISpeedVector2D vector, IEnvironment gameEnvironment
		, EntityLevel.BulletType bulletType)
	{
		base(vector, gameEnvironment, _MASS, _DIMENSION);
		this._fired = false;
		this._bulletType = bulletType;
		this._damage = _FACTOR;
	}

    public double GetDamage() => _DAMAGE;

    public void SetDamage(double value) => this._damage = value;

    public bool IsShot() => this._fired;

    public void Fire() => this._fired = true;

    public GetBulletType() => this._bulletType;
}