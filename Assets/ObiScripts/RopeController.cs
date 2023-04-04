using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    [SerializeField] private Transform ropeStartPoint, ropeEndPoint;

    public void Init(Vector3 spawnPos)
    {
        ToggleRope(false);
        
        ropeStartPoint.position = spawnPos;
        ropeEndPoint.position = spawnPos;
        
    }

    private void ToggleRope(bool state)
    {
        gameObject.SetActive(state);

    }

    public void GetPulled(Vector3 pulledPos)
    {
        ropeEndPoint.position = pulledPos;
    }
}
