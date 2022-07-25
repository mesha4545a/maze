using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speed = 10;
    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float VerticalInput = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        Vector3 movement = new Vector3(horizontalInput, 0, VerticalInput);
        if(movement.magnitude != 0) 
            characterController.Move(movement);
        
    }
}
