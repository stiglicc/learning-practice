using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float runningSpeed;
    [SerializeField] float normalSpeed;

    [SerializeField] float mouseSensitivity;

    void Start()
    {
        
    }
    void Update() 
    {
        Move();
        MouseRotation();
        runForward();
    }
    private void runForward()
    {
        if (Input.GetKey(KeyCode.LeftShift)) {
            movementSpeed = runningSpeed;
        } else movementSpeed = normalSpeed; 
    }
    private void Move() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(moveHorizontal, 0, moveVertical);
        moveDirection.Normalize();
        transform.Translate(moveDirection * movementSpeed * Time.deltaTime);
    }
    private void MouseRotation() {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * mouseSensitivity);
        //add vertical mouse rotation
    }
}
