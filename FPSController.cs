using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    public Camera PlayerCamera;
    public float MouseXSensitivity = 35;
    public float MouseYSensitivity = 30;
    public float WalkSpeed = 10;
    public float RunSpeed = 30;
    public float Jump = 10;
    private float Speed;
    public static bool isRunning = false;

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Speed = RunSpeed;
            isRunning = true;
        }
        else{
            Speed = WalkSpeed;
            isRunning = false;
        }

        transform.Translate(
            Time.deltaTime*Speed* Input.GetAxis("Horizontal"),Time.deltaTime*Jump* Input.GetAxis("Jump"),Time.deltaTime*Speed* Input.GetAxis("Vertical"));
            
        transform.Rotate(0,Time.deltaTime*MouseXSensitivity* Input.GetAxisRaw("Mouse X"),0);

        PlayerCamera.transform.Rotate(-Time.deltaTime*MouseYSensitivity* Input.GetAxisRaw("Mouse Y"),0,0);
    }
}
