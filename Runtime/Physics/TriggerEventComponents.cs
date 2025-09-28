using UnityEngine;
using UnityEngine.Events;

namespace BP.UniKit
{
    [AddComponentMenu("UniKit/Trigger Event 2D")]
    public class CollisionEventTrigger2D : MonoBehaviour
    {
        public UnityEvent<Collider2D> Entered;
        public UnityEvent<Collider2D> Stayed;
        public UnityEvent<Collider2D> Left;

        private void OnTriggerEnter2D(Collider2D other) => Entered?.Invoke(other);
        private void OnTriggerStay2D(Collider2D other) => Stayed?.Invoke(other);
        private void OnTriggerExit2D(Collider2D other) => Left?.Invoke(other);
    }

    [AddComponentMenu("UniKit/Trigger Event")]
    public class CollisionEventTrigger : MonoBehaviour
    {
        public UnityEvent<Collider> Entered;
        public UnityEvent<Collider> Stayed;
        public UnityEvent<Collider> Left;

        private void OnTriggerEnter(Collider other) => Entered?.Invoke(other);
        private void OnTriggerStay(Collider other) => Stayed?.Invoke(other);
        private void OnTriggerExit(Collider other) => Left?.Invoke(other);
    }
}