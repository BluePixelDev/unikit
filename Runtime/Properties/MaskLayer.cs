using UnityEngine;

namespace BP.UniKit
{
    [System.Serializable]
    public struct MaskLayer
    {
        [SerializeField] private int layerIndex;
        public readonly int LayerIndex { get => layerIndex; }
        public readonly int LayerMask { get => 1 << layerIndex; }

        public void SetLayer(int layer)
        {
            if (layer > 0 && layer < 32)
            {
                layerIndex = layer;
            }
        }

        public MaskLayer(int layer)
        {
            layerIndex = 0;
            if (layer > 0 && layer < 32)
            {
                layerIndex = layer;
            }
        }
    }
}