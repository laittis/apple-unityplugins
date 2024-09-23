#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿namespace Apple.CoreHaptics
{
    public enum CHHapticDynamicParameterID
    {
        HapticIntensityControl = 0,
        HapticSharpnessControl = 1,
        HapticAttackTimeControl = 2,
        HapticDecayTimeControl = 3,
        HapticReleaseTimeControl = 4,

        AudioVolumeControl = 5,
        AudioPanControl = 6,
        AudioPitchControl = 7,
        AudioBrightnessControl = 8,
        AudioAttackTimeControl = 9,
        AudioDecayTimeControl = 10,
        AudioReleaseTimeControl = 11,
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
