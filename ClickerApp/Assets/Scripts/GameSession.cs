using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    private bool oneSecPassed = true;
    //  Score Variables
    public int score;
    public Text scoreText;
    public Text cpsText;
    //  Click Upgrade Variables
    public int clickAmount;
    public int clickUpgrade1Cost;
    public int clickUpgrade2Cost;
    public int clickUpgrade3Cost;
    public int clickUpgrade4Cost;
    // CPS Upgrade Variables
    public int cps;
    public int cpsUpgrade1Cost;
    public int cpsUpgrade2Cost;
    public int cpsUpgrade3Cost;
    public int cpsUpgrade4Cost;
    public void UpdateScoreText() {
        scoreText.text = score.ToString();
    }
    public void UpdateCPSText() {
        if (cps == 1) {
            cpsText.text = cps.ToString() + " Click Per Second";
        } else {
            cpsText.text = cps.ToString() + " Clicks Per Second";
        }
        
    }
    private void Update() {
        if (oneSecPassed) {
            oneSecPassed = false;
            StartCoroutine(AddCPS());
        }
    }
    IEnumerator AddCPS() {
        yield return new WaitForSeconds(1);
        score += cps;
        UpdateScoreText();
        oneSecPassed = true;
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
