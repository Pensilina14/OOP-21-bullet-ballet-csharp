using OOP21_task_cSharp.Rengo.EntityLevel;
using OOP21_task_cSharp.Pioggia.*;
using OOP21_task_cSharp.Baiocchi.IEnvironment;

namespace OOP21_task_cSharp.Brunelli;

public class Bullet : IBullet, OOP21_task_cSharp.Pioggia.GameEntity
{
	private readonly static double _DAMAGE = 10.0;
	private readonly string _name;
	private bool _fired;
	private EntityLevel.BulletType _bulletType;

	public Bullet(ISpeedVector2D vector, IEnvironment gameEnvironment, double mass
		, IDimension2D dimension, EntityLevel.BulletType bulletType)
	{
		base(vector, gameEnvironment, mass, dimension);
		this._fired = false;
		this._bulletType = bulletType;
	}

	public string Name()
    {
        return this._name;
    }

    public double Damage()
    {
        return _DAMAGE;
    }
       
    public bool IsShot()
    {
        return this._fired;
    }

	public void Fire()
	{
		this._fired = true;
	}

    public BulletType()
    {
        return this._bulletType;
    }
}