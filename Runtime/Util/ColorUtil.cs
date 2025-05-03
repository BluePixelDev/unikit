using UnityEngine;

/// <summary>
/// Provides extension methods for more flexible and readable manipulation of Unity's Color struct.
/// </summary>
public static class ColorUtil
{
    /// <summary>
    /// Returns a new color with optional modifications to any of the RGBA channels.
    /// </summary>
    public static Color RGBA(this Color color, float? red = null, float? green = null, float? blue = null, float? alpha = null)
    {
        var newR = Mathf.Clamp01(red ?? color.r);
        var newG = Mathf.Clamp01(green ?? color.g);
        var newB = Mathf.Clamp01(blue ?? color.b);
        var newA = Mathf.Clamp01(alpha ?? color.a);
        return new Color(newR, newG, newB, newA);
    }

    /// <summary>Returns a new color with the red channel set to <paramref name="r"/>.</summary>
    public static Color Red(this Color color, float r) => RGBA(color, red: r);

    /// <summary>Returns a new color with the green channel set to <paramref name="g"/>.</summary>
    public static Color Green(this Color color, float g) => RGBA(color, green: g);

    /// <summary>Returns a new color with the blue channel set to <paramref name="b"/>.</summary>
    public static Color Blue(this Color color, float b) => RGBA(color, blue: b);

    /// <summary>Returns a new color with the alpha channel set to <paramref name="a"/>.</summary>
    public static Color Alpha(this Color color, float a) => RGBA(color, alpha: a);

    /// <summary>Returns a new color with the RGB channels optionally modified.</summary>
    public static Color RGB(this Color color, float? r = null, float? g = null, float? b = null) => RGBA(color, red: r, green: g, blue: b);

    /// <summary>Linearly interpolates between two colors.</summary>
    public static Color Lerp(this Color color1, Color color2, float t)
    {
        var newR = Mathf.Lerp(color1.r, color2.r, t);
        var newG = Mathf.Lerp(color1.g, color2.g, t);
        var newB = Mathf.Lerp(color1.b, color2.b, t);
        var newA = Mathf.Lerp(color1.a, color2.a, t);
        return new Color(newR, newG, newB, newA);
    }

    /// <summary>Converts the color to grayscale using Unity's built-in <c>Color.grayscale</c>.</summary>
    public static Color ToGrayscale(this Color color) => new(color.grayscale, color.grayscale, color.grayscale, color.a);

    /// <summary>Inverts the RGB channels of the color.</summary>
    public static Color Invert(this Color color) => new(1 - color.r, 1 - color.g, 1 - color.b, color.a);

    /// <summary>Multiplies the RGB channels by a given multiplier (clamped between 0 and 1).</summary>
    public static Color Multiply(this Color color, float multiplier)
    {
        multiplier = Mathf.Clamp01(multiplier);
        return new(color.r * multiplier, color.g * multiplier, color.b * multiplier, color.a);
    }
}

