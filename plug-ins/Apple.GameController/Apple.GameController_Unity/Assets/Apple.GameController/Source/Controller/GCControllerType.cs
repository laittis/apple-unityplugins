#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿namespace Apple.GameController.Controller
{
    public enum GCControllerType : int
    {
        Unknown    = 0,
        XboxOne    = 1,
        DualShock  = 2,
        DualSense  = 3,
        SiriRemote = 4
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
