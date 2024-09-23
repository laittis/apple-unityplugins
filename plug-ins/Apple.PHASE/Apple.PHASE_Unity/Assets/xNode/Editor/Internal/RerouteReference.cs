#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using UnityEngine;

namespace XNodeEditor.Internal {
	public struct RerouteReference {
		public XNode.NodePort port;
		public int connectionIndex;
		public int pointIndex;

		public RerouteReference(XNode.NodePort port, int connectionIndex, int pointIndex) {
			this.port = port;
			this.connectionIndex = connectionIndex;
			this.pointIndex = pointIndex;
		}

		public void InsertPoint(Vector2 pos) { port.GetReroutePoints(connectionIndex).Insert(pointIndex, pos); }
		public void SetPoint(Vector2 pos) { port.GetReroutePoints(connectionIndex) [pointIndex] = pos; }
		public void RemovePoint() { port.GetReroutePoints(connectionIndex).RemoveAt(pointIndex); }
		public Vector2 GetPoint() { return port.GetReroutePoints(connectionIndex) [pointIndex]; }
	}
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
