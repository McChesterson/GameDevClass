using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailEffect : MonoBehaviour
{
    public ParticleSystem trailEffect;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            trailEffect.Play();
            Debug.Log("trailStarted");
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            trailEffect.Stop();
            Debug.Log("trailEnded");
        }
    }
}
