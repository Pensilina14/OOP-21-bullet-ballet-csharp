using System.Diagnostics;
using NUnit.Framework;

using OOP21_bullet_ballet_cSharp.Rengo;
using OOP21_task_cSharp.Rengo;

using OOP21_bullet_ballet_cSharp.Pioggia;
using OOP21_task_cSharp.Pioggia;
using OOP21_task_cSharp.Baiocchi;

namespace OOP21_task_cSharp.Rengo.RengoTest
{
    public class CharactersTest
    {

        private Dimension2DCore dimension = new Dimension2DCore(2,2);
        private SpeedVector2DCore speedVector = new SpeedVector2DCore(new MutablePosition2D(0, 720), 1);
        private GameEnvironment gameEnvironment = new GameEnvironment();

        private const double mass = 10.0;
        private const double health = 100.0;

        private const string playerName = "Luigi";
        private const string enemyName = "Mario";

        private Player player = new Player(playerName, health, dimension, speedVector, gameEnvironment, mass);
        private Enemy enemy = new Enemy(enemyName, health,  dimension, speedVector, gameEnvironment, mass);

        [Test]
        public void TestPlayer()
        {
            Assert.Equals(playerName, player.GetName());
            Assert.Equals(health, player.GetHealth());
            Assert.Equals(mass, player.GetMass());
            Assert.True(player.IsAlive());

            player.SetHealth(50.0);
            Assert.Equals(50.0, player.GetHealth());

            player.SetHealth(-5.55);
            Assert.False(player.IsAlive());
        }

        [Test]
        public void TestEnemy()
        {
            Assert.Equals(enemyName, enemy.GetName());
            Assert.Equals(health, enemy.GetHealth());
            Assert.Equals(mass, enemy.GetMass());
            Assert.Truee(enemy.IsAlive());

            enemy.SetHealth(50.0);
            Assert.Equals(50.0, enemy.GetHealth());

            enemy.SetHealth(-3.33);
            Assert.False(enemy.IsAlive());
        }
    }
}
