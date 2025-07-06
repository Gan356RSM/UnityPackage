using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 currentCheckpoint;
    void Start()
    {
        currentCheckpoint = GameObject.Find("Checkpoint").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        other.GetComponent<FirstPersonMovement>().currentCheckpoint;
    }
}
