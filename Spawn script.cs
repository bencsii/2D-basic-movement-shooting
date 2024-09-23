using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnscript : MonoBehaviour
{



    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private float _minSpawnTime;

    [SerializeField]
    private float _maxSpawnTime;

    
    private float _timeUntilSpawn;


    // Start is called before the first frame update
    void Awake()
    {
        TimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            TimeUntilSpawn();
        }

    }

 
    private void TimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minSpawnTime, _maxSpawnTime);
    }


 }
