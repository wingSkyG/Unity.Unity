using UnityEngine;

namespace Scenes.EventSystem.EventSystem_UnityEvent_WithParam
{
    public class Subscriber : MonoBehaviour
    {
        public void OnCustomEvent(int param)
        {
            Debug.LogFormat("OnCustomEvent() invoked.Param is {0}", param);
        }
    }
}