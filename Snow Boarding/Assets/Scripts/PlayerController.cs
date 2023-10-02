using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torqueAmount = 1f;
    Rigidbody2D rb2D;
    CircleCollider2D circleColl;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        circleColl = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.AddTorque(-torqueAmount);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.AddTorque(torqueAmount);
        }
        //if (circleColl touches anything with the ground tag)
    }
}
