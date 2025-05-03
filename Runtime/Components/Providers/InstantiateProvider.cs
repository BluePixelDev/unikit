using UnityEngine;

namespace BP.Utilkit
{
    [AddComponentMenu("Utilkit/Providers/Instantiate Provider")]
    public class InstantiateProvider : ProviderComponent
    {
        [SerializeField] private GameObject prefab;
        public override GameObject Get() => Instantiate(prefab);
    }
}
