using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollisionWithHand : MonoBehaviour
{
    public Rigidbody2D ball;
    public bool dead = false;
    float forceUpward = 5f;
    public TMP_Text SpeechUI;
    public string winText = "YOU WIN!!";
    public string loseText = "YOU LOSE! PRESS SPACE TO RESTART";
    public GameObject textObject;

    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (dead)
        {
            textObject.gameObject.SetActive(true);
            SpeechUI.text = loseText;
        }

        if(Input.GetKey(KeyCode.Space) && dead)
        {
            dead = false;
            textObject.gameObject.SetActive(false);

            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
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

        if(collision.gameObject.name == "stage")
        {
            dead = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "winingCollider")
        {
            textObject.gameObject.SetActive(true);
            SpeechUI.text = winText;
        }

    }

}
