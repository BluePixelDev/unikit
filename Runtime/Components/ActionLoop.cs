using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace BP.Utilkit
{
    [AddComponentMenu("Utilkit/Action Loop")]
    public class ActionLoop : MonoBehaviour
    {
        [SerializeField] private float interval = 1f;
        [SerializeField] private int maxCycles = 10;
        [SerializeField] private bool infinite = false;
        [SerializeField] private UnityEvent looped;

        private void Awake()
        {
            StartCoroutine(LoopMethod());
        }

        IEnumerator LoopMethod()
        {
            int cycles = maxCycles;
            while (cycles > 0 || infinite)
            {
                yield return new WaitForSeconds(interval);
                try
                {
                    looped.Invoke();
                }
                catch (Exception ex)
                {
                    Debug.LogException(ex);
                }
                cycles--;
            }
        }

    }
}