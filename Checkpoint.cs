using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector3 lastCheckpoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lastCheckpoint = other.transform.position;
            SaveGame();
        }
    }
    void SaveGame()
    {
        PlayerPrefs.SetFloat("LastCheckpointX", lastCheckpoint.x);
        PlayerPrefs.SetFloat("LastCheckpointY", lastCheckpoint.y);
        PlayerPrefs.SetFloat("LastCheckpointZ", lastCheckpoint.z);
        PlayerPrefs.Save();
    }
    void LoadGame() 
    {
        float x = PlayerPrefs.GetFloat("LastCheckpointX", 0);
        float y = PlayerPrefs.GetFloat("LastCheckpointY", 0);
        float z = PlayerPrefs.GetFloat("LastCheckpointZ", 0);
        lastCheckpoint = new Vector3(x, y, z);
    }

}
