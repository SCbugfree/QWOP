using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithHand : MonoBehaviour
{
    public Rigidbody2D ball;
    float forceUpward = 50f;

    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "hand")
        {
            ball.AddForce(transform.up * forceUpward, ForceMode2D.Impulse);
            Debug.Log(forceUpward);
            //textObject.SetActive(true);
            //speechUI.text = eatAppleDialogue;
            //InvokeRepeating("HidePanel", 0.8f, 0.0f);
        }
    }
}
