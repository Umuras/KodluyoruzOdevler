using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    [SerializeField] private List<CheckpointController> checkPoints = new List<CheckpointController>();
    private int _lastPassedCheckPoint;
    
    void Start()
    {
        for (int i = 0; i < checkPoints.Count; i++)
        {
            checkPoints[i].checkPointManager = this;
            if (i == 0)
            {
                checkPoints[i].isMyTurn = true;
            }
        }
    }

    public void SetLastPassedCheckPoint(int id)
    {
        _lastPassedCheckPoint = id;
        GameManager.Instance().ChangeCheckPoint(_lastPassedCheckPoint);

        if (checkPoints.Count - 1 > id)
        {
            checkPoints[id + 1].isMyTurn = true;
        }
        else
        {
            Debug.Log("Level Complete");
        }
        
    }

    
    void Update()
    {
        
    }
}
