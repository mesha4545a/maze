using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colideing : MonoBehaviour
{

    [SerializeField] private int pllayerHealth = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("hazard"))
            pllayerHealth -= 1;


    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("hazard"))
            Debug.Log("I probably should not have touched that.");

    }
}
