using UnityEditor;
using UnityEngine;

namespace BP.Utilkit
{
    [System.Serializable]
    public struct ObjectTag
    {
        public string tag;
        public static implicit operator string(ObjectTag obj) => obj.tag;
        public override readonly string ToString() => tag;
    }

#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(ObjectTag))]
    internal class ObjectTagPropertyDrawer : PropertyDrawer
    {
        private SerializedProperty tagProp;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            tagProp ??= property.FindPropertyRelative("tag");
            tagProp.stringValue = EditorGUI.TagField(position, label, tagProp.stringValue);
            property.serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}