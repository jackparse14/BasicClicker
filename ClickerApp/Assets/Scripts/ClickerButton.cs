using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ClickerButton : MonoBehaviour
{
    GameSession gameStatus;
    private int clickAmount = 1;

    private void Start()
    {
        gameStatus = FindObjectOfType<GameSession>();
    }
    public void HandleClick() { 
        gameStatus.score += clickAmount;
        UpdateScore();
    }

    private void UpdateScore() {
        gameStatus.scoreText.text = gameStatus.score.ToString();
    }
}
