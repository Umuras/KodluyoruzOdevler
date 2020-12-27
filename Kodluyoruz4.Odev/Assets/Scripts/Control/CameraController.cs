using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    Vector3 _offset;
    void Start()
    {
        _offset = transform.position - _player.transform.position;
    }

    
    void Update()
    {
        transform.position = _offset + _player.transform.position;
    }
}
