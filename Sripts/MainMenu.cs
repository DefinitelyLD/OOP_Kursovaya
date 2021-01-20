using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

  
    public void PlayGame () //загружаємо рівень
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame() //виходимо з гри
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void SetVolume (float volume) //змінюємо гучність
    {
        
        audioMixer.SetFloat("volume", volume);
    }
}
