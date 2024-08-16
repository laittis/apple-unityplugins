#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;
using UnityEngine;

namespace Apple.CoreHaptics
{
    [Serializable]
    public class CHHapticPatternComponent
    {
        [HideInInspector]
        public CHHapticEvent Event;
        [HideInInspector]
        public CHHapticParameter Parameter;
        [HideInInspector]
        public CHHapticParameterCurve ParameterCurve;

        public CHHapticPatternComponent() { }
        public CHHapticPatternComponent(CHHapticEvent hapticEvent)
        {
            Event = hapticEvent;
        }
        public CHHapticPatternComponent(CHHapticParameterCurve hapticParameterCurve)
        {
            ParameterCurve = hapticParameterCurve;
        }
        public CHHapticPatternComponent(CHHapticParameter hapticParameter)
        {
            Parameter = hapticParameter;
        }

        public bool IsEvent()
        {
            return !(Event is null);
        }

        public bool IsParameter()
        {
            return Event is null && !(Parameter is null);
        }

        public bool IsParameterCurve()
        {
            return Event is null && Parameter is null && !(ParameterCurve is null);
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
