using System;
using UnityEngine;

namespace BP.Utilkit
{
    [Serializable]
    public struct SaveVector3
    {
        public float x, y, z;

        public SaveVector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override readonly string ToString() => $"Vector3({x}, {y}, {z})";

        // From SerializableVector3 to Vector3
        public static implicit operator Vector3(SaveVector3 vec3)
            => new(vec3.x, vec3.y, vec3.z);

        // From Vector3 to SerializableVector3
        public static implicit operator SaveVector3(Vector3 vec3)
            => new(vec3.x, vec3.y, vec3.z);
    }

    [Serializable]
    public struct SaveVector2
    {
        public float x, y;

        public SaveVector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override readonly string ToString() => $"Vector2({x}, {y})";

        // From SerializableVector2 to Vector2
        public static implicit operator Vector2(SaveVector2 vec2)
            => new(vec2.x, vec2.y);

        // From Vector2 to SerializableVector2
        public static implicit operator SaveVector2(Vector2 vec2)
            => new(vec2.x, vec2.y);
    }
}
