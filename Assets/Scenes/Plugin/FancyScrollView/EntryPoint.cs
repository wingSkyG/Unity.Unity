using System;
using System.Linq;
using Scenes.FancyScrollView;
using UnityEngine;

namespace Scenes.Plugin.FancyScrollView
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private MyScrollViewCtrl _myScrollViewCtrl = default;
        
        private void Start()
        {
            var items = Enumerable.Range(0, 20)
                .Select(i => new ItemData($"Cell {i}"))
                .ToArray();
            
            _myScrollViewCtrl.UpdateData(items);
        }
    }
}
