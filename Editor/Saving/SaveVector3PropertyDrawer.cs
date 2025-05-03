using BP.Utilkit;
using UnityEditor;
using UnityEngine;

namespace BP.UtilkitEditor
{
    [CustomPropertyDrawer(typeof(SaveVector3))]
    public class SaveVector3PropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var xProp = property.FindPropertyRelative("x");
            var yProp = property.FindPropertyRelative("y");
            var zProp = property.FindPropertyRelative("z");

            var currentValue = new Vector3(
                xProp.floatValue,
                yProp.floatValue,
                zProp.floatValue
            );

            var updateValue = EditorGUI.Vector3Field(position, label, currentValue);

            xProp.floatValue = updateValue.x;
            yProp.floatValue = updateValue.y;
            zProp.floatValue = updateValue.z;

            EditorGUI.EndProperty();
        }
    }
}
