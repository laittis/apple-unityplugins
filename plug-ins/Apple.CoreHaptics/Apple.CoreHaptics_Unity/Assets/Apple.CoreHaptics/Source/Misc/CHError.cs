#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System.Runtime.InteropServices;

namespace Apple.CoreHaptics
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CHError
    {
        public readonly int Code;
        public readonly string LocalizedDescription;
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
