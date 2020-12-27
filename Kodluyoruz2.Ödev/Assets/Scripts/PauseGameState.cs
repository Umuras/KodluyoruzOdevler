using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameState : MonoBehaviour, IState
{

    [SerializeField] private GameObject _pausePanel;
    public void Enter()
    {
        PanelActive();
    }

    public void Exit()
    {
        _pausePanel.SetActive(false);
        
    }


    private void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{

        //    FindObjectOfType<GameManager>().SetState(StateType.GameState);
        //}
    }

    public void PanelActive()
    {
        _pausePanel.SetActive(true);
    }

}
