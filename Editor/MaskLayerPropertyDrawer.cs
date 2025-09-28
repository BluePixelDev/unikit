using BP.UniKit;
using UnityEditor;
using UnityEngine;

namespace BP.Utilkit.Editor
{
    [CustomPropertyDrawer(typeof(MaskLayer))]
    public class MaskLayerPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            using var scope = new EditorGUI.PropertyScope(position, label, property);
            SerializedProperty layerProp = property.FindPropertyRelative("layerIndex");
            layerProp.intValue = EditorGUI.LayerField(position, label, layerProp.intValue);
        }
    }
}
