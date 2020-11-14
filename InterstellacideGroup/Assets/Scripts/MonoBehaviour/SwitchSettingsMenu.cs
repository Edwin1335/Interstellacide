using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSettingsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void SwitchToSettings(){
        Debug.Log("SETTINGS");
        SceneManager.LoadScene(4);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
