using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _timeBetweenSpawn;

    private void Start()
    {
        StartCoroutine(AppearEnemy());
    }

    private IEnumerator AppearEnemy()
    {
        var timeBetweenSpawn = new WaitForSeconds(_timeBetweenSpawn);
        
        while (true)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemy, _spawnPoints[spawnPointNumber]);
        
            yield return timeBetweenSpawn;
        }
    }
}
