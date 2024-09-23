#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System;
using System.Collections.Generic;
using Apple.UnityJSON;

namespace Apple.CoreHaptics
{
    [Serializable]
    public class CHHapticEvent : ICHHapticPatternEntry, ISerializable
    {
        public CHHapticEventType EventType;

        public float Time;
        public float EventDuration;
        public string EventWaveformPath;
        public UnityEngine.Object EventWaveform;

        public List<CHHapticEventParameter> EventParameters = new List<CHHapticEventParameter>();

		public virtual string Serialize(Serializer serializer) {
			throw new NotImplementedException();
		}

        internal string SerializeTypeAndTime() {
            var ret = $"\t\t\t\t\"EventType\": \"{EventType}\",\n";
            ret += $"\t\t\t\t\"Time\": {Time}";
            return ret;
        }

        internal string SerializeEventParams() {
            var ret = "";
            if (EventParameters.Count > 0) {
                ret += ",\n\t\t\t\t\"EventParameters\": [";

                for (var idx = 0; idx < EventParameters.Count; idx++) {
                    var ep = EventParameters[idx];
                    ret += $"\n\t\t\t\t\t{{\"ParameterID\": \"{ep.ParameterID}\", \"ParameterValue\": {ep.ParameterValue}}}";

                    // Add a comma for all but the last Param
                    if (idx != EventParameters.Count - 1) {
                        ret += ",";
                    }
                }

                ret += "\n\t\t\t\t]\n";
            }
            else {
                ret += "\n";
            }

            return ret;
        }
	}
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
