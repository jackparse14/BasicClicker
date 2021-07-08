using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPSUpgradeButton : MonoBehaviour
{
    private int upgradeCost;
    public int cpsUpgradeAmount;
    public Text costText;
    public int buttonIndex;
    GameSession gameStatus;
    void Start() {
        gameStatus = FindObjectOfType<GameSession>();
        ChooseUpgradeCost();
        UpdateCost();
    }
    private void ChooseUpgradeCost() {
        switch (buttonIndex) {
            case 1:
                upgradeCost = gameStatus.cpsUpgrade1Cost;
                break;
            case 2:
                upgradeCost = gameStatus.cpsUpgrade2Cost;
                break;
        }
    }
    private void SaveUpgradeCost() {
        switch (buttonIndex) {
            case 1:
                gameStatus.cpsUpgrade1Cost = upgradeCost;
                break;
            case 2:
                gameStatus.cpsUpgrade2Cost = upgradeCost;
                break;
        }
    }
    public void HandleClick()
    {
        if (gameStatus.score >= upgradeCost)
        {
            IncreaseCPS();
            UpdateScore();
            IncreaseCost();
            UpdateCost();
        }
    }
    private void IncreaseCPS() {
        gameStatus.cps += cpsUpgradeAmount;
    }
    private void UpdateScore() {
        gameStatus.score -= upgradeCost;
        gameStatus.UpdateScore();
    }
    private void IncreaseCost() {
        upgradeCost *= 5;
    }
    private void UpdateCost() {
        costText.text = upgradeCost.ToString();
        SaveUpgradeCost();
    }
}
