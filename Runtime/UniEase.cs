using UnityEngine;

namespace BP.UniKit
{
    public enum Easing
    {
        EaseInSine,
        EaseOutSine,
        EaseInOutSine,

        EaseInQuad,
        EaseOutQuad,
        EaseInOutQuad,

        EaseOutBack,
        EaseInOutBack,
    }

    public static class UniEase
    {

        public static float GetEase(float time, Easing easing)
        {
            time = Mathf.Clamp01(time);
            return easing switch
            {
                Easing.EaseInSine => 1 - Mathf.Cos(time * Mathf.PI / 2),
                Easing.EaseOutSine => Mathf.Sin(time * Mathf.PI / 2),
                Easing.EaseInOutSine => Mathf.Sin(time * Mathf.PI / 2),

                Easing.EaseInQuad => time * time,
                Easing.EaseOutQuad => 1 - (1 - time) * (1 - time),
                Easing.EaseInOutQuad => time < 0.5 ? 2 * time * time : 1 - Mathf.Pow(-2 * time + 2, 2) / 2,

                Easing.EaseOutBack => EaseOutBack(time),
                Easing.EaseInOutBack => EaseInOutBack(time),

                _ => 0
            };
        }

        private static float EaseOutBack(float time)
        {
            float c1 = 1.70158f;
            float c3 = c1 + 1;
            return 1 + c3 * Mathf.Pow(time - 1, 3) + c1 * Mathf.Pow(time - 1, 2);
        }
        private static float EaseInOutBack(float time)
        {
            float c1 = 1.70158f;
            float c3 = c1 + 1;
            return c3 * time * time * time - c1 * time * time;
        }
    }
}