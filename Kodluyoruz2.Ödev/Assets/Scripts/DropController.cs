using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropController : MonoBehaviour
{
    [SerializeField] private GameObject[] _dropGameobjects;

    private Coroutine _dropCoroutine;
    private void OnEnable()
    {
        _dropCoroutine = StartCoroutine(SpawnDrop(1.5f));
    }


    private void OnDisable()
    {
        StopCoroutine(_dropCoroutine);
    }


    private IEnumerator SpawnDrop(float spawnPeriod)
    {
        WaitForSeconds wait = new WaitForSeconds(spawnPeriod);

        while (true)
        {
            var gmo = Instantiate(_dropGameobjects[Random.Range(0,5)], GetRandomSpawnPosition(), Quaternion.identity);
            yield return wait;


        }
    }


    private Vector3 GetRandomSpawnPosition()
    {
        return new Vector3(Random.Range(-2.3f, 2.3f), 8.9f, 0);
    }

}


