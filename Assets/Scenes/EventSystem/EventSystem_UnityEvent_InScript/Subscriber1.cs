using UnityEngine;

namespace Scenes.EventSystem.EventSystem_UnityEvent
{
    public class Subscriber1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // GameObject.Find("Publisher").GetComponent<Publisher>()._unityEvent.Invoke();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void OnCustomEvent1()
        {
            Debug.Log("OnCustomEvent1() invoked");
        }
    }
}
