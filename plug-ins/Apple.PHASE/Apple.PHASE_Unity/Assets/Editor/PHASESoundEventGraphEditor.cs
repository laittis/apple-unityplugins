#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using Apple.PHASE;
using System;
using XNodeEditor;

[CustomNodeGraphEditor(typeof(PHASESoundEventNodeGraph))]
public class PHASESoundEventGraphEditor : NodeGraphEditor
{
    public override string GetNodeMenuName(Type type)
    {

        if (typeof(PHASESoundEventNode).IsAssignableFrom(type))
        {
            return $"SoundEventNodes/{type.Name}";
        }
        else if (typeof(PHASEMixer).IsAssignableFrom(type))
        {
            return $"Mixers/{type.Name}";
        }
        else if (typeof(PHASESoundEventParameter).IsAssignableFrom(type))
        {
            return $"Parameters/{type.Name}";
        }
        else
        {
            return null;
        }
    }

    public override void OnGUI()
    {
        base.OnGUI();
        window.titleContent.text = "PHASE Sound Event Composer";
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
