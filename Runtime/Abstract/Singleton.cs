using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// A base class for creating singletons.
    /// By default, the singleton is initialized before other scripts.
    /// </summary>
    [DefaultExecutionOrder(-1000)] // Ensure that the singleton is initialized before other scripts.
    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        public static T Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(this);
            }

            OnAwake();
        }

        protected virtual void OnAwake()
        {
            // Override this method to perform additional initialization.
        }
    }
}
