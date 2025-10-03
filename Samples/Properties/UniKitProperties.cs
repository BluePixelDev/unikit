using UnityEngine;

namespace BP.UniKit
{
    internal class UniKitProperties : MonoBehaviour
    {
        [SerializeField] private MaskLayer maskLayer;
        [SerializeField] private ObjectTag objectTag;

        [Header("Serializable")]
        [SerializeField] private SaveVector2 saveVector2;
        [SerializeField] private SaveVector3 saveVector3;
        [SerializeField] private SaveColor saveColor;

#pragma warning disable
        [Header("Attributes")]
        [HideLabel, SerializeField] private string noLabel = "I have no label!";
        [ReadOnly, SerializeField] private string readOnly = "You can only read";

        [Header("Combined")]
        [ReadOnly, HideLabel, SerializeField] private string combined = "You can only read";
#pragma warning restore
    }
}
