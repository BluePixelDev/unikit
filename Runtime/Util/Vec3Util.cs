using UnityEngine;

namespace BP.Utilkit
{
    public static class Vec3Util
    {
        #region OPERATIONS
        //==== OPERATIONS ====
        public static Vector3 SetX(this Vector3 v, float x)
        {
            v.x = x;
            return v;
        }
        public static Vector3 SetY(this Vector3 v, float y)
        {
            v.y = y;
            return v;
        }
        public static Vector3 SetZ(this Vector3 v, float z)
        {
            v.z = z;
            return v;
        }

        public static Vector3 Add(this Vector3 v, Vector2 vector)
        {
            v.x += vector.x;
            v.y += vector.y;
            return v;
        }

        public static Vector3 AddX(this Vector3 v, float add)
        {
            v.x += add;
            return v;
        }

        public static Vector3 AddY(this Vector3 v, float add)
        {
            v.y += add;
            return v;
        }
        public static Vector3 AddZ(this Vector3 v, float add)
        {
            v.z += add;
            return v;
        }

        public static Vector3 Sub(this Vector3 v, Vector2 vector)
        {
            v.x -= vector.x;
            v.y -= vector.y;
            return v;
        }

        public static Vector3 SubX(this Vector3 v, float subb)
        {
            v.x -= subb;
            return v;
        }

        public static Vector3 SubY(this Vector3 v, float subb)
        {
            v.y -= subb;
            return v;
        }
        public static Vector3 SubZ(this Vector3 v, float subb)
        {
            v.z -= subb;
            return v;
        }

        #endregion

        #region MATH METHODS
        /// <summary>
        /// Multiplies each axis by a value.
        /// </summary>
        public static Vector3 Mul(this Vector3 v, float value)
        {
            v.x *= value;
            v.y *= value;
            v.z *= value;
            return v;
        }
        /// <summary>
        /// Multiplies each axis with coresponding axis.
        /// </summary>
        public static Vector3 Mul(this Vector3 v, Vector3 vector)
        {
            v.x *= vector.x;
            v.y *= vector.y;
            v.z *= vector.z;
            return v;
        }
        /// <summary>
        /// Divides each axis with coresponding axis.
        /// </summary>
        public static Vector3 Div(this Vector3 v, Vector3 vector)
        {
            v.x /= vector.x;
            v.y /= vector.y;
            v.z /= vector.z;
            return v;
        }
        /// <summary>
        /// Divides each axis with coresponding axis.
        /// </summary>
        public static Vector3 Div(this Vector3 v, float value)
        {
            v.x /= value;
            v.y /= value;
            v.z /= value;
            return v;
        }
        /// <summary>
        /// Returns vector with absolute value of f.
        /// </summary>
        public static Vector3 Abs(this Vector3 v)
        {
            v.x = Mathf.Abs(v.x);
            v.y = Mathf.Abs(v.y);
            v.z = Mathf.Abs(v.z);
            return v;
        }
        /// <summary>
        /// Returns vector with sign value of f.
        /// </summary>
        public static Vector3 Sign(this Vector3 v)
        {
            v.x = Mathf.Sign(v.x);
            v.y = Mathf.Sign(v.y);
            v.z = Mathf.Sign(v.z);
            return v;
        }
        /// <summary>
        /// Returns vector with 1-value.
        /// </summary>
        public static Vector3 OneMinus(this Vector3 v)
        {
            v.x = 1 - v.x;
            v.y = 1 - v.y;
            v.z = 1 - v.z;
            return v;
        }
        /// <summary>
        /// Returns vector with rounded values.
        /// </summary>
        public static Vector3 Round(this Vector3 v)
        {
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            v.z = Mathf.Round(v.z);
            return v;
        }
        /// <summary>
        /// Returns vector with clamped values.
        /// </summary>
        public static Vector3 Clamp(this Vector3 v, float min, float max)
        {
            v.x = Mathf.Clamp(v.x, min, max);
            v.y = Mathf.Clamp(v.y, min, max);
            v.z = Mathf.Clamp(v.z, min, max);
            return v;
        }
        /// <summary>
        /// Returns vector with clamped values.
        /// </summary>
        public static Vector3 Clamp(this Vector3 v, Vector3 minVector, Vector3 maxVector)
        {
            v.x = Mathf.Clamp(v.x, minVector.x, maxVector.x);
            v.y = Mathf.Clamp(v.y, minVector.y, maxVector.y);
            v.z = Mathf.Clamp(v.z, minVector.z, maxVector.z);
            return v;
        }
        #endregion

        #region CONVERSION
        /// <summary>
        /// Converts Vector 3 to vector 2 by assigning same axis.
        /// </summary>
        public static Vector2 Vec2(this Vector3 v) => (Vector2)v;
        #endregion

        #region RANDOM
        /// <summary>
        /// Generates vector3 with random values in range from min to max.
        /// </summary>
        public static Vector3 RandomVector3(float min, float max)
        {
            return new()
            {
                x = Random.Range(min, max),
                y = Random.Range(min, max),
                z = Random.Range(min, max),
            };
        }
        /// <summary>
        /// Generates vector2 with random values in range from min to max.
        /// </summary>
        public static Vector3 RandomUnitVector3()
        {
            Vector3 random = new()
            {
                x = Random.Range(-1f, 1f),
                y = Random.Range(-1f, 1f),
                z = Random.Range(-1f, 1f),
            };
            return random.normalized;
        }
        #endregion
    }
}