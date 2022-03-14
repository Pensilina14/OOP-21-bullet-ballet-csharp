using OOP21_bullet_ballet_cSharp.Brunelli;
using OOP21_bullet_ballet_cSharp.Pioggia;
using OOP21_bullet_ballet_cSharp.Rengo.EntityLevel;
using OOP21_bullet_ballet_cSharp.Baiocchi;
using NUnit.Framework;

namespace OOP21_task_cSharp.Brunelli.BrunelliTest
{
    [TestFixture]
    public class WeaponTest{

        private readonly IDimension2D dimension = new Dimension2DCore(2,2);
        private readonly ISpeedVector2D speedVector = new SpeedVector2DCore(new MutablePosition2D(0, 720), 1);
        private readonly IGameEnvironment gameEnvironment = new GameEnvironment();
        private const double mass = 5.0;
        private const EntityLevel.WeaponType weaponType = EntityLevel.WeaponType.GUN;

        private IWeapon weapon = new Weapon(weaponType, dimension, gameEnvironment, mass, speedVector);
        
        [Test]
        public void TestHasAmmo()
        {
            Assert.True(weapon.HasAmmo);
            int numOfBullets = weapon.GetLimitBullets;
            Assert.AreEqual(weapon.GetAmmoLeft, numOfBullets);
        }

        [Test]
        public void TestRecharge()
        {
            weapon.Recharge;
            weapon.Recharge;
            int numOfBullets = weapon.GetAmmoLeft;
            Assert.AreEqual(weapon.TotalAmmo, numOfBullets);
        }

        [Test]
        public void TestDecreaseAmmo()
        {
            weapon.DecreaseAmmo;
            bool check = weapon.GetAmmoLeft == weapon.GetLimitBullets;
            Assert.False(check);
        }

        public void TestTypeOfBulletInUse()
        {
            Assert.AreEqual(weapon.GetTypeOfBulletInUse, EntityLevel.BulletType.CLASSIC);
        }
    }
}
