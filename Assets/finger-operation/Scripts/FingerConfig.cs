using UnityEngine;

namespace FingerOperations
{
    [CreateAssetMenu(fileName = "Finger Configuration", menuName = "Finger Configuration", order = 0)]
    public class FingerConfig : ScriptableObject
    {
        [Header("Thumb Config")]
        [SerializeField, Range(0, 1.0f)] public float thumb1Stretched;
        [SerializeField, Range(0, 1.0f)] public float thumb2Stretched;
        [SerializeField, Range(0, 1.0f)] public float thumb3Stretched;
        [SerializeField, Range(0, 1.0f)] public float thumbSpread;
        [Space]
        
        [Header("Index Config")]
        [SerializeField, Range(0, 1.0f)] public float index1Stretched;
        [SerializeField, Range(0, 1.0f)] public float index2Stretched;
        [SerializeField, Range(0, 1.0f)] public float index3Stretched;
        [SerializeField, Range(0, 1.0f)] public float indexSpread;
        [Space]
        
        [Header("Middle Config")]
        [SerializeField, Range(0, 1.0f)] public float middle1Stretched;
        [SerializeField, Range(0, 1.0f)] public float middle2Stretched;
        [SerializeField, Range(0, 1.0f)] public float middle3Stretched;
        [SerializeField, Range(0, 1.0f)] public float middleSpread;
        [Space]

        [Header("Ring Config")]
        [SerializeField, Range(0, 1.0f)] public float ring1Stretched;
        [SerializeField, Range(0, 1.0f)] public float ring2Stretched;
        [SerializeField, Range(0, 1.0f)] public float ring3Stretched;
        [SerializeField, Range(0, 1.0f)] public float ringSpread;
        [Space]

        [Header("Pinky Config")]
        [SerializeField, Range(0, 1.0f)] public float pinky1Stretched;
        [SerializeField, Range(0, 1.0f)] public float pinky2Stretched;
        [SerializeField, Range(0, 1.0f)] public float pinky3Stretched;
        [SerializeField, Range(0, 1.0f)] public float pinkySpread;
    }
}