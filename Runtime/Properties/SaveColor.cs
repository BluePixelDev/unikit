using System;
using UnityEngine;

namespace BP.UniKit
{
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
