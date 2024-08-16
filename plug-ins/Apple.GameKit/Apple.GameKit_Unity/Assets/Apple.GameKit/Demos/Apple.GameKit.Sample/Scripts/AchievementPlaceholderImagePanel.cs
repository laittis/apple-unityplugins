#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Apple.GameKit.Sample
{
    public class AchievementPlaceholderImagePanel : MonoBehaviour
    {
        [SerializeField] private RawImage _image = default;
        [SerializeField] private Text _titleText = default;

        public Texture2D Image
        {
            get => _image.texture as Texture2D;
            set => _image.texture = value;
        }

        public string Title
        {
            get => _titleText.text;
            set => _titleText.text = value;
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
