#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
namespace Apple.CoreHaptics
{
    public enum CHHapticEngineFinishedAction
    {
        StopEngine = 1,
        LeaveEngineRunning = 2
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
