using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadHomeScene() {
        SceneManager.LoadScene("HomeScene");
    }
    public void LoadCPSScene() {
        SceneManager.LoadScene("CPSScene");
    }
    public void LoadClickScene() {
        SceneManager.LoadScene("ClickScene");
    }
}
