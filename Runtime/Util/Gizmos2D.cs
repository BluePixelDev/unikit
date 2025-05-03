using System.Collections.Generic;
using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// A utility class providing methods to draw 2D shapes using Gizmos in the Unity Editor.
    /// Includes support for wire circles, filled circles, squares, and cones.
    /// </summary>
    public static class Gizmos2D
    {
        const int CircleVerts = 64;

        /// <summary>
        /// Draws a wireframe circle on the XY plane using Gizmos.
        /// </summary>
        /// <param name="position">Center of the circle.</param>
        /// <param name="radius">Radius of the circle.</param>
        public static void DrawWireCircle(Vector3 position, float radius)
        {
            var prevMatrix = Gizmos.matrix;
            Gizmos.matrix *= Matrix4x4.TRS(position, Quaternion.identity, new Vector3(1, 1, 0));
            Gizmos.DrawWireSphere(Vector3.zero, radius);
            Gizmos.matrix = prevMatrix;
        }

        /// <summary>
        /// Draws a circle on the XY plane using line segments.
        /// </summary>
        /// <param name="position">Center of the circle.</param>
        /// <param name="radius">Radius of the circle.</param>
        public static void DrawCircle(Vector3 position, float radius)
        {
            var points = new List<Vector3>();
            for (int i = 0; i <= CircleVerts; i++)
            {
                var step = 2 * Mathf.PI / CircleVerts;
                var angle = step * i;

                var dir = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
                var finalPos = position + dir.Vec3(0) * radius;
                points.Add(finalPos);
            }

            Gizmos.DrawLineStrip(points.ToArray(), true);
        }

        /// <summary>
        /// Draws a square centered at the given position.
        /// </summary>
        /// <param name="position">Center of the square.</param>
        /// <param name="size">Size of the square (width and height).</param>
        public static void DrawSquare(Vector3 position, Vector2 size)
        {
            var halfSize = size / 2;
            var topLeft = position.SubX(halfSize.x).AddY(halfSize.y);
            var topRight = position.Add(halfSize);
            var bottomLeft = position.Sub(halfSize);
            var bottomRight = position.AddX(halfSize.x).SubY(halfSize.y);

            var points = new Vector3[] { topLeft, topRight, bottomRight, bottomLeft };
            Gizmos.DrawLineStrip(points, true);
        }

        /// <summary>
        /// Draws a cone shape from a given position, with a specified radius and angle.
        /// </summary>
        /// <param name="position">The origin point of the cone.</param>
        /// <param name="radius">The radius or reach of the cone.</param>
        /// <param name="angle">The angle in degrees of the cone's spread.</param>
        public static void DrawCone(Vector3 position, float radius, float angle)
        {
            var normalizedAngle = Mathf.Clamp(angle, 0, 360);
            var halfAngle = normalizedAngle / 2;
            var points = new List<Vector3>();
            var vertCount = Mathf.RoundToInt(CircleVerts * (normalizedAngle / 360));
            for (int i = -vertCount; i <= vertCount; i++)
            {
                var step = halfAngle * Mathf.Deg2Rad / vertCount;
                var angleStep = step * i;
                var dir = new Vector2(Mathf.Cos(angleStep), Mathf.Sin(angleStep));
                var finalPos = position + dir.Vec3() * radius;
                points.Add(finalPos);

                // Draw outside lines
                if (i == -vertCount || i == vertCount)
                    Gizmos.DrawLine(position, finalPos);
            }
            Gizmos.DrawLineStrip(points.ToArray(), false);
        }
    }
}
