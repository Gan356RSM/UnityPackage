using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Transform>().position = GameObject.Find("Tp").transform.position + new Vector3(0, 2, 0);
    }
}
