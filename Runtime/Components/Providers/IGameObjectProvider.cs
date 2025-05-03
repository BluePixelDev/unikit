using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// Interface for components that provide <see cref="GameObject"/> instances.
    /// </summary>
    public interface IGameObjectProvider
    {
        /// <summary>
        /// Gets a <see cref="GameObject"/> instance.
        /// </summary>
        GameObject Get();
    }
}
