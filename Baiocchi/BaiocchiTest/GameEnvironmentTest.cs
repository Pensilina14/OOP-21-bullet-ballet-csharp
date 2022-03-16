using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using NUnit.Framework;
using OOP_21_bullet_ballet_csharp.Pioggia;
using OOP21_bullet_ballet_cSharp.Pioggia;
using OOP21_task_cSharp.Brunelli;
using OOP21_task_cSharp.Pioggia;
using OOP21_task_cSharp.Rengo;


namespace OOP21_task_cSharp.Baiocchi.BaiocchiTest
{
    [TestFixture]
    public class GameEnvironmentTest
    {
        private readonly IEnvironment _env = new GameEnvironment();
        private const double DEFAULT_DIM = 20.0;
        private const double DEFAULT_MASS = 10.0;
        private const double DEFAULT_SPEED = 1.0;

        [Test]
        public void TestGravity()
        {
            Assert.AreEqual(1.0, _env.GetGravity());
        }

        [Test]
        public void TestDimension()
        {
            IDimension2D expectedDimension = new Dimension2DCore(DEFAULT_DIM, DEFAULT_DIM);
            Assert.AreEqual(expectedDimension.GetHeight(),  _env.GetDimension().GetHeight());
            Assert.AreEqual(expectedDimension.GetWidth(), _env.GetDimension().GetWidth());
        }

        [Test]
        public void TestEntityManagerAdd()
        {
            Player player = new Player("Caio", new Dimension2DCore(DEFAULT_DIM / 10, DEFAULT_DIM / 10),
                new SpeedVector2DCore(new MutablePosition2DCore(1, 1), DEFAULT_SPEED), this._env, DEFAULT_MASS);
            Enemy enemy = new Enemy(new Dimension2DCore(DEFAULT_DIM / 10, DEFAULT_DIM / 10), 
                new SpeedVector2DCore(new MutablePosition2DCore(0, 1), DEFAULT_SPEED), this._env, DEFAULT_MASS);
            Weapon weapon = new Weapon(WeaponType.GUN, new Dimension2DCore(DEFAULT_DIM / 10, DEFAULT_DIM / 10),
                DEFAULT_MASS, new SpeedVector2DCore(new MutablePosition2DCore(1, 0), DEFAULT_SPEED), this._env);
            this._env.GetEntityManager().SetPlayer(player);
            this._env.GetEntityManager().AddEnemy(enemy);
            this._env.GetEntityManager().AddWeapon(weapon);
            Assert.AreEqual(player, this._env.GetEntityManager().GetPlayer());
            Assert.AreEqual(new List<Enemy>(){enemy}, this._env.GetEntityManager().GetEnemies());
            Assert.AreEqual(new List<Weapon>(){weapon}, this._env.GetEntityManager().GetWeapons());
        }

        [Test]
        public void TestDeleteObjByPosition()
        {
            IMutablePosition2D playerPos = new MutablePosition2DCore(1, 1);
            IMutablePosition2D enemyPos = new MutablePosition2DCore(0, 1);
            IMutablePosition2D weaponPos = new MutablePosition2DCore(1, 0);
            Player player = new Player("Caio", new Dimension2DCore(DEFAULT_DIM / 10, DEFAULT_DIM / 10),
                new SpeedVector2DCore(playerPos, DEFAULT_SPEED), this._env, DEFAULT_MASS);
            Enemy enemy = new Enemy(new Dimension2DCore(DEFAULT_DIM / 10, DEFAULT_DIM / 10), 
                new SpeedVector2DCore(enemyPos, DEFAULT_SPEED), this._env, DEFAULT_MASS);
            Weapon weapon = new Weapon(WeaponType.GUN, new Dimension2DCore(DEFAULT_DIM / 10, DEFAULT_DIM / 10),
                DEFAULT_MASS, new SpeedVector2DCore(weaponPos, DEFAULT_SPEED), this._env);
            this._env.GetEntityManager().SetPlayer(player);
            this._env.GetEntityManager().AddEnemy(enemy);
            this._env.GetEntityManager().AddWeapon(weapon);
            this._env.DeleteObjByPosition(playerPos);
            this._env.DeleteObjByPosition(enemyPos);
            this._env.DeleteObjByPosition(weaponPos);
            Assert.True(this._env.GetEntityManager().GetPlayer() == null);
            Assert.True(this._env.GetEntityManager().GetEnemies().Count == 0);
            Assert.True(this._env.GetEntityManager().GetWeapons().Count == 0);
        }
    }
}