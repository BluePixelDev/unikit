using UnityEngine;

namespace BP.UniKit
{
    public static class UniKit
    {
        /// <summary>
        /// Checks if the target is null or destroyed.
        /// </summary>
        /// <returns>True if the target is null or destroyed; otherwise, false.</returns>
        public static bool IsUnityNull<T>(this T target) where T : Object => target == null || target.Equals(null);

        //==== PHYSICS ====
        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collider2D"/>, prioritizing the attached <see cref="Rigidbody2D"/> if available.
        /// </summary>
        public static GameObject GetRoot(this Collider2D collider) => collider.attachedRigidbody != null ? collider.attachedRigidbody.gameObject : collider.gameObject;

        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collider"/>, prioritizing the attached <see cref="Rigidbody"/> if available.
        /// </summary>
        public static GameObject GetRoot(this Collider collider) => collider.attachedRigidbody != null ? collider.attachedRigidbody.gameObject : collider.gameObject;

        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collision"/>, prioritizing the associated <see cref="Rigidbody"/> if available.
        /// </summary>
        public static GameObject GetRoot(this Collision collision) => collision.rigidbody != null ? collision.rigidbody.gameObject : collision.gameObject;

        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collision2D"/>, prioritizing the associated <see cref="Rigidbody2D"/> if available.
        /// </summary>
        public static GameObject GetRoot(this Collision2D collision) => collision.rigidbody != null ? collision.rigidbody.gameObject : collision.gameObject;

        public static Vector2 RandomVector2(float min, float max)
          => new(Random.Range(min, max), Random.Range(min, max));

        public static Vector2 RandomVector2(Vector2 min, Vector2 max)
            => new(
                Random.Range(min.x, max.x),
                Random.Range(min.y, max.y)
            );

        public static Vector3 RandomVector3(float min, float max)
            => new(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));

        public static Vector3 RandomUnitVector3() => RandomVector3(-1, 1).normalized;
        public static Vector3 RandomUnitVector2() => RandomVector2(-1, 1).normalized;
    }
}
