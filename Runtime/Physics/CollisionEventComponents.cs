using UnityEngine;
using UnityEngine.Events;

namespace BP.UniKit
{
    [AddComponentMenu("UniKit/Collision Event 2D")]
    public class CollisionEvent2D : MonoBehaviour
    {
        public UnityEvent<Collision2D> Entered;
        public UnityEvent<Collision2D> Stayed;
        public UnityEvent<Collision2D> Left;

        private void OnCollisionEnter2D(Collision2D collision) => Entered?.Invoke(collision);
        private void OnCollisionStay2D(Collision2D collision) => Stayed?.Invoke(collision);
        private void OnCollisionExit2D(Collision2D collision) => Left?.Invoke(collision);
    }

    [AddComponentMenu("UniKit/Collision Event")]
    public class CollisionEvent : MonoBehaviour
    {
        public UnityEvent<Collision> Entered;
        public UnityEvent<Collision> Stayed;
        public UnityEvent<Collision> Left;

        private void OnCollisionEnter(Collision collision) => Entered?.Invoke(collision);
        private void OnCollisionStay(Collision collision) => Stayed?.Invoke(collision);
        private void OnCollisionExit(Collision collision) => Left?.Invoke(collision);
    }
}
