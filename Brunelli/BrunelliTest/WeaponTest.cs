using OOP21_bullet_ballet_cSharp.Pioggia;
using OOP21_task_cSharp.Rengo;
using NUnit.Framework;
using OOP21_task_cSharp.Baiocchi;
using OOP21_task_cSharp.Pioggia;

namespace OOP21_task_cSharp.Brunelli.BrunelliTest
{

    public class WeaponTest{

        private static readonly IDimension2D Dimension = new Dimension2DCore(2,2);
        private static readonly ISpeedVector2D SpeedVector = new SpeedVector2DCore();
        private static readonly IEnvironment GameEnvironment = new GameEnvironment();
        private const double Mass = 5.0;
        private const WeaponType WeaponType = Rengo.WeaponType.GUN;

        private readonly IWeapon _weapon = new Weapon(WeaponType, Dimension, Mass, SpeedVector, GameEnvironment);
        
        [Test]
        public void TestHasAmmo()
        {
            Assert.True(_weapon.HasAmmo());
            int numOfBullets = _weapon.GetLimitBullets();
            Assert.AreEqual(_weapon.GetAmmoLeft(), numOfBullets);
        }

        [Test]
        public void TestRecharge()
        {
            for (int i = 1; i < _weapon.GetLimitChargers(); i++)
            {
                _weapon.Recharge();
            }
            int numOfBullets = _weapon.GetAmmoLeft();
            Assert.AreEqual(_weapon.TotalAmmo(), numOfBullets);
        }

        [Test]
        public void TestDecreaseAmmo()
        {
            _weapon.DecreaseAmmo();
            _weapon.DecreaseAmmo();
            bool check = _weapon.GetAmmoLeft() == _weapon.GetLimitBullets();
            Assert.True(check);
            Assert.AreEqual(_weapon.GetAmmoLeft(), 6);
            _weapon.SetMode(true);
            _weapon.DecreaseAmmo();
            _weapon.DecreaseAmmo();
            bool check2 = _weapon.GetAmmoLeft() == _weapon.GetLimitBullets();
            Assert.AreEqual(_weapon.GetAmmoLeft(), 4);
        }

        public void TestTypeOfBulletInUse()
        {
            Assert.AreEqual(_weapon.GetTypeOfBulletInUse(), BulletType.CLASSIC);
        }
    }
}
