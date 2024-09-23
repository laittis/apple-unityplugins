#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System;

namespace Apple.Core.Runtime
{
    public static class NSDataExtensions
    {
        public static string ToString(this NSData data, int maxLength)
        {
            string s = string.Empty;
            try
            {
                var bytes = data.Bytes;
                var isTruncated = bytes.Length > maxLength;
                s = System.Text.Encoding.UTF8.GetString(bytes, 0, isTruncated ? maxLength : bytes.Length);
                if (isTruncated)
                {
                    s += "...";
                }
            }
            catch (ArgumentNullException)
            {
                s = "(null)";
            }
            catch (ArgumentException)
            {
                s = "(binary data)";
            }
            catch
            {
                s = "(error)";
            }
            return s;
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
