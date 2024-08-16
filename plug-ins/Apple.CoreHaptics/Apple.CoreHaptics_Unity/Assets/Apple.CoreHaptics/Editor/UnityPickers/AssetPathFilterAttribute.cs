#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using UnityEngine;

namespace UnityPickers
{
	public class AssetPathFilterAttribute : PropertyAttribute
	{
		public string[] Filters;

		public AssetPathFilterAttribute(params string[] filters)
		{
			Filters = filters;
		}
	}
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
