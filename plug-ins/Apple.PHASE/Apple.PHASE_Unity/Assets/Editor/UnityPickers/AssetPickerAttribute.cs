#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using JetBrains.Annotations;
using UnityEngine;

namespace UnityPickers
{
	public class AssetPickerAttribute : PropertyAttribute
	{
		[NotNull]
		public string Path;

		public AssetPickerAttribute(string path = "")
		{
			Path = path;
		}
	}
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
