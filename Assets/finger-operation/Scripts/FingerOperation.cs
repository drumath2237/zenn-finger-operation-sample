using System;
using UnityEngine;

namespace FingerOperations
{
    [ExecuteAlways]
    [RequireComponent(typeof(Animator))]
    public class FingerOperation: MonoBehaviour
    {
        private Animator _animator;
        private void Start()
        {
            _animator = GetComponent<Animator>();
        }
    }
}