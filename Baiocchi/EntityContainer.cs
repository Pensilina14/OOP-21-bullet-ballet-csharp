using System;
using System.Collections.Generic;
using System.Linq;
using OOP21_task_cSharp.Brunelli;
using OOP21_task_cSharp.Pioggia;
using OOP21_task_cSharp.Rengo;

namespace OOP21_task_cSharp.Baiocchi
{
    /// <summary>
    /// This class is responsible of storing and managing 
    /// the different entities in the game with the use of
    /// a data structure that maps every <see cref="List"/> of entities, each
    /// one has a different type, to their relative label which is an element
    /// of the <see cref="GameEntities"/> enumeration that states the typo of the List
    /// associated. Also note that this is model side.
    /// </summary>
    public class EntityContainer : AbstractContainer<GameEntity>, IEntityManager
    {
        public Player? GetPlayer()
        {
            IList<GameEntity>? player = 
                   (from entry in this.GetContainer()
                    where entry.Key == GameEntities.PLAYER
                    select entry.Value).ElementAt(0);
            if (player != null && player[0] is Player)
            {
                return player[0] as Player;
            }
            return null;
        }

        public IList<Enemy>? GetEnemies()
        {
            IList<Enemy> enemies = new List<Enemy>();
            foreach (KeyValuePair<GameEntities, IList<GameEntity>?> entry in this.GetContainer())
            {
                if (entry.Key == GameEntities.ENEMY)
                {
                    foreach (GameEntity entity in entry.Value)
                    {
                        if (entity is Enemy)
                        {
                            enemies.Add(entity as Enemy);
                        }
                    }
                }
            }
            return enemies;
        }

        public IList<Weapon>? GetWeapons()
        {
            IList<Weapon> weapons = new List<Weapon>();
            foreach (KeyValuePair<GameEntities, IList<GameEntity>?> entry in this.GetContainer())
            {
                if (entry.Key == GameEntities.WEAPON)
                {
                    foreach (GameEntity entity in entry.Value)
                    {
                        if (entity is WeaponImpl)
                        {
                            weapons.Add(entity as WeaponImpl);
                        }
                    }
                }
            }
            return weapons;
        }

        public void SetPlayer(Player player)
        {
            this.GetContainer().First().Value[0] = player;
        }

        public bool AddEnemy(Enemy enemy)
        {
            foreach (KeyValuePair<GameEntities, IList<GameEntity>?> entry in this.GetContainer())
            {
                if (entry.Key == GameEntities.ENEMY)
                {
                    entry.Value.Add(enemy);
                    return true;
                }
            }
            return false;
        }

        public bool AddWeapon(WeaponImpl weapon)
        {
            foreach (KeyValuePair<GameEntities, IList<GameEntity>?> entry in this.GetContainer())
            {
                if (entry.Key == GameEntities.WEAPON)
                {
                    entry.Value.Add(weapon);
                    return true;
                }
            }
            return false;
        }

        public IList<IPhysicalObject>? GetObjsList()
        {
            IList<IPhysicalObject>? entities = new List<IPhysicalObject>();
            foreach (KeyValuePair<GameEntities, IList<GameEntity>?> entry in this.GetContainer())
            {
                entities.ToList().AddRange(entry.Value);
            }
            return entities;
        }

        public bool DeleteEntity(IMutablePosition2D pos)
        {
            foreach (KeyValuePair<GameEntities, IList<GameEntity>?> entry in this.GetContainer())
            {
                foreach (GameEntity entity in entry.Value)
                {
                    if (entity.GetPosition().Equals(pos))
                    {
                        entry.Value.Remove(entity);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}