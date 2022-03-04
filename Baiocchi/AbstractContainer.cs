using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOP21_task_cSharp.Baiocchi
{
    public class AbstractContainer<TX> : IContainer<TX>
    {
        private readonly ISet<GameEntities> _gameEntities = new HashSet<GameEntities>()
            {GameEntities.PLAYER, GameEntities.ENEMY, GameEntities.WEAPON, GameEntities.BULLET};
        private readonly Dictionary<GameEntities, IList<TX>?> _container;

        public AbstractContainer()
        {
            _container = new Dictionary<GameEntities, IList<TX>?>();
            foreach (GameEntities entity in _gameEntities)
            {
                _container.Add(entity, new List<TX>());
            }
        }

        public bool IsEmpty()
        {
            foreach (IList<TX>? value in _container.Values)
            {
                if (value != null)
                {
                    if (value.Count != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Dictionary<GameEntities, IList<TX>?> GetContainer()
        {
            return _container;
        }
    }
}