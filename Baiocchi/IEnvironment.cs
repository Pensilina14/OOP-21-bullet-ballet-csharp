using OOP21_task_cSharp.Pioggia;

namespace OOP21_task_cSharp.Baiocchi
{
    /// <summary>
    /// This interface wraps all the virtual game world and permits interaction
    /// between objects inside a virtual map.
    /// </summary>
    public interface IEnvironment
    {
        /// <summary>
        /// Getter for Environment's gravity.
        /// </summary>
        /// <returns>Environment's gravity.</returns>
        double getGravity();
        /// <summary>
        /// Getter for Environment's dimensions.
        /// </summary>
        /// <returns>Environment's dimensions.</returns>
        IDimension2D getDimension();
        /// <summary>
        /// Return the EntityManager used by this environment.
        /// </summary>
        /// <returns>an EntityManager</returns>
        IEntityManager getEntityManager();
        /// <summary>
        /// The <see cref="Pioggia.PhysicalObject"/> to be deleted is first searched and then removed.
        /// </summary>
        /// <param name="targetPos">PhysicalObject to delete.</param>
        /// <returns>true if operation had success, false otherwise.</returns>
        bool deleteObjByPosition(IMutablePosition2D targetPos);
    }
}
