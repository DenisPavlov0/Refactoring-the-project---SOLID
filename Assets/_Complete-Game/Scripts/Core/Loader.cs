using UnityEngine;
using System.Collections;

namespace Completed
{
    public class Loader : MonoBehaviour
    {
        [SerializeField] private GameObject gameManager; 
        [SerializeField] private GameObject soundManager;
        [SerializeField] private Player player;


        private void Awake()
        {
            if (GameManager.instance == null)
                Instantiate(gameManager);
            if (SoundManager.instance == null)
                Instantiate(soundManager);
#if UNITY_STANDALONE || UNITY_WEBPLAYER
            player.SetInput(new KeyboardInput());
#elif UNITY_IOS || UNITY_ANDROID || UNITY_IPHONE
            player.SetInput(new TouchInput());
#endif
        }
    }
}