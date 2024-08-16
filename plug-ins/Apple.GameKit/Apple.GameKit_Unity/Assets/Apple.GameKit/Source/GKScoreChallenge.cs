#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System;

namespace Apple.GameKit
{
    /// <summary>
    /// A type of challenge where a player must beat the leaderboard score of another player.
    /// </summary>
    [Obsolete("Since GKScore was deprecated in iOS 14, tvOS 14, and macOS 11, this challenge type is deprecated.")]
    public class GKScoreChallenge : GKChallenge
    {
        #region Init & Dispose
        internal GKScoreChallenge(IntPtr pointer) : base(pointer)
        {
        }
        #endregion
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
