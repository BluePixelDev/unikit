using System;

namespace BP.Utilkit
{
    public static class NullFunc
    {
        /// <summary>
        /// Invokes the specified action if the target is not null.
        /// </summary>
        /// <typeparam name="T">The type of the target.</typeparam>
        /// <param name="target">The target object to check.</param>
        /// <param name="action">The action to invoke if the target is not null.</param>
        public static void WithNotNull<T>(this T target, Action<T> action)
        {
            if (!target.IsNull()) action.Invoke(target);
        }

        /// <summary>
        /// Invokes the specified action if the target is not null.
        /// </summary>
        /// <typeparam name="T">The type of the target.</typeparam>
        /// <param name="target">The target object to check.</param>
        /// <param name="action">The action to invoke if the target is not null.</param>
        public static void WithNotNull<T>(this T target, Action action)
        {
            if (!target.IsNull()) action.Invoke();
        }

        /// <summary>
        /// Invokes the specified action if the target is null.
        /// </summary>
        /// <typeparam name="T">The type of the target.</typeparam>
        /// <param name="target">The target object to check.</param>
        /// <param name="action">The action to invoke if the target is null.</param>
        public static void WithNull<T>(this T target, Action<T> action)
        {
            if (target.IsNull()) action.Invoke(target);
        }

        /// <summary>
        /// Invokes the specified action if the target is null.
        /// </summary>
        /// <typeparam name="T">The type of the target.</typeparam>
        /// <param name="target">The target object to check.</param>
        /// <param name="action">The action to invoke if the target is null.</param>
        public static void WithNull<T>(this T target, Action action)
        {
            if (target.IsNull()) action.Invoke();
        }

        /// <summary>
        /// Checks if the target is null or destroyed.
        /// </summary>
        /// <returns>True if the target is null or destroyed; otherwise, false.</returns>
        public static bool IsNull<T>(this T target) => target == null || target.Equals(null);
    }
}