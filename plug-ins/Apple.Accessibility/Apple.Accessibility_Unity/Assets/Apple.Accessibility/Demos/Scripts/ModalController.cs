#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using UnityEngine;

namespace Apple.Accessibility.Demo
{
    public class ModalController : MonoBehaviour
    {
        [SerializeField] RectTransform m_Panel;

        private void Start()
        {
            m_Panel.gameObject.SetActive(false);
        }

        public void ShowHideModalView(bool show)
        {
            m_Panel.gameObject.SetActive(show);
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
