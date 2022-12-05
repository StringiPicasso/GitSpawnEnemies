using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private  Enemy enemy;

    private void Start()
    {
        StartCoroutine(Fade());
    }

    private IEnumerator Fade()
    {
        while (true)
        {
            float _timeBetweenSpawn = 2f;
            var timeBetweenSpawn = new WaitForSeconds(_timeBetweenSpawn);
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(enemy, _spawnPoints[spawnPointNumber]);
        
            yield return timeBetweenSpawn;
        }
    }
}
