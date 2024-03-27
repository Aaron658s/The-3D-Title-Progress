using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachCheckPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You have reached a Checkpoint!");
        }
    }
}
