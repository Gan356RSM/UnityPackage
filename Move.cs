using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private int duration;
    public string dir;
    // Start is called before the first frame update
    void Start()
    {
        duration = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        duration++;
        if (duration <= 250) {
            dir = "right";
        } 
        else if (duration>= 500) 
        {
            duration = 500;
            dir = "left";
        }

        if (dir == "left") 
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (dir == "right")
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

     void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") 
        {
            other.transform.parent = this.transform;
        }
    }

     void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player") 
        {
            other.transform.parent = null;
        }
    }
}
