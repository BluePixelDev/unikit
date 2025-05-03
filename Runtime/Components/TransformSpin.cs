using UnityEngine;

namespace BP.Utilkit
{
    [AddComponentMenu("Utilkit/Transform Spin")]
    public class TransformSpin : MonoBehaviour
    {
        public Vector3 direction = Vector3.up;
        public float speed = 1f;

        private void Update()
        {
            transform.Rotate(direction, speed * Time.deltaTime);
        }
    }
}
