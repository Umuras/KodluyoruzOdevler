using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour, IState
{
    private PauseGameState _pausePanel = new PauseGameState();
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private PlayerController _player;
    [SerializeField] private DropController _dropGameobjects;
    public void Enter()
    {
        _pauseButton.SetActive(true);
        _player.enabled = true;
        _dropGameobjects.enabled = true;
    }

    public void Exit()
    {
        _player.enabled = false;
        _dropGameobjects.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PausePanel();
    }

    public void PausePanel()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _pauseButton.GetComponent<GameManager>().SetState(StateType.PauseGameState);
            _pausePanel.PanelActive();
        }
    }
}
