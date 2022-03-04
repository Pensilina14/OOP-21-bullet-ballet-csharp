using System;
using OOP21_task_cSharp.Pioggia;

namespace OOP21_task_cSharp.Baiocchi
{
    public class GameEnvironment : IEnvironment
    {
        public readonly static double DEFAULT_DIM = 20.0;

        private readonly double _gravity;
        private readonly Dimension2D _dimension;
        private readonly IEntityManager _entities;

        public GameEnvironment()
        {
            _gravity = 1.0;
            _dimension = new Dimension2Dimpl(DEFAULT_DIM, DEFAULT_DIM);
            _entities = new EntityContainer();
        }

        public GameEnvironment(double height, double width)
        {
            _gravity = 1.0;
            _dimension = new Dimension2Dimpl(height, width);
            _entities = new EntityContainer();
        }

        public GameEnvironment(double gravity, double height, double width, IEntityManager container)
        {
            _gravity = 1.0;
            _dimension = new Dimension2Dimpl(height, width);
            _entities = container;
        }

        public double getGravity()
        {
            return _gravity;
        }

        public Dimension2D getDimension()
        {
            return _dimension;
        }

        public IEntityManager getEntityManager()
        {
            return _entities;
        }

        public bool deleteObjByPosition(IMutablePosition2D targetPos)
        {
            return _entities.DeleteEntity(targetPos);
        }
    }
}