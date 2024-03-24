using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float maxVerticalVelocity = 5;
    public Vector2 jumpForce;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(jumpForce, ForceMode2D.Impulse);
        }
        if(rigidbody2D.velocity.y > maxVerticalVelocity)
        {
            rigidbody2D.velocity = new Vector2(0, maxVerticalVelocity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel("flapyybird");
    }
}
