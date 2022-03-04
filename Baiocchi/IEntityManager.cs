using System;
using System.Collections.Generic;
using OOP21_task_cSharp.Pioggia;
using OOP21_task_cSharp.Rengo;

namespace OOP21_task_cSharp.Baiocchi
{
    /// <summary>
    /// Contract for classes that implement an AbstractContainer. 
    /// and have a need to retrieve container content.
    /// This is a game-specific interface so it is supposed to 
    /// give out all the different entities of the game.
    /// </summary>
    internal interface IEntityManager
    {
        /// <summary>
        /// Returns the player.
        /// </summary>
        /// <returns>Player</returns>
        Player? GetPlayer();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Enemy>? GetEnemies();
        /// <summary>
        /// Sets given player as player.
        /// </summary>
        /// <param name="player">Player to be set as main player.</param>
        void SetPlayer(Player player);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="???"></param>
        /// <returns></returns>
        bool AddEnemy(Enemy);
        /// <summary>
        /// Returns a <see cref="List"/> of all the game entities.
        /// </summary>
        /// <returns>List of PhysicalObjects</returns>
        IList<PhysicalObject>? GetObjsList();
        /// <summary>
        /// Deletes the entity at given pos from the container.
        /// </summary>
        /// <param name="pos">pos, position of entity to delete.</param>
        /// <returns>true if the operation was successful, false otherwise.</returns>
        bool DeleteEntity(IMutablePosition2D pos);
    }
}