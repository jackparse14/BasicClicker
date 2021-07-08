using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerButton : MonoBehaviour
{
    GameSession gameStatus;
    public Text clickAmountText;
    private void Start() {
        gameStatus = FindObjectOfType<GameSession>();
        UpdateClickAmount();
    }
    public void HandleClick() { 
        gameStatus.score += gameStatus.clickAmount;
        gameStatus.UpdateScoreText();
    }
    private void UpdateClickAmount() {
        clickAmountText.text = "+" + gameStatus.clickAmount.ToString();
    }
}
