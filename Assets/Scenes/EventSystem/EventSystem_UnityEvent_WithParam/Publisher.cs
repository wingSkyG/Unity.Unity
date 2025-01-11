using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Scenes.EventSystem.EventSystem_UnityEvent_WithParam
{
    public class Publisher : MonoBehaviour
    {
        public UnityEvent<int> unityEvent;
        
        void Update()
        {
            if (InputSystem.GetDevice<Keyboard>().anyKey.wasPressedThisFrame)
            {
                unityEvent.Invoke(5);
            }
        }
    }
}
