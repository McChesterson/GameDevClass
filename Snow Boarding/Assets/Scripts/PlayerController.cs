using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torqueAmount = 1f;
    public float boostSpeed = 100f;
    public float baseSpeed = 20f;

    Rigidbody2D rb2D;
    SurfaceEffector2D sE2D;
    CircleCollider2D circleColl;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        circleColl = GetComponent<CircleCollider2D>();
        sE2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.AddTorque(-torqueAmount);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.AddTorque(torqueAmount);
        }
    }
    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            sE2D.speed = boostSpeed;
        }
        else
        {
            sE2D.speed = baseSpeed;
        }
    }
}
