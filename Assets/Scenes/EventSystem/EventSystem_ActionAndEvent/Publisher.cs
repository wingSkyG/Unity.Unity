using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Scenes.EventSystem.EventSystem_ActionAndEvent
{
    public class Publisher : MonoBehaviour
    {
        public static event Action OnCustomEvent;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (InputSystem.GetDevice<Keyboard>().anyKey.wasPressedThisFrame)
            {
                OnCustomEvent?.Invoke();
            }
        }
    }
}
