#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System;
using System.Runtime.InteropServices;

namespace Apple.GameKit
{
    /// <summary>
    /// A notification banner that displays text to the player.
    /// </summary>
    public static class GKNotificationBanner
    {
        /// <summary>
        /// Displays a banner to the player.
        /// </summary>
        /// <param name="title">The title of the banner.</param>
        /// <param name="message">A secondary message to be displayed.</param>
        public static void Show(string title, string message) => Interop.GKNotificationBanner_Show(title, message);

        /// <summary>
        /// Displays a banner to the player for a specified period of time.
        /// </summary>
        /// <param name="title">The title of the banner.</param>
        /// <param name="message">A secondary message to be displayed.</param>
        /// <param name="duration">The amount of time that the banner should be displayed to the player.</param>
        public static void Show(string title, string message, TimeSpan duration) => Interop.GKNotificationBanner_ShowWithDuration(title, message, duration.TotalSeconds);

        private static class Interop
        {
            [DllImport(InteropUtility.DLLName)]
            public static extern void GKNotificationBanner_Show(string title, string message);
            [DllImport(InteropUtility.DLLName)]
            public static extern void GKNotificationBanner_ShowWithDuration(string title, string message, double duration);
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
