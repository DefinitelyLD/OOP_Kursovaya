using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //перевірка натискання клавіши ESC
        {
            if (GameIsPaused){
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume() //возобновляємо гру
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() //ставимо на паузу
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Restart() //рестарт
    {
        Debug.Log("Restarting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Quit() //вихід з гри
    {
        
        Debug.Log("Quitting");
        Application.Quit();
    }
}
