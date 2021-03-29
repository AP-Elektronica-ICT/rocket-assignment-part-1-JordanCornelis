using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject MainCanvas;
    public GameObject GameOver;
    private Health Healthplayer;
    public enum gamestates
    {
        Playing,
        GameOver
    }
    public gamestates gameState = gamestates.Playing;
    // Start is called before the first frame update
    void Start()
    {
        if (player==null)
        {
            player = GameObject.FindWithTag("Player");
        }
        Healthplayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case gamestates.Playing:
                if (!Healthplayer.isAlive)
                {
                    gameState = gamestates.GameOver;
                    MainCanvas.SetActive(false);
                    GameOver.SetActive(true);

                }
                break;
        }
    }
}
