#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
namespace System
{
    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// Helper method to create a DateTimeOffset from a double-precision number of seconds since the Unix epoch (Jan 1 1970).
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns>DateTimeOffset</returns>
        public static DateTimeOffset FromUnixTimeSeconds(double seconds)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64(TimeSpan.FromSeconds(seconds).TotalMilliseconds));
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
