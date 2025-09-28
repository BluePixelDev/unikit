using UnityEngine;

namespace BP.UniKit
{
    public static class PhysicsUtil
    {
        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collider2D"/>, prioritizing the attached <see cref="Rigidbody2D"/> if available.
        /// </summary>
        public static GameObject GetRoot(this Collider2D collider)
        {
            return collider.attachedRigidbody != null ? collider.attachedRigidbody.gameObject : collider.gameObject;
        }

        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collider"/>, prioritizing the attached <see cref="Rigidbody"/> if available.
        /// </summary>
        public static GameObject GetRoot(this Collider collider)
        {
            return collider.attachedRigidbody != null ? collider.attachedRigidbody.gameObject : collider.gameObject;
        }

        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collision"/>, prioritizing the associated <see cref="Rigidbody"/> if available.
        /// </summary>
        public static GameObject GetRoot(this Collision collision)
        {
            return collision.rigidbody != null ? collision.rigidbody.gameObject : collision.gameObject;
        }

        /// <summary>
        /// Gets the root <see cref="GameObject"/> from a <see cref="Collision2D"/>, prioritizing the associated <see cref="Rigidbody2D"/> if available.
        /// </summary>
        public static GameObject GetRoot(this Collision2D collision)
        {
            return collision.rigidbody != null ? collision.rigidbody.gameObject : collision.gameObject;
        }
    }
}
