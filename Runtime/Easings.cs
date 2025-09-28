using UnityEngine;

namespace BP.UniKit
{
    /// <summary>
    /// Contains most commonly used easing functions.
    /// </summary>
    public static class Easings
    {
        public static float EaseInSine(float time) => 1 - Mathf.Cos(time * Mathf.PI / 2);
        public static float EaseOutSine(float time) => Mathf.Sin(time * Mathf.PI / 2);
        public static float EaseInOutSine(float time) => -(Mathf.Cos(Mathf.PI * time) - 1) / 2;

        public static float EaseInQuad(float time) => time * time;
        public static float EaseOutQuad(float time) => 1 - (1 - time) * (1 - time);
        public static float EaseInOutQuad(float time) => time < 0.5 ? 2 * time * time : 1 - Mathf.Pow(-2 * time + 2, 2) / 2;


        public static float EaseOutBack(float time)
        {
            float c1 = 1.70158f;
            float c3 = c1 + 1;
            return 1 + c3 * Mathf.Pow(time - 1, 3) + c1 * Mathf.Pow(time - 1, 2);
        }
        public static float EaseInOutBack(float time)
        {
            float c1 = 1.70158f;
            float c3 = c1 + 1;
            return c3 * time * time * time - c1 * time * time;
        }
    }
}