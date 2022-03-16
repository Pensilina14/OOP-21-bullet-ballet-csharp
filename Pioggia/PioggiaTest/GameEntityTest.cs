using System.Diagnostics;
using NUnit.Framework;
using OOP21_bullet_ballet_cSharp.Pioggia;
using OOP21_task_cSharp.Baiocchi;
using OOP21_task_cSharp.Pioggia;

namespace OOP_21_bullet_ballet_csharp.Pioggia.PioggiaTest
{
    public class GameEntityTest
    {
        private IPhysicalObject gameObject = new GameEntity(new SpeedVector2DCore(new MutablePosition2DCore(0, 720), 1), new GameEnvironment(0, 720), 1
            , new Dimension2DCore(2, 2));

        [Test]
        public void TestMutablePosition2D()
        {
            var entity = new GameEntity(new SpeedVector2DCore(new MutablePosition2DCore(0, 720), 1), new GameEnvironment(0, 720), 1
                , new Dimension2DCore(2, 2));
            Assert.AreEqual(entity.GetPosition().GetX(), 0.0);
            Assert.AreEqual(entity.GetPosition().GetY(), 720.0);
        }

        [Test]
        public void testMoveUp()
        {
            var entity = new GameEntity(new SpeedVector2DCore(new MutablePosition2DCore(0, 720), 1), new GameEnvironment(0, 720), 1
                , new Dimension2DCore(2, 2));
            bool isStill = !entity.MoveUp(800);
            Assert.True(isStill);
            isStill = entity.MoveUp(-800);
            Assert.True(isStill);
        }
        
        [Test]
        public void testMoveDown()
        {
            gameObject.MoveDown(500);
            Assert.AreEqual(gameObject.GetPosition().GetX(), 0.0);
            Assert.AreEqual(gameObject.GetPosition().GetY(), 1220.0);
        }
        
        [Test]
        public void testMoveRight()
        {
            var entity = new GameEntity(new SpeedVector2DCore(new MutablePosition2DCore(0, 720), 1), new GameEnvironment(0, 720), 1
                , new Dimension2DCore(2, 2));
            bool isStill = !entity.MoveRight(entity.GetGameEnvironment()
                .GetDimension().GetWidth());
            Assert.True(isStill);
            bool isMoving = entity.MoveRight(entity.GetGameEnvironment()
                .GetDimension().GetWidth() - entity.GetDimension().GetWidth());
            Assert.True(isMoving);
        }
        
        [Test]
        public void testMoveLeft()
        {
            double testPosition = 180.0;
            bool isStill = !gameObject.MoveLeft(1);
            Assert.True(isStill);
            gameObject.GetPosition().SetPosition(testPosition, gameObject.GetPosition().GetY());
            bool isMoving = gameObject.MoveLeft(testPosition - this.gameObject.GetDimension().GetWidth());
            Assert.True(isMoving);
        }
        
    }
}