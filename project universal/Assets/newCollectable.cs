using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCollectable : MonoBehaviour
{
    [SerializeField] GameObject collectableToSpawn;
    [SerializeField] float spawnDelay;
    [SerializeField] float destroyDelay;

    [SerializeField] ParticleSystem particles;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            Invoke("spawnCollectable", spawnDelay);
            Invoke("destroyObject", destroyDelay);
            
            Debug.Log("collectable will spawn soon");
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void spawnCollectable() {
        Vector3 spawnPosition = new Vector3(12, 10, 15);
        Instantiate(collectableToSpawn,spawnPosition,Quaternion.identity);
    }
    private void destroyObject() {
        Destroy(gameObject);
    }
   
    
}
