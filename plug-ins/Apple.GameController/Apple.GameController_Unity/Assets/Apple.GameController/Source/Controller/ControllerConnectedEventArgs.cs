#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;

namespace Apple.GameController.Controller
{
    public class ControllerConnectedEventArgs : EventArgs
    {
        public GCController Controller;

        public ControllerConnectedEventArgs(GCController controller)
        {
            Controller = controller;
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
