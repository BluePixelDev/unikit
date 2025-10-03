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
}
