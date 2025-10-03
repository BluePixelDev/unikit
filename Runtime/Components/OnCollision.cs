using UnityEngine;
using UnityEngine.Events;

namespace BP.UniKit
{

    [AddComponentMenu("UniKit/On Collision")]
    public class OnCollision
        : MonoBehaviour
    {
        public UnityEvent<Collision> Entered;
        public UnityEvent<Collision> Stayed;
        public UnityEvent<Collision> Left;

        private void OnCollisionEnter(Collision collision) => Entered?.Invoke(collision);
        private void OnCollisionStay(Collision collision) => Stayed?.Invoke(collision);
        private void OnCollisionExit(Collision collision) => Left?.Invoke(collision);
    }
}
