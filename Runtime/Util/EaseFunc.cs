using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// A class containing commonly used easing functions for smooth interpolation and animations.
    /// </summary>
    public static class EaseFunc
    {
        /* ==== SINE ==== */

        /// <summary>
        /// Accelerates slowly then speeds up (ease-in).
        /// </summary>
        public static float EaseInSine(float time) => 1 - Mathf.Cos(time * Mathf.PI / 2);

        /// <summary>
        /// Starts fast and decelerates (ease-out).
        /// </summary>
        public static float EaseOutSine(float time) => Mathf.Sin(time * Mathf.PI / 2);

        /// <summary>
        /// Starts and ends slowly, speeds up in the middle (ease-in-out).
        /// </summary>
        public static float EaseInOutSine(float time) => -(Mathf.Cos(Mathf.PI * time) - 1) / 2;

        /* ==== QUAD ==== */

        /// <summary>
        /// Accelerates from zero velocity (ease-in quadratic).
        /// </summary>
        public static float EaseInQuad(float time) => time * time;

        /// <summary>
        /// Decelerates to zero velocity (ease-out quadratic).
        /// </summary>
        public static float EaseOutQuad(float time) => 1 - (1 - time) * (1 - time);

        /// <summary>
        /// Accelerates and then decelerates (ease-in-out quadratic).
        /// </summary>
        public static float EaseInOutQuad(float time) => time < 0.5 ? 2 * time * time : 1 - Mathf.Pow(-2 * time + 2, 2) / 2;

        /* ==== BACK ==== */

        /// <summary>
        /// Overshoots slightly before settling (ease-out back).
        /// </summary>
        public static float EaseOutBack(float time)
        {
            float c1 = 1.70158f;
            float c3 = c1 + 1;
            return 1 + c3 * Mathf.Pow(time - 1, 3) + c1 * Mathf.Pow(time - 1, 2);
        }

        /// <summary>
        /// Overshoots in both directions (ease-in-out back).
        /// </summary>
        public static float EaseInOutBack(float time)
        {
            float c1 = 1.70158f;
            float c3 = c1 + 1;
            return c3 * time * time * time - c1 * time * time;
        }
    }
}