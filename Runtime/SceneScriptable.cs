using System;
using UnityEngine;

namespace BP.UniKit
{
    /// <summary>
    /// A ScriptableObject that provides scene lifecycle event hooks.
    /// </summary>
    public class SceneScriptable : ScriptableObject
    {
        //// <summary>
        /// Event triggered when a scene is loaded.
        /// </summary>
        internal static event Action Initialized;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Initialize()
        {
            Initialized?.Invoke();
        }

        private void Awake() => OnInitialize();

        /// <summary>
        /// Called when the ScriptableObject is enabled.
        /// </summary>
        protected virtual void OnEnable()
        {
            // Ensure the ScriptableObject is subscribed to the scene load event.
            Initialized += OnInitialize;
        }

        /// <summary>
        /// Called when the ScriptableObject is destroyed.
        /// </summary>
        protected virtual void OnDestroy()
        {
            Initialized -= OnInitialize;
        }

        /// <summary>
        /// Called when the scene is entered or the ScriptableObject is activated.
        /// </summary>
        protected virtual void OnInitialize()
        {
        }
    }
}
