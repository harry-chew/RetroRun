using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOtherCars : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;

    [SerializeField] private GameObject[] cars;

    [SerializeField] private float spawnTime = 1f;

    private void Start()
    {
        StartCoroutine(SpawnCars());
    }

    private IEnumerator SpawnCars()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            var randomCar = cars[UnityEngine.Random.Range(0, cars.Length)];
            var randomSpawnPoint = spawnPoints[UnityEngine.Random.Range(0, spawnPoints.Length)];
            Instantiate(randomCar, randomSpawnPoint.position, randomSpawnPoint.rotation);
        }
    }
    
}
