using UnityEngine;

namespace Scenes.EventSystem.EventSystem_UnityEvent_InInspector
{
    public class Subscriber : MonoBehaviour
    {
        public void OnCustomEvent()
        {
            Debug.Log("OnCustomEvent() invoked");
        }
    }
}
