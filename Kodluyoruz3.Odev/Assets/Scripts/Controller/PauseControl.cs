using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     
    void Update()
    {
        
    }

    public void ResumeButton()
    {
        SceneManager.UnloadSceneAsync("PauseMenu");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
