#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using Apple.PHASE;
using UnityEditor;
using XNodeEditor;

[CustomNodeEditor(typeof(PHASESoundEventParameterInteger))]
public class PHASESoundEventParameterIntegerNodeEditor : NodeEditor
{
    public override void OnBodyGUI()
    {
        serializedObject.Update();
        EditorGUIUtility.labelWidth = 100;
        var node = target as PHASESoundEventParameterInteger;
        NodeEditorGUILayout.PortField(node.GetInputPort("ParentNode"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_parameterName"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_defaultValue"));
        serializedObject.ApplyModifiedProperties();
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
