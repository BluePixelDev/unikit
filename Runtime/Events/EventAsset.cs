using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// Represents a scriptable object event with no payload.
    /// This event can be triggered and subscribed to for handling game-related events in a decoupled manner.
    /// </summary>
    public abstract class EventAsset : ScriptableObject
    {
        /// <summary>
        /// Delegate for handling event triggers without a payload.
        /// </summary>
        public delegate void EventTriggeredDelegate();

        /// <summary>
        /// Event triggered when the event asset is invoked.
        /// Subscribers can register to be notified when the event is fired.
        /// </summary>
        public event EventTriggeredDelegate Triggered;

        /// <summary>
        /// Triggers the event and notifies all subscribers.
        /// </summary>
        public virtual void Trigger() => Triggered?.Invoke();

        /// <summary>
        /// Cleans up the event when the scriptable object is destroyed.
        /// Prevents memory leaks by ensuring subscribers are unsubscribed.
        /// </summary>
        private void OnDestroy() => Triggered = null;
    }
}
