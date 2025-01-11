using UnityEngine;

namespace Scenes.EventSystem.EventSystem_DelegateAndEvent
{
    public class Subscriber : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Publisher.onCustomEvent += OnCustomEvent;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnCustomEvent()
        {
            Debug.Log("OnCustomEvent() invoked");
        }
    }
}
