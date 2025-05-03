using UnityEngine;

namespace BP.Utilkit
{
    public static class Vec2Util
    {
        #region OPERATIONS
        //==== OPERATIONS ====
        public static Vector2 SetX(this ref Vector2 v, float x)
        {
            v.x = x;
            return v;
        }
        public static Vector2 SetY(this Vector2 v, float y)
        {
            v.y = y;
            return v;
        }

        public static Vector2 AddX(this Vector2 v, float add)
        {
            v.x += add;
            return v;
        }
        public static Vector2 AddY(this Vector2 v, float add)
        {
            v.y += add;
            return v;
        }
        public static Vector2 SubX(this Vector2 v, float sub)
        {
            v.x -= sub;
            return v;
        }
        public static Vector2 SubY(this Vector2 v, float sub)
        {
            v.y -= sub;
            return v;
        }
        #endregion

        #region MATH METHODS
        //==== MATH METHODS ====
        public static Vector3 Vec3(this Vector2 v, float z = 0) => new(v.x, v.y, z);
        /// <summary>
        /// Multiplies each axis with coresponding axis.
        /// </summary>
        public static Vector2 Multiply(this Vector2 v, Vector2 vector)
        {
            v.x *= vector.x;
            v.y *= vector.y;
            return v;
        }
        /// <summary>
        /// Divides each axis with coresponding axis.
        /// </summary>
        public static Vector3 Divide(this Vector2 v, Vector2 vector)
        {
            v.x /= vector.x;
            v.y /= vector.y;
            return v;
        }
        /// <summary>
        /// Returns vector with absolute value of f.
        /// </summary>
        public static Vector2 Abs(this Vector2 v)
        {
            v.x = Mathf.Abs(v.x);
            v.y = Mathf.Abs(v.y);
            return v;
        }
        /// <summary>
        /// Returns vector with sign value of f.
        /// </summary>
        public static Vector2 Sign(this Vector2 v)
        {
            v.x = Mathf.Sign(v.x);
            v.y = Mathf.Sign(v.y);
            return v;
        }
        /// <summary>
        /// Returns vector with 1-value.
        /// </summary>
        public static Vector2 OneMinus(this Vector2 v)
        {
            v.x = 1 - v.x;
            v.y = 1 - v.y;
            return v;
        }
        /// <summary>
        /// Returns vector with rounded values.
        /// </summary>
        public static Vector2 Round(this Vector2 v)
        {
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            return v;
        }
        /// <summary>
        /// Returns vector with clamped values.
        /// </summary>
        public static Vector2 Clamp(this Vector2 v, float min, float max)
        {
            v.x = Mathf.Clamp(v.x, min, max);
            v.y = Mathf.Clamp(v.y, min, max);
            return v;
        }
        /// <summary>
        /// Returns vector with clamped values.
        /// </summary>
        public static Vector2 Clamp(this Vector2 v, Vector2 minVector, Vector2 maxVector)
        {
            v.x = Mathf.Clamp(v.x, minVector.x, maxVector.x);
            v.y = Mathf.Clamp(v.y, minVector.y, maxVector.y);
            return v;
        }
        #endregion

        #region RANDOM
        //==== RANDOM ====
        /// <summary>
        /// Generates vector2 with random values in range from min to max.
        /// </summary>
        public static Vector2 RandomVector2(float min, float max)
        {
            return new()
            {
                x = Random.Range(min, max),
                y = Random.Range(min, max),
            };
        }
        #endregion
    }
}