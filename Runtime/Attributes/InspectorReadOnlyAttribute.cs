using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace BP.Utilkit
{
    public sealed class InspectorReadOnlyAttribute : PropertyAttribute { }

#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(InspectorReadOnlyAttribute))]
    public class InspectorReadOnlyAttributeDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var root = new VisualElement();
            root.SetEnabled(false);
            root.Add(base.CreatePropertyGUI(property));
            return root;
        }
    }
#endif
}
