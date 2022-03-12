using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using NUnit.Framework;


namespace OOP21_task_cSharp.Baiocchi.BaiocchiTest
{
    [TestFixture]
    public class GameEnvironmentTest
    {
        private readonly IEnvironment _env = new GameEnvironment();

        [Test]
        public void TestGravity()
        {
            Assert.Equals(1.0, _env.getGravity());
        }
    }
}