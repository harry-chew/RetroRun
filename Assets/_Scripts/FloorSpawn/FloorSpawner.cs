using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> floorPieces = new List<GameObject>();
    [SerializeField] private GameObject floorPiece;
    [SerializeField] private Transform environment;

    //singleton
    public static FloorSpawner Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        InitialiseFloor();
    }

    private void InitialiseFloor()
    {
        GameObject floorPieceSpawned = Instantiate(floorPiece, new Vector3(floorPiece.transform.position.x, floorPiece.transform.position.y, floorPiece.transform.position.z + 10f), Quaternion.identity, environment);
        floorPieces.Add(floorPieceSpawned);

        for (int i = 0; i < 5; i++)
        {
            floorPieceSpawned = Instantiate(floorPiece, new Vector3(floorPieceSpawned.transform.position.x, floorPieceSpawned.transform.position.y, floorPieceSpawned.transform.position.z + 10f), Quaternion.identity, environment);
            floorPieces.Add(floorPieceSpawned);
        }
    }

    public void SpawnFloorInFrontOfPlayer()
    {
        Transform pieceToSpawnTransform = floorPieces[floorPieces.Count - 1].transform;
        GameObject floorPieceSpawned = Instantiate(floorPiece, new Vector3(floorPiece.transform.position.x, floorPiece.transform.position.y, pieceToSpawnTransform.position.z + 10f), Quaternion.identity, environment);
        floorPieces.Add(floorPieceSpawned);
    }
}
