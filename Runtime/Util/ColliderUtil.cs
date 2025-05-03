using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// Utility class for working with Colliders and Collisions to get the root Transform.
    /// </summary>
    public static class ColliderUtil
    {
        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collider2D"/>, prioritizing the attached <see cref="Rigidbody2D"/> if available.
        /// </summary>
        public static GameObject Root(this Collider2D collider)
        {
            return collider.attachedRigidbody != null ? collider.attachedRigidbody.gameObject : collider.gameObject;
        }

        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collider"/>, prioritizing the attached <see cref="Rigidbody"/> if available.
        /// </summary>
        public static GameObject Root(this Collider collider)
        {
            return collider.attachedRigidbody != null ? collider.attachedRigidbody.gameObject : collider.gameObject;
        }

        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collision"/>, prioritizing the associated <see cref="Rigidbody"/> if available.
        /// </summary>
        public static GameObject Root(this Collision collision)
        {
            return collision.rigidbody != null ? collision.rigidbody.gameObject : collision.gameObject;
        }

        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collision2D"/>, prioritizing the associated <see cref="Rigidbody2D"/> if available.
        /// </summary>
        public static GameObject Root(this Collision2D collision)
        {
            return collision.rigidbody != null ? collision.rigidbody.gameObject : collision.gameObject;
        }
    }
}
