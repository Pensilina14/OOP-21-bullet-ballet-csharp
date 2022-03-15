using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using NUnit.Framework;
using OOP21_bullet_ballet_cSharp.Pioggia;
using OOP21_task_cSharp.Pioggia;


namespace OOP21_task_cSharp.Baiocchi.BaiocchiTest
{
    [TestFixture]
    public class GameEnvironmentTest
    {
        private readonly IEnvironment _env = new GameEnvironment();
        private const double DEFAULT_DIM = 20.0;

        [Test]
        public void TestGravity()
        {
            Assert.AreEqual(1.0, _env.getGravity());
        }

        [Test]
        public void TestDimension()
        {
            IDimension2D expectedDimension = new Dimension2DCore(DEFAULT_DIM, DEFAULT_DIM);
            Assert.AreEqual(expectedDimension, _env);
        }
    }
}