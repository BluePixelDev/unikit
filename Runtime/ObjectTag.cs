using UnityEngine;

namespace BP.UniKit
{
    [System.Serializable]
    public struct ObjectTag
    {
        [SerializeField] private string tag;

        public readonly string Tag => tag;
        public static implicit operator string(ObjectTag obj) => obj.tag;
        public override readonly string ToString() => tag;
    }
}