using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgradeButton : UpgradeButton
{
    public int upgradeAmount;
    private void Start()
    {
        gameStatus = FindObjectOfType<GameSession>();
        ChooseUpgradeCost();
        UpdateCost();
    }

    private void ChooseUpgradeCost() {
        switch (buttonIndex) {
            case 1:
                upgradeCost = gameStatus.clickUpgrade1Cost;
                break;
            case 2:
                upgradeCost = gameStatus.clickUpgrade2Cost;
                break;
        }
    }
    private void SaveUpgradeCost() {
        switch (buttonIndex) {
            case 1:
                gameStatus.clickUpgrade1Cost = upgradeCost;
                break;
            case 2:
                gameStatus.clickUpgrade2Cost = upgradeCost;
                break;
        }
    }
    public void HandleClick() {
        if (gameStatus.score >= upgradeCost) {
            IncreaseClickAmount();
            UpdateScore();
            IncreaseCost();
            UpdateCost();
            SaveUpgradeCost();
        }
    }
    private void IncreaseClickAmount() {
        gameStatus.clickAmount += upgradeAmount;
    }
    
}
