using System;
using UnityEngine;

namespace FingerOperations
{
    [RequireComponent(typeof(Animator))]
    public class HumanoidTest : MonoBehaviour
    {
        private Animator _animator;
        private void Start()
        {
            _animator = GetComponent<Animator>();
            
            _animator.GetBoneTransform(HumanBodyBones.LeftUpperArm)
                .Rotate(new Vector3(0,0,60f));
        }
    }
}