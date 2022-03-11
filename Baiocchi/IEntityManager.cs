using System;
using System.Collections.Generic;
using OOP21_task_cSharp.Brunelli;
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
    public interface IEntityManager
    {
        /// <summary>
        /// Returns the player.
        /// </summary>
        /// <returns>Player</returns>
        Player? GetPlayer();
        /// <summary>
        /// Retrieves all the enemies.
        /// </summary>
        /// <returns>A list of enemies.</returns>
        IList<Enemy>? GetEnemies();
        /// <summary>
        /// Retrieves all the weapons.
        /// </summary>
        /// <returns>A list of weapons</returns>
        IList<Weapon>? GetWeapons();
        /// <summary>
        /// Sets given player as player.
        /// </summary>
        /// <param name="player">Player to be set as main player.</param>
        void SetPlayer(Player player);
        /// <summary>
        /// Adds an enemy to the environment.
        /// </summary>
        /// <param name="enemy"></param>
        /// <returns>true if operation was successful, false otherwise.</returns>
        bool AddEnemy(Enemy enemy);
        /// <summary>
        /// Adds a weapon to the environment.
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns>true if operation was successful, false otherwise.</returns>
        bool AddWeapon(WeaponImpl weapon);
        /// <summary>
        /// Returns a <see cref="IList"/> of all the game entities.
        /// </summary>
        /// <returns>List of PhysicalObjects</returns>
        IList<IPhysicalObject>? GetObjsList();
        /// <summary>
        /// Deletes the entity at given pos from the container.
        /// </summary>
        /// <param name="pos">pos, position of entity to delete.</param>
        /// <returns>true if the operation was successful, false otherwise.</returns>
        bool DeleteEntity(IMutablePosition2D pos);
    }
}