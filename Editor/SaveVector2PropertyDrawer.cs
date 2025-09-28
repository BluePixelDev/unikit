using UnityEditor;
using UnityEngine;

namespace BP.UniKit.Editor
{
    [CustomPropertyDrawer(typeof(SaveVector2))]
    public class SaveVector2PropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var xProp = property.FindPropertyRelative("x");
            var yProp = property.FindPropertyRelative("y");

            var currentValue = new Vector2(
                xProp.floatValue,
                yProp.floatValue
            );

            var updateValue = EditorGUI.Vector2Field(position, label, currentValue);

            xProp.floatValue = updateValue.x;
            yProp.floatValue = updateValue.y;

            EditorGUI.EndProperty();
        }
    }
}
