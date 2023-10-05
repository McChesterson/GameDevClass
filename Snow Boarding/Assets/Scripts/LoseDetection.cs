using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseDetection : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem deathEffect;
    bool hasDied = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Ground" && hasDied == false)
        {
            deathEffect.transform.position = gameObject.transform.position + new Vector3 (0, -1f, 0);
            deathEffect.Play();
            Invoke("ReloadScene", loadDelay);
            hasDied = true;
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
