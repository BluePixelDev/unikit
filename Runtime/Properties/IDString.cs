using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// Serializable string with an ID property that replaces spaces with underscores.
    /// </summary>
    [System.Serializable]
    public class IDString : ISerializationCallbackReceiver
    {
        [SerializeField] private string id;
        public string ID
        {
            get => id;
            set => UpdateIDString(value);
        }

        public IDString(string id)
        {
            this.id = id;
            UpdateIDString(id);
        }

        private void UpdateIDString(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                this.id = string.Empty;
                return;
            }
            this.id = id.TrimStart().Replace(" ", "_");
        }

        public void OnAfterDeserialize() { }
        public void OnBeforeSerialize() => UpdateIDString(id);

        public static implicit operator string(IDString id) => id.ID;
    }
}
