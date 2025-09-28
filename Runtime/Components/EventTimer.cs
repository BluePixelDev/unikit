using UnityEngine;
using UnityEngine.Events;

namespace BP.UniKit
{
    [AddComponentMenu("UniKit/Event Timer")]
    public class EventTimer : MonoBehaviour
    {
        [SerializeField] private float duration;
        [SerializeField] private bool startOnEnable = true;
        [SerializeField] private bool useUnscaledTime;

        [Header("Events")]
        public UnityEvent Started;
        public UnityEvent Finished;

        public float RemainingTime { get; set; }
        public bool IsPlaying { get; set; }

        private void OnEnable()
        {
            if (startOnEnable) StartLifetime();
        }

        private void Update()
        {
            RemainingTime -= useUnscaledTime ? Time.deltaTime : Time.unscaledDeltaTime;
            if (IsPlaying && RemainingTime < 0)
            {
                Finished?.Invoke();
                IsPlaying = false;
            }
        }

        public void StartLifetime()
        {
            Started?.Invoke();
            RemainingTime = duration;
            IsPlaying = true;
        }
    }
}
