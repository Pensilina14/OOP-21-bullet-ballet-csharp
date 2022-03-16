using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP21_task_cSharp.Rengo
{
    /// <summary>
    /// A contract for all the Characters in the game.
    /// </summary>
    public interface ICharacters
    {
        /// <summary>
        /// Return the health of the character.
        /// </summary>
        /// <returns>double</returns>
        double GetHealth();

        /// <summary>
        /// Whether the character is alive or not.
        /// </summary>
        /// <returns>bool</returns>
        bool IsAlive();

        /// <summary>
        /// Set the new health of the character.
        /// </summary>
        /// <param name="setHealth"></param>
        void SetHealth(double setHealth);

        /// <summary>
        /// Returns the weapon <see cref="OOP21_task_cSharp.Brunelli.IWeapon"/> that the character owns.
        /// </summary>
        /// <returns>IWeapon</returns>
        OOP21_task_cSharp.Brunelli.IWeapon GetWeapon();

        /// <summary>
        /// Set a new IWeapon <see cref="OOP21_task_cSharp.Brunelli.IWeapon"/> to the Character.
        /// </summary>
        /// <param name="weapon"></param>
        void SetWeapon(OOP21_task_cSharp.Brunelli.IWeapon weapon);

        /// <summary>
        /// The name of the character.
        /// </summary>
        /// <returns>string</returns>
        string GetName();

        /// <summary>
        /// Increases the health of the character of the amount of increaseHealth.
        /// </summary>
        /// <param name="increaseHealth"></param>
        void IncreaseHealth(double increaseHealth);

        /// <summary>
        /// Decreases the health of the character of the amount of decreaseHealth.
        /// </summary>
        /// <param name="decreaseHealth"></param>
        void DecreaseHealth(double decreaseHealth);
    }
}
