#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using UnityEngine;
using UnityEngine.UI;

public class FriendErrorPanel : MonoBehaviour
{
    [SerializeField] private Text ErrorMessageText = default;

    public string Text
    {
        get => ErrorMessageText.text;
        set => ErrorMessageText.text = value;
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
