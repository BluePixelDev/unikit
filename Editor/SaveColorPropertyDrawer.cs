using UnityEditor;
using UnityEngine;

namespace BP.UniKit.Editor
{
    [CustomPropertyDrawer(typeof(SaveColor))]

    public class SaveColorPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var rProp = property.FindPropertyRelative("r");
            var gProp = property.FindPropertyRelative("g");
            var bProp = property.FindPropertyRelative("b");
            var aProp = property.FindPropertyRelative("a");

            var currentValue = new Color32(
                (byte)rProp.intValue,
                (byte)gProp.intValue,
                (byte)bProp.intValue,
                (byte)aProp.intValue
            );


            Color32 updateValue = EditorGUI.ColorField(position, label, currentValue);
            rProp.intValue = updateValue.r;
            gProp.intValue = updateValue.g;
            bProp.intValue = updateValue.b;
            aProp.intValue = updateValue.a;
            EditorGUI.EndProperty();
        }
    }
}
