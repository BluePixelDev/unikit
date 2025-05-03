using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// A utility class for drawing gizmos in the editor.
    /// Provides methods to draw 3D shapes such as cylinders and circles.
    /// </summary>
    public static class GizmosUtil
    {
        // Number of vertices used to approximate a circle
        const int GizmoCircleVertCount = 12;

        /// <summary>
        /// Draws a cylinder at the specified center position with the given radius and height.
        /// </summary>
        /// <param name="center">The center position of the cylinder.</param>
        /// <param name="radius">The radius of the cylinder.</param>
        /// <param name="height">The height of the cylinder.</param>
        public static void DrawCylinder(Vector3 center, float radius, float height)
        {
            Vector3 upCenter = center + Vector3.up * height;
            Vector3 downCenter = center - Vector3.up * height;

            for (int i = 0; i < GizmoCircleVertCount; i++)
            {
                float angleStep = Mathf.PI * 2 / (GizmoCircleVertCount / 3);
                float angle = angleStep * i;
                float xPos = Mathf.Cos(angle) * radius;
                float yPos = Mathf.Sin(angle) * radius;

                Vector3 currentPosition = center + new Vector3(xPos, 0, yPos);
                Vector3 startPos = currentPosition - (Vector3.up * height);
                Vector3 endPos = currentPosition + (Vector3.up * height);
                Gizmos.DrawLine(startPos, endPos);
            }

            DrawCircle(upCenter, radius);
            DrawCircle(downCenter, radius);
        }

        /// <summary>
        /// Draws a circle at the specified center position with the given radius.
        /// </summary>
        /// <param name="center">The center position of the circle.</param>
        /// <param name="radius">The radius of the circle.</param>
        public static void DrawCircle(Vector3 center, float radius)
        {
            float angleStep = Mathf.PI * 2 / GizmoCircleVertCount;
            Vector3 prevPosition = Vector3.zero;
            for (int i = 0; i < GizmoCircleVertCount + 1; i++)
            {
                float angle = angleStep * i;
                float xPos = Mathf.Cos(angle) * radius;
                float yPos = Mathf.Sin(angle) * radius;
                Vector3 currentPosition = center + new Vector3(xPos, 0, yPos);

                if (i == 0)
                {
                    prevPosition = currentPosition;
                    continue;
                }

                Gizmos.DrawLine(prevPosition, currentPosition);
                prevPosition = currentPosition;
            }
        }
    }
}