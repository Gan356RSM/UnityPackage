using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{   
    public int coins;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void collect_coin(){
        coins++;
        text.text = "Za Point: " + coins.ToString();
    }
}
