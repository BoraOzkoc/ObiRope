using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSpawner : MonoBehaviour
{
    [SerializeField] private RopeController ropePrefab;

    private void Start()
    {
        SpawnRope(Vector3.zero);
    }

    public void SpawnRope(Vector3 pos)
    {
       RopeController spawnnedRopeController = Instantiate(ropePrefab);
       
       spawnnedRopeController.Init(pos, true);
    }
}
