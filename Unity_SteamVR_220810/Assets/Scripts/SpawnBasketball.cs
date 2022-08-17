using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Comibast
{
    public class SpawnBasketball : MonoBehaviour
    {
        [SerializeField, Header("籃球預製物")]
        private GameObject goBasketball;

        private UIElement btnSpawnBasketball;
        private Transform traPlayer;

        private void Awake()
        {
            traPlayer = GameObject.Find("Player").transform;
            btnSpawnBasketball = GameObject.Find("生成籃球").GetComponent<UIElement>();

            btnSpawnBasketball.onHandClick.AddListener((x) => 
            {
                Vector3 poseBall = traPlayer.position + traPlayer.forward * 1f + traPlayer.up;
                Instantiate(goBasketball, poseBall, Quaternion.identity);
            });
        }

    }
}

