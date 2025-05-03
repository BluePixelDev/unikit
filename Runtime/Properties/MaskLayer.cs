using UnityEditor;
using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// This struct allows for single layer mask selection in a inspector.
    /// </summary>
    [System.Serializable]
    public struct MaskLayer
    {
        [SerializeField] private int _layerIndex;
        public readonly int layerIndex { get => _layerIndex; }
        public readonly int LayerMask { get { return 1 << _layerIndex; } }

        public void SetLayer(int layer)
        {
            if (layer > 0 && layer < 32)
            {
                _layerIndex = layer;
            }
        }
        /// <summary>
        /// Createsa a new SingleLayer struct using target layer index.
        /// If index is out of range, the target layer is set to zero.
        /// </summary>
        public MaskLayer(int layer)
        {
            _layerIndex = 0;
            if (layer > 0 && layer < 32)
            {
                _layerIndex = layer;
            }
        }
    }

#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(MaskLayer))]
    internal class SingleLayerDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            using var scope = new EditorGUI.PropertyScope(position, label, property);
            SerializedProperty layerProp = property.FindPropertyRelative("_layerIndex");
            layerProp.intValue = EditorGUI.LayerField(position, label, layerProp.intValue);
        }
    }
#endif
}