using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSpawner : MonoBehaviour
{
    [SerializeField] private RopeController ropePrefab;

    public void SpawnRope(Vector3 pos)
    {
       RopeController spawnnedRopeController = Instantiate(ropePrefab);
       
       spawnnedRopeController.Init(pos);
    }
}
