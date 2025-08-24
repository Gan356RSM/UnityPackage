using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C0RRUPTNATURE : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        GameObject coin = GameObject.Find("Coin");
        GameObject ZaCube = GameObject.Find("ZaCube");
        
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(coin);
            Destroy(ZaCube);
        }
    }
}
