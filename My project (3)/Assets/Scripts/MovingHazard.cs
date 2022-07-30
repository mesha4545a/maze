using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHazard : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private Vector3 startPoint;
    [SerializeField] private Vector3 endPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
    }
}
