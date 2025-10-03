using UnityEngine;

namespace BP.UniKit
{
    public static class Vecctor3Extensions
    {
        //==== OPERATIONS ====
        public static Vector3 With(this Vector3 v, float? x = null, float? y = null, float? z = null) => new(x ?? v.x, y ?? v.y, z ?? v.z);
        public static Vector3 WithX(this Vector3 v, float x) => v.With(x: x);
        public static Vector3 WithY(this Vector3 v, float y) => v.With(y: y);
        public static Vector3 WithZ(this Vector3 v, float z) => v.With(z: z);

        //==== ARITHMETIC ====
        public static Vector3 Add(this Vector3 v, float x = 0, float y = 0, float z = 0) => new(v.x + x, v.y + y, v.z + z);
        public static Vector3 Add(this Vector3 v, Vector2 add) => new(v.x + add.x, v.y + add.y, v.z);
        public static Vector3 AddX(this Vector3 v, float add) => v.Add(x: add);
        public static Vector3 AddY(this Vector3 v, float add) => v.Add(y: add);
        public static Vector3 AddZ(this Vector3 v, float add) => v.Add(z: add);

        public static Vector3 Sub(this Vector3 v, float x = 0, float y = 0, float z = 0) => new(v.x - x, v.y - y, v.z - z);
        public static Vector3 Sub(this Vector3 v, Vector2 add) => new(v.x - add.x, v.y - add.y, v.z);
        public static Vector3 SubX(this Vector3 v, float subb) => v.Sub(x: subb);
        public static Vector3 SubY(this Vector3 v, float subb) => v.Sub(y: subb);
        public static Vector3 SubZ(this Vector3 v, float subb) => v.Sub(z: subb);

        public static Vector3 Multiply(this Vector3 v, float factor) => v * factor;
        public static Vector3 Multiply(this Vector3 v, Vector3 vector) => new(v.x * vector.x, v.y * vector.y, v.y * vector.y);

        public static Vector3 Divide(this Vector3 v, Vector3 vector) => new(v.x / vector.x, v.y / vector.y, v.y / vector.y);
        public static Vector3 Divide(this Vector3 v, float value) => v / value;

        //==== UTILITIES ====
        public static Vector3 Abs(this Vector3 v) => new(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
        public static Vector3 Sign(this Vector3 v) => new(Mathf.Sign(v.x), Mathf.Sign(v.y), Mathf.Sign(v.z));
        public static Vector3 OneMinus(this Vector3 v) => new(1 - v.x, 1 - v.y, 1 - v.z);
        public static Vector3 Round(this Vector3 v) => new(Mathf.Round(v.x), Mathf.Round(v.y), Mathf.Round(v.z));
        public static Vector3 Clamp(this Vector3 v, float min, float max) => new(Mathf.Clamp(v.x, min, max), Mathf.Clamp(v.y, min, max), Mathf.Clamp(v.z, min, max));

        public static Vector3 ClampAxis(this Vector3 v, Vector3 minVector, Vector3 maxVector) => new(
                Mathf.Clamp(v.x, minVector.x, maxVector.x),
                Mathf.Clamp(v.y, minVector.y, maxVector.y),
                Mathf.Clamp(v.z, minVector.y, maxVector.y)
        );
    }
}