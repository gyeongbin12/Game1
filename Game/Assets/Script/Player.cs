using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool active;
    float mouseX;

    [SerializeField] Camera[] personCamera;
    [SerializeField] float speed = 2.5f;
    [SerializeField] float mouseSpeed = 1.0f;

    CharacterController characterController;

    private void Start()
    {
        CameraChange();

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

        if (Input.GetKeyDown(KeyCode.Q))
        {
            CameraChange();
        }

    }

    private void CameraChange()
    {
        active = !active;
        personCamera[0].gameObject.SetActive(active);

        personCamera[1].gameObject.SetActive(!active);
    }
}
