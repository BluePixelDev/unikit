using System;
using UnityEngine;

namespace BP.UniKit
{
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
}
