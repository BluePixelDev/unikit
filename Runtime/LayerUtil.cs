using UnityEngine;

namespace BP.UniKit
{
    public static class LayerUtil
    {
        /// <summary>
        /// Determines whether the specified layer is included in the LayerMask.
        /// </summary>
        /// <param name="layerMask">The LayerMask to check.</param>
        /// <param name="layer">The layer index to check.</param>
        /// <returns>True if the layer is included; otherwise, false.</returns>
        public static bool ContainsLayer(this LayerMask layerMask, int layer) => (layerMask & 1 << layer) != 0;

        /// <summary>
        /// Checks whether the GameObject is in the specified LayerMask.
        /// </summary>
        /// <param name="gameObject">The GameObject to check.</param>
        /// <param name="layerMask">The LayerMask to test against.</param>
        /// <returns>True if the GameObject's layer is in the mask; otherwise, false.</returns>
        public static bool IsInLayerMask(this GameObject gameObject, LayerMask layerMask) => layerMask.ContainsLayer(gameObject.layer);

        /// <summary>
        /// Adds a layer to the LayerMask.
        /// </summary>
        /// <param name="layerMask">The LayerMask to modify.</param>
        /// <param name="layer">The layer index to add.</param>
        public static void AddLayer(ref this LayerMask layerMask, int layer)
        {
            layerMask |= 1 << layer;
        }

        /// <summary>
        /// Removes a layer from the LayerMask.
        /// </summary>
        /// <param name="layerMask">The LayerMask to modify.</param>
        /// <param name="layer">The layer index to remove.</param>
        public static void RemoveLayer(ref this LayerMask layerMask, int layer)
        {
            layerMask &= ~(1 << layer);
        }
    }
}