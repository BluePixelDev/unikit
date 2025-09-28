using System.Collections.Generic;
using UnityEngine;

namespace BP.UniKit
{
    public static class UniGizmos
    {
        const int GizmoCircleVertCount = 16;

        public static void TRS(Transform transform) => Gizmos.matrix = transform.localToWorldMatrix;
        public static void TRS(Vector3 pos, Quaternion q, Vector3 s) => Gizmos.matrix = Matrix4x4.TRS(pos, q, s);
        public static void ResetMatrix() => Gizmos.matrix = Matrix4x4.identity;

        /// <summary>
        /// Draws a cylinder at the specified center position with the given radius and height.
        /// </summary>
        /// <param name="center">The center position of the cylinder.</param>
        /// <param name="radius">The radius of the cylinder.</param>
        /// <param name="height">The height of the cylinder.</param>
        public static void DrawCylinder(Vector3 center, float radius, float height)
        {
            float halfRadius = radius / 2;
            float halfHeight = height / 2;
            Vector3 upCenter = center + Vector3.up * halfHeight;
            Vector3 downCenter = center - Vector3.up * halfHeight;

            for (int i = 0; i < GizmoCircleVertCount; i++)
            {
                float angleStep = Mathf.PI * 2 / (GizmoCircleVertCount / 3);
                float angle = angleStep * i;
                float xPos = Mathf.Cos(angle) * halfRadius;
                float yPos = Mathf.Sin(angle) * halfRadius;

                Vector3 currentPosition = center + new Vector3(xPos, 0, yPos);
                Vector3 startPos = currentPosition - (Vector3.up * halfHeight);
                Vector3 endPos = currentPosition + (Vector3.up * halfHeight);
                Gizmos.DrawLine(startPos, endPos);
            }

            var prevMatrix = Gizmos.matrix;
            Gizmos.matrix *= Matrix4x4.TRS(upCenter, Quaternion.Euler(90, 0, 0), Vector3.one);
            DrawCircle(Vector3.zero, radius);
            Gizmos.matrix = prevMatrix;

            Gizmos.matrix *= Matrix4x4.TRS(downCenter, Quaternion.Euler(90, 0, 0), Vector3.one);
            DrawCircle(Vector3.zero, radius);
            Gizmos.matrix = prevMatrix;
        }

        /// <summary>
        /// Draws a circle at the specified center position with the given radius.
        /// </summary>
        /// <param name="center">The center position of the circle.</param>
        /// <param name="radius">The radius of the circle.</param>
        public static void DrawCircle(Vector3 center, float radius)
        {
            float halfRadius = radius / 2;
            float angleStep = Mathf.PI * 2 / GizmoCircleVertCount;
            Vector3 prevPosition = Vector3.zero;
            for (int i = 0; i < GizmoCircleVertCount + 1; i++)
            {
                float angle = angleStep * i;
                float xPos = Mathf.Cos(angle) * halfRadius;
                float yPos = Mathf.Sin(angle) * halfRadius;
                Vector3 currentPosition = center + new Vector3(xPos, yPos, 0);

                if (i == 0)
                {
                    prevPosition = currentPosition;
                    continue;
                }

                Gizmos.DrawLine(prevPosition, currentPosition);
                prevPosition = currentPosition;
            }
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
        public static void DrawCone2D(Vector3 position, float radius, float angle)
        {
            float halfRadius = radius / 2;
            angle = Mathf.Clamp(angle, 0, 360);
            int segments = Mathf.RoundToInt(GizmoCircleVertCount * (angle / 360f));
            if (segments < 2) segments = 2;

            float halfAngleRad = angle * 0.5f * Mathf.Deg2Rad;
            List<Vector3> arcPoints = new();

            for (int i = 0; i <= segments; i++)
            {
                float t = i / (float)segments;
                float currentAngle = -halfAngleRad + t * angle * Mathf.Deg2Rad;
                float x = Mathf.Cos(currentAngle) * halfRadius;
                float y = Mathf.Sin(currentAngle) * halfRadius;
                arcPoints.Add(position + new Vector3(x, y, 0));
            }

            Gizmos.DrawLine(position, arcPoints[0]);
            Gizmos.DrawLine(position, arcPoints[^1]);
            Gizmos.DrawLineStrip(arcPoints.ToArray(), false);
        }
    }
}