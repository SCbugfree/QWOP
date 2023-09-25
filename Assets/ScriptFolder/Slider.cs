using System.Collections;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Slider : MonoBehaviour
{
    public float constantSpeed = 100f;
    public Rigidbody2D slider;
    new Vector2 move = new Vector2(-1f,0f);

    void Start()
    {
        slider = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        slider.velocity = move * constantSpeed * Time.deltaTime;

    }

}
