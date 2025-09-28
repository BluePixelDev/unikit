using UnityEngine;

public static class ColorUtil
{
    public static Color RGBA(this Color color, float? red = null, float? green = null, float? blue = null, float? alpha = null)
    {
        var newR = Mathf.Clamp01(red ?? color.r);
        var newG = Mathf.Clamp01(green ?? color.g);
        var newB = Mathf.Clamp01(blue ?? color.b);
        var newA = Mathf.Clamp01(alpha ?? color.a);
        return new Color(newR, newG, newB, newA);
    }

    public static Color SetR(this Color color, float r) => RGBA(color, red: r);
    public static Color SetG(this Color color, float g) => RGBA(color, green: g);
    public static Color SetB(this Color color, float b) => RGBA(color, blue: b);
    public static Color SetA(this Color color, float a) => RGBA(color, alpha: a);
    public static Color RGB(this Color color, float? r = null, float? g = null, float? b = null) => RGBA(color, red: r, green: g, blue: b);

    public static Color Lerp(this Color color1, Color color2, float t)
    {
        var newR = Mathf.Lerp(color1.r, color2.r, t);
        var newG = Mathf.Lerp(color1.g, color2.g, t);
        var newB = Mathf.Lerp(color1.b, color2.b, t);
        var newA = Mathf.Lerp(color1.a, color2.a, t);
        return new Color(newR, newG, newB, newA);
    }

    public static Color ToGrayscale(this Color color) => new(color.grayscale, color.grayscale, color.grayscale, color.a);
    public static Color Invert(this Color color) => new(1 - color.r, 1 - color.g, 1 - color.b, color.a);
    public static Color Multiply(this Color color, float multiplier)
    {
        multiplier = Mathf.Clamp01(multiplier);
        return new(color.r * multiplier, color.g * multiplier, color.b * multiplier, color.a);
    }
}

