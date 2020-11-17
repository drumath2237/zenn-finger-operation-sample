using System;
using UnityEngine;

namespace FingerOperations
{
    [RequireComponent(typeof(Animator))]
    [ExecuteAlways]
    public class SimpleMuscleControl : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        // 左腕の曲げ具合
        [SerializeField, Range(-1.0f, 1.0f)] private float _leftArmStretched;

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (_animator != null)
            {
                _animator = GetComponent<Animator>();
            }
            
            var handler = new HumanPoseHandler(_animator.avatar, _animator.transform);
            var humanpose = new HumanPose();
            handler.GetHumanPose(ref humanpose);

            // index=42はHumanTraitで、Left Forarm Stretchという名前で定義してあるmuscleです。
            humanpose.muscles[42] = Mathf.Clamp(_leftArmStretched, -1.0f, 1.0f);
            
            handler.SetHumanPose(ref humanpose);
        }
    }
}