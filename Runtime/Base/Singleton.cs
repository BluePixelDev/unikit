using UnityEngine;

namespace BP.UniKit
{
    [DefaultExecutionOrder(-1000)]
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

            Awaken();
        }

        protected virtual void Awaken() { }
    }
}
