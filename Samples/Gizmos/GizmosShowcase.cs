using UnityEngine;

namespace BP.UniKit
{
    internal class GizmosShowcase : MonoBehaviour
    {
        private enum ShowcaseMode
        {
            Circle,
            Square,
            Cylinder,
            Cone
        }

        [SerializeField] private ShowcaseMode showcaseMode;
        [SerializeField] private float radius;
        [SerializeField] private float angle;

        private void OnDrawGizmos()
        {
            UniGizmos.TRS(transform);
            switch (showcaseMode)
            {
                case ShowcaseMode.Circle:
                    Gizmos.color = Color.red;
                    UniGizmos.DrawCircle(Vector3.zero, radius);
                    break;
                case ShowcaseMode.Square:
                    Gizmos.color = Color.green;
                    UniGizmos.DrawSquare(Vector3.zero, Vector2.one * radius);
                    break;
                case ShowcaseMode.Cylinder:
                    Gizmos.color = Color.blue;
                    UniGizmos.DrawCylinder(Vector3.zero, radius, radius);
                    break;
                case ShowcaseMode.Cone:
                    Gizmos.color = Color.cyan;
                    UniGizmos.DrawCone2D(Vector3.zero, radius, angle);
                    break;
            }
        }
    }
}
