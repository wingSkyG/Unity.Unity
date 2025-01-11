using System;
using System.Collections.Generic;
using FancyScrollView;
using Scenes.FancyScrollView;
using UnityEngine;

namespace Scenes.Plugin.FancyScrollView
{
    public class MyScrollViewCtrl : FancyScrollView<ItemData>
    {
        [SerializeField] private Scroller _scroller;
        [SerializeField] private GameObject _myCellPrefab;

        protected override GameObject CellPrefab => _myCellPrefab;

        // private void Start()
        // {
        //     _scroller.OnValueChanged(base.UpdatePosition);
        // }
        protected override void Initialize()
        {
            base.Initialize();
            _scroller.OnValueChanged(UpdatePosition);
        }

        public void UpdateData(IList<ItemData> items)
        {
            base.UpdateContents(items);
            _scroller.SetTotalCount(items.Count);
        }
    }
}
