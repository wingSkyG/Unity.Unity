using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Scenes.EventSystem.EventSystem_UnityEvent_InInspector
{
    public class Publisher : MonoBehaviour
    {
        public UnityEvent unityEvent;

        private void Update()
        {
            if (InputSystem.GetDevice<Keyboard>().anyKey.wasPressedThisFrame)
            {
                unityEvent.Invoke();
            }
        }
    }
}