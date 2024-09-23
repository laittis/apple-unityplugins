#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System.Linq;
using System.Text.RegularExpressions;

namespace UnityPickers.Utility
{
	public static class StringUtils
	{
		public static bool MatchesFilter(string text, string filter)
		{
			var elems = filter
				.ToLowerInvariant()
				.Split()
				.Select(Regex.Escape)
				.ToArray();

			var pattern = string.Join(".*", elems);
			return Regex.Match(text.ToLowerInvariant(), pattern).Success;
		}
	}
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
