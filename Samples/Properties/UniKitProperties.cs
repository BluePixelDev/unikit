using UnityEngine;

namespace BP.UniKit
{
    public class UniKitProperties : MonoBehaviour
    {
        [SerializeField] private MaskLayer maskLayer;
        [SerializeField] private ObjectTag objectTag;

        [Header("Serializable")]
        [SerializeField] private SaveVector2 saveVector2;
        [SerializeField] private SaveVector3 saveVector3;
        [SerializeField] private SaveColor saveColor;
    }
}
