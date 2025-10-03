using UnityEngine;

namespace BP.UniKit
{
    public static class Vector2Extensions
    {
        //==== MUTATORS ====
        public static Vector2 With(this Vector2 v, float? x = null, float? y = null) => new(x ?? v.x, y ?? v.y);
        public static Vector2 WithX(this Vector2 v, float x) => v.With(x: x);
        public static Vector2 WithY(this Vector2 v, float y) => v.With(y: y);

        //==== ARITHMETIC ====
        public static Vector2 Add(this Vector2 v, float x = 0f, float y = 0f) => new(v.x + x, v.y + y);
        public static Vector2 AddX(this Vector2 v, float dx) => new(v.x + dx, v.y);
        public static Vector2 AddY(this Vector2 v, float dy) => new(v.x, v.y + dy);

        public static Vector2 Sub(this Vector2 v, float x = 0f, float y = 0f) => new(v.x - x, v.y - y);
        public static Vector2 SubX(this Vector2 v, float sub) => v.Sub(x: sub);
        public static Vector2 SubY(this Vector2 v, float sub) => v.Sub(y: sub);

        public static Vector2 Multiply(this Vector2 v, Vector2 multiplier) => new(v.x * multiplier.x, v.y * multiplier.y);
        public static Vector2 Multiply(this Vector2 v, float factor) => v * factor;
        public static Vector2 Divide(this Vector2 v, Vector2 divisor) => v / divisor;
        public static Vector2 Divide(this Vector2 v, float divisor) => v / divisor;

        //==== UTILITIES ====
        public static Vector2 Abs(this Vector2 v) => new(Mathf.Abs(v.x), Mathf.Abs(v.y));
        public static Vector2 Sign(this Vector2 v) => new(Mathf.Sign(v.x), Mathf.Sign(v.y));
        public static Vector2 OneMinus(this Vector2 v) => new(1f - v.x, 1f - v.y);
        public static Vector2 Round(this Vector2 v) => new(Mathf.Round(v.x), Mathf.Round(v.y));
        public static Vector2 Clamp(this Vector2 v, float min, float max) => new(Mathf.Clamp(v.x, min, max), Mathf.Clamp(v.y, min, max));
        public static Vector2 Clamp(this Vector2 v, Vector2 min, Vector2 max)
            => new(
                Mathf.Clamp(v.x, min.x, max.x),
                Mathf.Clamp(v.y, min.y, max.y)
            );
    }
}