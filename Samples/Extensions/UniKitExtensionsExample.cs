using UnityEngine;

namespace BP.UniKit
{
    public class UniKitExtensionsExample : MonoBehaviour
    {
        void Start()
        {
            var newVector = new Vector3(0, 0, 0);
            newVector = newVector.AddX(10).AddY(10).Divide(5).Multiply(10);
            Debug.Log(newVector);

            var randVector = UniKit.RandomVector3(-10, 10);
            Debug.Log(randVector);
        }
    }
}
