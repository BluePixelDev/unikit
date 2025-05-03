using UnityEngine;

namespace BP.Utilkit
{
    [AddComponentMenu("Utilkit/LogComponent")]
    public class LogComponent : MonoBehaviour
    {
        [SerializeField] private string message;

        public void LogMessage() => LogMessage(message);
        public void LogMessage(string message) => Debug.Log(message);
    }
}
