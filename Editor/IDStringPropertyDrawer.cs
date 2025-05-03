using BP.Utilkit;
using UnityEditor;
using UnityEngine;

namespace BP.UtilkitEditor
{
    [CustomPropertyDrawer(typeof(IDString))]
    public class IdStringDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.PropertyField(position, property.FindPropertyRelative("id"), label);
            EditorGUI.EndProperty();
        }
    }
}
