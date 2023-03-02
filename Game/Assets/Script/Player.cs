using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float mouseX;
    [SerializeField] float speed = 2.5f;
    [SerializeField] float mouseSpeed = 1.0f;

    CharacterController characterController;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, 0, z);   
        
    
        characterController.Move(transform.TransformDirection(direction.normalized) * speed * Time.deltaTime);

        mouseX += Input.GetAxisRaw("Mouse X") * mouseSpeed;

        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }
}
