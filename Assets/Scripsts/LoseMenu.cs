using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject gameWinUI;

    private void OnEnable()
    {
        DamageableCharacter.OnPlayerDeath += gameLose;
    }
    private void OnDisable()
    {
        DamageableCharacter.OnPlayerDeath -= gameLose;
    }

    void gameLose()
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
