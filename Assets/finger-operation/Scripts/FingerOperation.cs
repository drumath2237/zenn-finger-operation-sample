using System;
using UnityEditor;
using UnityEngine;

namespace FingerOperations
{
    [ExecuteAlways]
    [RequireComponent(typeof(Animator))]
    public class FingerOperation : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private FingerConfig _fingerConfig;

        [SerializeField, Range(-1.0f, 1.0f)] private float _leftArmStretched = default;

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
            var humanPose = new HumanPose();
            handler.GetHumanPose(ref humanPose);

            // left arm muscle test
            humanPose.muscles[42] = Mathf.Clamp(_leftArmStretched, -1.0f, 1.0f);

            humanPose.muscles[55] = _fingerConfig.thumb1Stretched;
            humanPose.muscles[56] = _fingerConfig.thumbSpread;
            humanPose.muscles[57] = _fingerConfig.thumb2Stretched;
            humanPose.muscles[58] = _fingerConfig.thumb3Stretched;

            humanPose.muscles[59] = _fingerConfig.index1Stretched;
            humanPose.muscles[60] = _fingerConfig.indexSpread;
            humanPose.muscles[61] = _fingerConfig.index2Stretched;
            humanPose.muscles[62] = _fingerConfig.index3Stretched;

            humanPose.muscles[63] = _fingerConfig.middle1Stretched;
            humanPose.muscles[64] = _fingerConfig.middleSpread;
            humanPose.muscles[65] = _fingerConfig.middle2Stretched;
            humanPose.muscles[66] = _fingerConfig.middle3Stretched;

            humanPose.muscles[67] = _fingerConfig.ring1Stretched;
            humanPose.muscles[68] = _fingerConfig.ringSpread;
            humanPose.muscles[69] = _fingerConfig.ring2Stretched;
            humanPose.muscles[70] = _fingerConfig.ring3Stretched;

            humanPose.muscles[71] = _fingerConfig.pinky1Stretched;
            humanPose.muscles[72] = _fingerConfig.pinkySpread;
            humanPose.muscles[72] = _fingerConfig.pinky2Stretched;
            humanPose.muscles[74] = _fingerConfig.pinky3Stretched;

            handler.SetHumanPose(ref humanPose);
        }

        [ContextMenu("show muscle name")]
        void ShowMusclesName()
        {
            for (var i = 0; i < HumanTrait.MuscleCount; i++)
            {
                Debug.Log($"{i}: {HumanTrait.MuscleName[i]}");
            }
        }
    }
}