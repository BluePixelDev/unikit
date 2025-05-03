using System.Collections;
using UnityEngine;

namespace BP.Utilkit
{
    [AddComponentMenu("Utilkit/Ligt Flash")]
    public class LightFlash : MonoBehaviour
    {
        [SerializeField] private Light targetLight;
        [SerializeField] private float duration;

        Coroutine flashCoroutine;
        public Light TargetLight
        {
            get => targetLight;
            set => targetLight = value;
        }

        public float Duration
        {
            get => duration;
            set => duration = value;
        }

        public void Flash()
        {
            StopCoroutine(flashCoroutine);
            flashCoroutine = StartCoroutine(FlashCoroutine());
        }

        IEnumerator FlashCoroutine()
        {
            targetLight.enabled = true;
            yield return new WaitForSeconds(duration);
            targetLight.enabled = false;
        }
    }
}
