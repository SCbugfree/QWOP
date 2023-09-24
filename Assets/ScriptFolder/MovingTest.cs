using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTest : MonoBehaviour
{

    public Rigidbody2D mB;
    float moveSpeed = 3f;
    float moveH;
    float moveV;


    public Vector3 unitForce = new Vector3(5f, 0f, 0f);

    void Start()
    {
        mB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        mB.AddForce(new Vector2(moveH * moveSpeed,0f),ForceMode2D.Impulse);


    }
}
