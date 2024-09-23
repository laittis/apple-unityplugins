#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using UnityEngine.Scripting;

[assembly:Preserve]

namespace Apple.GameKit
{
    internal static class InteropUtility
    {
#if (UNITY_IOS || UNITY_TVOS || UNITY_VISIONOS) && !UNITY_EDITOR
        public const string DLLName = "__Internal";
#else
        public const string DLLName = "GameKitWrapper";
#endif
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
