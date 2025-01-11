using UnityEngine;

namespace Scenes.EventSystem.EventSystem_UnityEvent
{
    public class Subscriber2 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void OnCustomEvent2()
        {
            Debug.Log("OnCustomEvent2() invoked");
        }
    }
}
