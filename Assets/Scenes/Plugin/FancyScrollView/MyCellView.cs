using FancyScrollView;
using Scenes.FancyScrollView;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Scenes.Plugin.FancyScrollView
{
    public class MyCellView : FancyCell<ItemData>
    {
        [SerializeField] private Animator _animator = default;
        [SerializeField] private Text _message = default;
        private float _currentPosition = 0;
        
        static class AnimatorHash
        {
            public static readonly int Scroll = Animator.StringToHash("scroll");
        }
        
        void OnEnable() => UpdatePosition(_currentPosition);
        
        public override void UpdateContent(ItemData itemData)
        {
            _message.text = itemData.Message;
        }

        public override void UpdatePosition(float position)
        {
            if (_animator.isActiveAndEnabled)
            {
                _animator.Play(AnimatorHash.Scroll, -1, position);
            }
        }
    }
}
