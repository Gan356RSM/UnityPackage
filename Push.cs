using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        other.GetComponent<Jump>().jumpStrength *= 5f;
    }

     void OnTriggerExit(Collider other) 
    {
        other.GetComponent<Jump>().jumpStrength /= 5f;
    }
}
