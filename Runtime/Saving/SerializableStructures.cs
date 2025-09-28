using System;
using UnityEngine;

namespace BP.UniKit
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


        public static implicit operator Vector3(SaveVector3 vec3)
            => new(vec3.x, vec3.y, vec3.z);

        public static implicit operator SaveVector3(Vector3 vec3)
            => new(vec3.x, vec3.y, vec3.z);
        public override readonly string ToString() => $"Vector3({x}, {y}, {z})";
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

        public static implicit operator Vector2(SaveVector2 vec2)
            => new(vec2.x, vec2.y);

        public static implicit operator SaveVector2(Vector2 vec2)
            => new(vec2.x, vec2.y);
        public override readonly string ToString() => $"Vector2({x}, {y})";
    }

    [Serializable]
    public struct SaveColor
    {
        public int r, g, b, a;

        public SaveColor(byte r, byte g, byte b, byte a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public static implicit operator Color(SaveColor color) => new(
            color.r / 255f,
            color.g / 255f,
            color.b / 255f,
            color.a / 255f
        );

        public static implicit operator Color32(SaveColor color) => new(
           (byte)color.r,
           (byte)color.g,
           (byte)color.b,
           (byte)color.a
        );

        public override readonly string ToString() => $"Color({r},{g},{b},{a})";
    }
}
