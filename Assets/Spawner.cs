using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _timeBetweenSpawn;

    private float _elapserTime = 0;

    private void Update()
    {
        _elapserTime += Time.deltaTime;

        if (_elapserTime >= _timeBetweenSpawn)
        {
            _elapserTime = 0;

            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemy, _spawnPoints[spawnPointNumber]);
        }
    }
}
