#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System;
using UnityEngine;

namespace Apple.Core.Runtime
{
    public static class Texture2DExtensions
    {
        /// <summary>
        /// Create a Texture2D object from the contents of an NSData object.
        /// </summary>
        /// <param name="nsData"></param>
        /// <returns>The created texture if successful; null otherwise.</returns>
        public static Texture2D CreateFromNSData(NSData nsData)
        {
            Texture2D texture = null;

            if (nsData?.Length > 0)
            {
                texture = new Texture2D(1, 1);
                texture.LoadImage(nsData.Bytes);
            }

            return texture;
        }

        /// <summary>
        /// Create a Texture2D object from the contents of an NSData object referenced via IntPtr.
        /// </summary>
        /// <param name="nsDataPtr"></param>
        /// <returns>The created texture if successful; null otherwise.</returns>
        public static Texture2D CreateFromNSDataPtr(IntPtr nsDataPtr)
        {
            return (nsDataPtr != IntPtr.Zero) ? CreateFromNSData(InteropReference.PointerCast<NSData>(nsDataPtr)) : null;
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
