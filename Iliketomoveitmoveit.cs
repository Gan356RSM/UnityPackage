using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iliketomoveitmoveit : MonoBehaviour
{
    public float speed;
    private int counter;
    private string direction;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        direction = "up";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;
        if (counter == 125) {
            direction = "right";
        } else if (counter == 250) {
            direction = "down";
        } else if (counter == 375) {
            direction = "left";
        } else if (counter >= 500) {
            counter = 0;
            direction = "up";
        }
        if (direction == "up") {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        } else if (direction == "right") {
            transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
        } else if (direction == "down") {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        } else if (direction == "left") {
            transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;
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
