using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuControl : MonoBehaviour
{
    public GameObject continueButton;
    public GameObject winScreen;
    public GameObject IntroPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetPauseMenu();
        IntroductionPanel();
    }

    public void GetPauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
        }
    }

    public void ContinueButton()
    {
        if (continueButton)
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }

    public void IntroductionPanel()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IntroPanel.SetActive(false);
        }
    }

}
