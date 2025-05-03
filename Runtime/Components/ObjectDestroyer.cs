using UnityEngine;

namespace BP.Utilkit
{
    [AddComponentMenu("Utilkit/Object Destroyer")]
    public class ObjectDestroyer : MonoBehaviour
    {
        [SerializeField, Tooltip("The target object to be destroyed, by default it's this one.")] private GameObject target;

        public void DestroyTarget()
        {
            Destroy(target != null ? target : gameObject);
        }
    }
}