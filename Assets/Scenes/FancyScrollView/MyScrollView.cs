using System;
using System.Collections.Generic;
using FancyScrollView;
using UnityEngine;

namespace Scenes.FancyScrollView
{
    public class MyScrollView : FancyScrollView<ItemData>
    {
        [SerializeField] private Scroller scroller = default;
        [SerializeField] private GameObject cellPrefab = default;
        
        protected override GameObject CellPrefab => cellPrefab;

        private void Start()
        {
            base.Initialize();
            scroller.OnValueChanged(base.UpdatePosition);
        }

        public void UpdateData(IList<ItemData> items)
        {
            base.UpdateContents(items);
            scroller.SetTotalCount(items.Count);
        }
    }
}
