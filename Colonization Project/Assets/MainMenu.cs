using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public AudioMixer audioMixer;
    public Slider slider;

	public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    public void Mute(bool volumeOff)
    {
        if (!volumeOff)
        {
            audioMixer.SetFloat("volume", 0);
            slider.value = 0;
        }
        else
        {
            audioMixer.SetFloat("volume", -80);
            slider.value = -80;
        }
    }
}
