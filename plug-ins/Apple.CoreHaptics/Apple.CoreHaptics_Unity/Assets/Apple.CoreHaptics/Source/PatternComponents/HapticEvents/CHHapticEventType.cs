#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿namespace Apple.CoreHaptics
{
    public enum CHHapticEventType
    {
        HapticTransient = 0,
        HapticContinuous = 1,
        AudioContinuous = 2,
        AudioCustom = 3
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
