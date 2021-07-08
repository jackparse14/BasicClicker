using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ClickerButton : MonoBehaviour
{
    GameSession gameStatus;
    private void Start() {
        gameStatus = FindObjectOfType<GameSession>();
    }
    public void HandleClick() { 
        gameStatus.score += gameStatus.clickAmount;
        gameStatus.UpdateScore();
    }
}
