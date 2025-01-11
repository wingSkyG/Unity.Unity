using UnityEngine;
using UnityEngine.InputSystem;

namespace Scenes.EventSystem.EventSystem_DelegateAndEvent
{
    public class Publisher : MonoBehaviour
    {
        public delegate void OnCustomEvent();
        public static event OnCustomEvent onCustomEvent;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (InputSystem.GetDevice<Keyboard>().anyKey.wasPressedThisFrame)
            {
                onCustomEvent?.Invoke();
            }
        }
    }
}
