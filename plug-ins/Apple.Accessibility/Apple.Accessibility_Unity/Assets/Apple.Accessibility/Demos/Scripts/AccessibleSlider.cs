#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using UnityEngine;

namespace Apple.Accessibility.Demo
{
    internal class AccessibleSlider : MonoBehaviour
    {
        public bool AccessibilityIncrement()
        {
            if (!isActiveAndEnabled)
            {
                return false;
            }
            UnityEngine.UI.Slider slider = gameObject.GetComponent<UnityEngine.UI.Slider>();

            float delta = (slider.maxValue - slider.minValue) / 10.0f;
            float target = slider.value + delta;

            slider.value = Mathf.Clamp(target, slider.minValue, slider.maxValue);
            return true;
        }

        public bool AccessibilityDecrement()
        {
            if (!isActiveAndEnabled)
            {
                return false;
            }

            UnityEngine.UI.Slider slider = gameObject.GetComponent<UnityEngine.UI.Slider>();

            float delta = (slider.maxValue - slider.minValue) / 10.0f;
            float target = slider.value - delta;

            slider.value = Mathf.Clamp(target, slider.minValue, slider.maxValue);
            return true;
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
