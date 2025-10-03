using UnityEngine;
using UnityEngine.Events;

namespace BP.UniKit
{
    [AddComponentMenu("UniKit/On Trigger")]
    public class OnTrigger : MonoBehaviour
    {
        public UnityEvent<Collider> Entered;
        public UnityEvent<Collider> Stayed;
        public UnityEvent<Collider> Left;

        private void OnTriggerEnter(Collider other) => Entered?.Invoke(other);
        private void OnTriggerStay(Collider other) => Stayed?.Invoke(other);
        private void OnTriggerExit(Collider other) => Left?.Invoke(other);
    }
}
