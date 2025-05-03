using UnityEngine;
using UnityEngine.Events;

namespace BP.Utilkit
{
    [AddComponentMenu("Utilkit/Collision Event Trigger 2D")]
    public class CollisionEventTrigger2D : MonoBehaviour
    {
        public UnityEvent<Collider2D> Entered;
        public UnityEvent<Collider2D> Stayed;
        public UnityEvent<Collider2D> Left;

        private void OnTriggerEnter2D(Collider2D other) => Entered?.Invoke(other);
        private void OnTriggerStay2D(Collider2D other) => Stayed?.Invoke(other);
        private void OnTriggerExit2D(Collider2D other) => Left?.Invoke(other);
    }
}