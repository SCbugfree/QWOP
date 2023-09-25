using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTest : MonoBehaviour
{

    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    float moveSpeedH = 40f;
    float moveSpeedV = 50f;
    float moveSpeedH2 = 50f;
    float moveH;
    float moveV;
    

    //public Vector3 unitForce = new Vector3(5f, 0f, 0f);

    void Start()
    {
        rb1 = GetComponent<Rigidbody2D>();
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate(){

        rb1.AddForce(new Vector2(moveSpeedH * moveH,0f),ForceMode2D.Impulse);
        rb1.AddForce(new Vector2(moveSpeedV * moveV, 0f), ForceMode2D.Impulse);

        if (Input.GetKey(KeyCode.O))
        {
            rb2.AddForce(new Vector2(-moveSpeedH2, 0f), ForceMode2D.Impulse);

        }
        else if (Input.GetKey(KeyCode.P))
        {
            rb2.AddForce(new Vector2(moveSpeedH2, 0f), ForceMode2D.Impulse);
        }
    }

}
