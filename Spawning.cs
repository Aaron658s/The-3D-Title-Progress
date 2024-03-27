using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject charPrefab;
    public float respawnDelay = 2f;
    // Start is called before the first frame update
    void Start()
    {
        charPrefab = GameObject.FindGameObjectWithTag("Spawning");
       
    }
    void FixedUpdate(){
        Time.fixedDeltaTime = 0.0333f;
         SpawnCharacter();
    }
    public void Respawn()
    {
        StartCoroutine(RespawnAfterDelay());
    }
    void SpawnCharacter()
    { 
        if(charPrefab != null){
             Instantiate(charPrefab, transform.position, transform.rotation);

        }
        else{
            Debug.Log("empty");
        }
       
    }

    IEnumerator RespawnAfterDelay() 
    {
        yield return new WaitForSeconds(respawnDelay);
        SpawnCharacter();
    }
}
