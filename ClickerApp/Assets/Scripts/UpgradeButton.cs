using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Text costText;
    protected int upgradeCost;
    public int buttonIndex;
    protected GameSession gameStatus;
    protected void UpdateScore()
    {
        gameStatus.score -= upgradeCost;
        gameStatus.UpdateScore();
    }
    protected void IncreaseCost()
    {
        upgradeCost *= 5;
    }
    protected void UpdateCost()
    {
        costText.text = upgradeCost.ToString();
    }
}
