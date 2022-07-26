using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsColector : MonoBehaviour
{
    private int money = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            money += 1;
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I have this mutch mony: " + money);
    }
}
