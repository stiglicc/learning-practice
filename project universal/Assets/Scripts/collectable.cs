using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour {
    public static int totalCoins = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            AddCoin();
            Destroy(gameObject);
        }
        Debug.Log("You now have " + collectable.totalCoins + " dragon balls.");
    }
    private void AddCoin() {
        totalCoins++;
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
