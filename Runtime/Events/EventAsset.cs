using UnityEngine;

namespace BP.UniKit
{
    public abstract class EventAsset : ScriptableObject
    {
        public delegate void EventTriggeredDelegate();
        public event EventTriggeredDelegate Triggered;
        public virtual void Trigger() => Triggered?.Invoke();
    }

    public abstract class EventAsset<TPayload> : ScriptableObject
    {
        public delegate void EventTriggeredDelegate(TPayload payload);
        public event EventTriggeredDelegate Triggered;
        public virtual void Trigger(TPayload payload) => Triggered?.Invoke(payload);
    }
}
