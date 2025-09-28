using BP.UniKit;
using UnityEditor;
using UnityEngine;

namespace BP.Utilkit.Editor
{
    [CustomPropertyDrawer(typeof(ObjectTag))]
    public class ObjectTagPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var tagProp = property.FindPropertyRelative("tag");
            tagProp.stringValue = EditorGUI.TagField(position, label, tagProp.stringValue);
            property.serializedObject.ApplyModifiedProperties();
        }
    }
}
