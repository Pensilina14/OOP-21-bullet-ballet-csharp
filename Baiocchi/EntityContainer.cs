using System.Collections.Generic;
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
            
        }

        public List<Enemy>? GetEnemies()
        {
            
        }

        public void SetPlayer(Player player)
        {
            
        }

        public void AddEnemy(Enemy enemy)
        {
            
        }

        public IList<GameEntity>? GetObjsList()
        {
            
        }

        public bool DeleteEntity(IMutablePosition2D pos)
        {
            
        }
    }
}