using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPSUpgradeButton : UpgradeButton
{
    public int cpsUpgradeAmount;
    
    private void Start()
    {
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
            case 3:
                upgradeCost = gameStatus.cpsUpgrade3Cost;
                break;
            case 4:
                upgradeCost = gameStatus.cpsUpgrade4Cost;
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
            case 3:
                gameStatus.cpsUpgrade3Cost = upgradeCost;
                break;
            case 4:
                gameStatus.cpsUpgrade4Cost = upgradeCost;
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
            SaveUpgradeCost();
        }
    }
    private void IncreaseCPS() {
        gameStatus.cps += cpsUpgradeAmount;
    }
}
