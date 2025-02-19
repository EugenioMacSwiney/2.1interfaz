using System.Collections;
using System.Collections.Generic;       
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Coll)
    {
        Debug.Log("Collision Detected");
    }
}