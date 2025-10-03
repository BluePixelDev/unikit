using UnityEngine;
using UnityEngine.Events;

namespace BP.UniKit
{
    [AddComponentMenu("UniKit/On Collision 2D")]
    public class OnCollision2D : MonoBehaviour
    {
        public UnityEvent<Collision2D> Entered;
        public UnityEvent<Collision2D> Stayed;
        public UnityEvent<Collision2D> Left;

        private void OnCollisionEnter2D(Collision2D collision) => Entered?.Invoke(collision);
        private void OnCollisionStay2D(Collision2D collision) => Stayed?.Invoke(collision);
        private void OnCollisionExit2D(Collision2D collision) => Left?.Invoke(collision);
    }
}
