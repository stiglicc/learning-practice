using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    void Start()
    {
        
    }
    void Update() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(moveHorizontal, 0, moveVertical);
        moveDirection.Normalize();
        transform.Translate(moveDirection * movementSpeed * Time.deltaTime);
    }
}
