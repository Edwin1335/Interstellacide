using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu_MainMenu : MonoBehaviour
{
    public void PlayGame(){
        int scene = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    public void QuitGame(){
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

