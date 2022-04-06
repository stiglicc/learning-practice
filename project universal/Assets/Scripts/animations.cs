using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour
{
    [SerializeField] Animator anima;
    
    void Start()
    {
        anima = GetComponent<Animator>();  
    }

    
    void Update()
    {
        walkForward();
        walkBack();
        walkRight();
        walkLeft();
        runForward();
    }
    private void walkForward() {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            anima.SetBool("isWalkingForward", true);
        }
        else anima.SetBool("isWalkingForward", false);
    }
    private void walkBack() {
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            anima.SetBool("isWalkingBack", true);
        }
        else anima.SetBool("isWalkingBack", false);
    }
    private void walkRight() {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            anima.SetBool("isWalkingRight", true);
        } else anima.SetBool("isWalkingRight", false);
    }
    private void walkLeft() {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            anima.SetBool("isWalkingLeft", true);
        } else anima.SetBool("isWalkingLeft", false);
    }
    private void runForward() {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)) {
            anima.SetBool("isRunPressed", true);
        } else anima.SetBool("isRunPressed", false);
    }
}
