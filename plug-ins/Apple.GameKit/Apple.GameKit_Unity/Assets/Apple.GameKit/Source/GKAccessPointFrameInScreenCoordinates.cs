#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System.Runtime.InteropServices;
using UnityEngine;

namespace Apple.GameKit
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GKAccessPointFrameInScreenCoordinates
    {
        public float X;
        public float Y;
        public float Width;
        public float Height;

        public Rect ToRect()
        {
            return new Rect(X, Y, Width, Height);
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
