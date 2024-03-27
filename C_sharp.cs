using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_sharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] arr = {"Game", "Hi", "World"};
        Array(arr);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Array(string[] arr){

        for (int i = 0; i<arr.Length; i++){
            Debug.Log(arr[i]);
        
        }

    }
}
