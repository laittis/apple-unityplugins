#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using Apple.PHASE;
using UnityEditor;
using XNodeEditor;

[CustomNodeEditor(typeof(PHASESoundEventParameterString))]
public class PHASESoundEventParameterStringNodeEditor : NodeEditor
{
    public override void OnBodyGUI()
    {
        serializedObject.Update();
        EditorGUIUtility.labelWidth = 100;
        var node = target as PHASESoundEventParameterString;
        NodeEditorGUILayout.PortField(node.GetInputPort("ParentNode"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_parameterName"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_defaultValue"));
        serializedObject.ApplyModifiedProperties();
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
