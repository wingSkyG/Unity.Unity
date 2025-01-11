using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Scenes.EventSystem.EventSystem_UnityEvent
{
    /// <summary>
    /// UnityEvent只能在本类中触发，在其它类中触发无效果
    /// </summary>
    public class Publisher2 : MonoBehaviour
    {
        private UnityEvent _unityEvent;
        
        void Start()
        {
            if (_unityEvent != null)
            {
                _unityEvent = GameObject.Find("Publisher1").GetComponent<Publisher1>()._unityEvent;
            }
        }
    
        void Update()
        {
            if (InputSystem.GetDevice<Keyboard>().anyKey.wasPressedThisFrame)
            {
                Debug.Log("Update2");
                _unityEvent?.Invoke(); // Invoke()无效，因为Invoke()只能在定义UnityEvent的类中调用
            }
        }
    }
}
