using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    //  Score Variables
    public int score;
    public Text scoreText;
    //  Click Upgrade Variables
    public int clickAmount = 1;
    public int clickUpgrade1Cost;
    public int clickUpgrade2Cost;
    // CPS Upgrade Variables
    public void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

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
    private void RestartGame() {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
