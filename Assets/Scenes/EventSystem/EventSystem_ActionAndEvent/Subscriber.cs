using System;
using UnityEngine;

namespace Scenes.EventSystem.EventSystem_ActionAndEvent
{
    public class Subscriber : MonoBehaviour
    {
        void Start()
        {
            Publisher.OnCustomEvent += OnCustomEvent;
        }

        private void OnCustomEvent()
        {
            Debug.Log("OnCustomEvent() invoked");
        }
    }
}
