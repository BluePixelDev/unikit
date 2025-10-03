using UnityEngine;

namespace BP.UniKit
{
    public static class ColorExtensions
    {
        public static Color With(
           this Color color,
           float? r = null,
           float? g = null,
           float? b = null,
           float? a = null)
        {
            return new Color(
                Mathf.Clamp01(r ?? color.r),
                Mathf.Clamp01(g ?? color.g),
                Mathf.Clamp01(b ?? color.b),
                Mathf.Clamp01(a ?? color.a)
            );
        }
        public static Color WithRGB(this Color color, float? r = null, float? g = null, float? b = null)
                    => color.With(r: r, g: g, b: b);

        public static Color WithR(this Color color, float r) => color.With(r: r);
        public static Color WithG(this Color color, float g) => color.With(g: g);
        public static Color WithB(this Color color, float b) => color.With(b: b);
        public static Color WithA(this Color color, float a) => color.With(a: a);

        public static Color LerpTo(this Color from, Color to, float t)
        {
            t = Mathf.Clamp01(t);
            return new Color(
                Mathf.Lerp(from.r, to.r, t),
                Mathf.Lerp(from.g, to.g, t),
                Mathf.Lerp(from.b, to.b, t),
                Mathf.Lerp(from.a, to.a, t)
            );
        }

        public static Color ToGrayscale(this Color color)
        {
            float gray = color.grayscale;
            return new Color(gray, gray, gray, color.a);
        }

        public static Color Inverted(this Color color)
            => new(1f - color.r, 1f - color.g, 1f - color.b, color.a);

        public static Color MultiplyRGB(this Color color, float factor)
        {
            factor = Mathf.Clamp01(factor);
            return new Color(color.r * factor, color.g * factor, color.b * factor, color.a);
        }
        public static Color MultiplyRGBA(this Color color, float factor)
        {
            factor = Mathf.Clamp01(factor);
            return new Color(color.r * factor, color.g * factor, color.b * factor, color.a * color.a);
        }
    }
}