using System;
using System.Collections.Generic;

namespace OOP21_task_cSharp.Baiocchi
{
    /// <summary>
    /// Specifies a contract applicable to every class that needs to store informations
    /// in a shelves-style mode.
    /// This means that implementations of this interface must have a data structure for each shelf.
    /// </summary>
    /// <typeparam name="TX">type of the container elements.</typeparam>
    internal interface IContainer<TX>
    {
        /// <summary>
        /// Reveals if a container is empty or not.
        /// </summary>
        /// <returns>true if container is empty, false otherwise.</returns>
        bool IsEmpty();
        /// <summary>
        /// Returns the container data structure.
        /// </summary>
        /// <returns>container, a data structure.</returns>
        Dictionary<GameEntities, IList<TX>?> GetContainer();
    }
}