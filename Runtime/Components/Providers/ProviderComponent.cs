using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// Base class for components that provide <see cref="GameObject"/> instances.
    /// </summary>
    public abstract class ProviderComponent : MonoBehaviour, IGameObjectProvider
    {
        public abstract GameObject Get();
    }
}
