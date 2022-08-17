using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

namespace Comibast
{
    /// <summary>
    /// ��������G���s�P���}�C��
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        private UIElement uiReplay;
        private UIElement uiQuit;
        private string nameSceneToReplay = "�x�y��";

        private void Awake()
        {
            uiReplay = GameObject.Find("���s�C��").GetComponent<UIElement>();
            uiQuit = GameObject.Find("���}�C��").GetComponent<UIElement>();

            uiReplay.onHandClick.AddListener((UnityAction) => { SceneManager.LoadScene(nameSceneToReplay); });
            uiQuit.onHandClick.AddListener((UnityAction) => { Application.Quit(); });
        }
    }

}
