using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class moveController : MonoBehaviour
{
    public float speed = -2;
    public float XspawnPosition;
    public float XDespawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
            transform.position.y, transform.position.z);
        if(transform.position.x < XDespawnPosition)
        {
            transform.position = new Vector3(XspawnPosition, transform.position.y, transform.position.z);
        }
    }
}
