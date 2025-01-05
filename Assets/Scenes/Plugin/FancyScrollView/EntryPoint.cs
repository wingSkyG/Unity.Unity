using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Scenes.FancyScrollView
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private MyScrollView myScrollView = default;
        
        void Start()
        {
            var items = Enumerable.Range(0, 20)
                .Select(i => new ItemData($"Cell {i}"))
                .ToArray();
            
            myScrollView.UpdateData(items);
        }
    }
}
