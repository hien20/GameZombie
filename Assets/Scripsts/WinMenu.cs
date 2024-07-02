using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject gameWinUI;

    private void OnEnable()
    {
        Boss.OnBossDeath += gameWin;
    }
    private void OnDisable()
    {
        Boss.OnBossDeath -= gameWin;
    }

    void gameWin()
    {
        gameWinUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Outside");
        Time.timeScale = 1;
    }
}
