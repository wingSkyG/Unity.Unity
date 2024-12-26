using UnityEngine;

namespace Scenes.FancyScrollView
{
    public class ItemData : MonoBehaviour
    {
        public string Message { get; }

        public ItemData(string message)
        {
            Message = message;
        }
    }
}
