using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private void Awake() {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            RestartGame();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void RestartGame()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
