#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿namespace Apple.CoreHaptics
{
    public enum CHHapticEventParameterID
    {
        HapticIntensity = 0,
        HapticSharpness = 1,
        AttackTime = 2,
        DecayTime = 3,
        ReleaseTime = 4,
        Sustained = 5,

        AudioVolume = 6,
        AudioPan = 7,
        AudioPitch = 8,
        AudioBrightness = 9
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
