using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// Represents a scriptable object event that carries a payload of type <typeparamref name="TPayload"/>.
    /// This event can be triggered and subscribed to for handling game-related events in a decoupled manner.
    /// </summary>
    /// <typeparam name="TPayload">The type of payload associated with the event.</typeparam>
    public abstract class EventAsset<TPayload> : ScriptableObject
    {
        /// <summary>
        /// Delegate for handling event triggers with a payload.
        /// </summary>
        /// <param name="payload">The payload associated with the triggered event.</param>
        public delegate void EventTriggeredDelegate(TPayload payload);

        /// <summary>
        /// Event triggered when the event asset is invoked.
        /// Subscribers can register to be notified when the event is fired.
        /// </summary>
        public event EventTriggeredDelegate Triggered;

        /// <summary>
        /// Triggers the event and notifies all subscribers with the given payload.
        /// </summary>
        /// <param name="payload">The payload to pass to event listeners.</param>
        public virtual void Trigger(TPayload payload) => Triggered?.Invoke(payload);

        /// <summary>
        /// Cleans up the event when the scriptable object is destroyed.
        /// Prevents memory leaks by ensuring subscribers are unsubscribed.
        /// </summary>
        private void OnDestroy() => Triggered = null;
    }
}