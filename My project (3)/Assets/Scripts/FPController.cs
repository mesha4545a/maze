using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPController : MonoBehaviour
{
    [SerializeField] private Transform cameraTarget;
    private Camera mainCamera;





    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

        // the mous loced in the midel of screen and invesible
        /* Cursor.lockState = CursorLockMode.Locked;
         Cursor.visible = false;*/
    }
    private void Update()
    {

        //the mouse movement
        Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));


        float yRotation = transform.rotation.eulerAngles.y + mouseInput.x;

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, yRotation, transform.rotation.eulerAngles.z);


        //Inverting the Mouse


    }

    // Update is called once per frame
    void LateUpdate()
    {
        mainCamera.transform.position = cameraTarget.position;
        mainCamera.transform.rotation = cameraTarget.rotation;

    }
}