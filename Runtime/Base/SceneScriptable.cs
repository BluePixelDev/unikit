using System;
using UnityEngine;

namespace BP.UniKit
{
    /// <summary>
    /// A ScriptableObject that provides scene lifecycle event hooks.
    /// </summary>
    public class SceneScriptable : ScriptableObject
    {
        internal static event Action Initialized;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Initialize() => Initialized?.Invoke();

        private void Awake() => OnInitialize();
        private void OnEnable() => Initialized += OnInitialize;
        private void OnDestroy() => Initialized -= OnInitialize;

        /// <summary>
        /// Called when the scene is entered or the ScriptableObject is activated.
        /// </summary>
        protected virtual void OnInitialize()
        {
        }
    }
}
