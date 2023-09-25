using System.Collections;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public Rigidbody2D slider;
    public Vector2 leftForce = new Vector2(-10f,0f);

    void FixedUpdate()
    {
        slider.AddForce(leftForce,ForceMode2D.Impulse);
    }
}
