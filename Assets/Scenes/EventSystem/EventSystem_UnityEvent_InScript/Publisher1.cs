using UnityEngine;
using UnityEngine.Events;

namespace Scenes.EventSystem.EventSystem_UnityEvent
{
     /// <summary>
     /// UnityEvent的使用：在类中订阅事件
     /// </summary>
    public class Publisher1 : MonoBehaviour
    {
        public Subscriber1 subscriber1;
        public Subscriber2 subscriber2;
    
        public UnityEvent _unityEvent = new UnityEvent();
        
        void Start()
        {
            _unityEvent.AddListener(subscriber1.OnCustomEvent1);
            _unityEvent.AddListener(subscriber2.OnCustomEvent2);
        }
    
        void Update()
        {
            // if (InputSystem.GetDevice<Keyboard>().anyKey.wasPressedThisFrame)
            // {
            //     _unityEvent?.Invoke();
            // }
        }
    }
}
