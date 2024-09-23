#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using UnityEngine;

/// <summary> Draw enums correctly within nodes. Without it, enums show up at the wrong positions. </summary>
/// <remarks> Enums with this attribute are not detected by EditorGui.ChangeCheck due to waiting before executing </remarks>
public class NodeEnumAttribute : PropertyAttribute { }
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
