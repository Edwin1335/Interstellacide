using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePause = false;
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            if(GamePause){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    public void Pause(){
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }

    void Resume(){
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }

    public void LoadMenu(){
        SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame(){
        Debug.Log("QUI!");
        Application.Quit();
    }
}
