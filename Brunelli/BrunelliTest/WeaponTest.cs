using OOP21_bullet_ballet_cSharp.Pioggia;
using OOP21_task_cSharp.Rengo;
using NUnit.Framework;
using OOP_21_bullet_ballet_csharp.Pioggia;
using OOP21_task_cSharp.Baiocchi;
using OOP21_task_cSharp.Pioggia;

namespace OOP21_task_cSharp.Brunelli.BrunelliTest
{

    public class WeaponTest{

        private static readonly IDimension2D Dimension = new Dimension2DCore(2,2);
        private static readonly ISpeedVector2D SpeedVector = new SpeedVector2DCore(new MutablePosition2DCore(0, 0), 1);
        private static readonly IEnvironment GameEnvironment = new GameEnvironment();
        private const double Mass = 5.0;
        private const WeaponType WeaponType = Rengo.WeaponType.GUN;

        private readonly IWeapon _weapon = new Weapon(WeaponType, Dimension, Mass, SpeedVector, GameEnvironment);
        
        [Test]
        public void TestHasAmmo()
        {
            var weapon2 = _weapon;
            Assert.True(weapon2.HasAmmo());
            int numOfBullets = weapon2.GetLimitBullets();
            Assert.AreEqual(weapon2.GetAmmoLeft(), numOfBullets);
        }

        [Test]
        public void TestRecharge()
        {
            IWeapon weapon3 = new Weapon(WeaponType, Dimension, Mass, SpeedVector, GameEnvironment);
            for (int i = 1; i < weapon3.GetLimitChargers(); i++)
            {
                weapon3.Recharge();
            }
            int numOfBullets = weapon3.GetAmmoLeft();
            Assert.AreEqual(weapon3.TotalAmmo(), numOfBullets);
        }

        [Test]
        public void TestDecreaseAmmo()
        {
            IWeapon weapon4 = new Weapon(WeaponType, Dimension, Mass, SpeedVector, GameEnvironment);
            weapon4.DecreaseAmmo();
            weapon4.DecreaseAmmo();
            bool check = weapon4.GetAmmoLeft() == weapon4.GetLimitBullets();
            Assert.True(check);
            Assert.AreEqual(weapon4.GetAmmoLeft(), 6);
            weapon4.SetMode(true);
            weapon4.DecreaseAmmo();
            weapon4.DecreaseAmmo();
            bool check2 = weapon4.GetAmmoLeft() == weapon4.GetLimitBullets();
            Assert.AreEqual(weapon4.GetAmmoLeft(), 4);
        }
        
        [Test]
        public void TestTypeOfBulletInUse()
        {
            IWeapon weapon5 = new Weapon(WeaponType, Dimension, Mass, SpeedVector, GameEnvironment);
            Assert.AreEqual(weapon5.GetTypeOfBulletInUse(), BulletType.CLASSIC);
        }
    }
}
