using UnityEngine;
using UnityEngine.Events;

namespace BP.Utilkit
{
    [AddComponentMenu("Utilkit/Compomemmt Events")]
    public class ComponentEvents : MonoBehaviour
    {
        [SerializeField] private UnityEvent Awakened;
        [SerializeField] private UnityEvent Started;
        [SerializeField] private UnityEvent Enabled;
        [SerializeField] private UnityEvent Disabled;

        private void Awake() => Awakened?.Invoke();
        private void Start() => Started?.Invoke();
        private void OnEnable() => Enabled?.Invoke();
        private void OnDisable() => Disabled?.Invoke();
    }
}
