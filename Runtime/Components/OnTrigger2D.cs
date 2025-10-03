using UnityEngine;
using UnityEngine.Events;

namespace BP.UniKit
{
    [AddComponentMenu("UniKit/On Trigger 2D")]
    public class OnTrigger2D : MonoBehaviour
    {
        public UnityEvent<Collider2D> Entered;
        public UnityEvent<Collider2D> Stayed;
        public UnityEvent<Collider2D> Left;

        private void OnTriggerEnter2D(Collider2D other) => Entered?.Invoke(other);
        private void OnTriggerStay2D(Collider2D other) => Stayed?.Invoke(other);
        private void OnTriggerExit2D(Collider2D other) => Left?.Invoke(other);
    }
}