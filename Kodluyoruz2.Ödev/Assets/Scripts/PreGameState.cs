using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PreGameState : MonoBehaviour, IState
{
    [SerializeField] private GameObject _waitScreen;
    [SerializeField] private TextMeshProUGUI _waitText;
    private Coroutine _coroutine;
    private bool _isWaitingStart;


    public void Enter()
    {
        Debug.Log("Enter the Pre Game State");
        _waitScreen.SetActive(true);
        _isWaitingStart = true;
        _coroutine = StartCoroutine(WaitForStart());

        
    }

    public void Exit()
    {
        _isWaitingStart = false;

        StopCoroutine(_coroutine);

        _waitScreen.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            FindObjectOfType<GameManager>().SetState(StateType.GameState);
        }
    }


    private IEnumerator WaitForStart()
    {
        float t = 0;

        while (_isWaitingStart)
        {
            var val = Mathf.PingPong(t, 0.5f) + 0.5f;
            _waitText.color = new Color(1, 1, 1, val);
            yield return null;
            t += Time.deltaTime;
        }
    }
}
