using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseDetection : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem deathEffect;
    bool hasDied = false;
    public AudioSource deathSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Ground" && !hasDied)
        {
            deathEffect.transform.position = gameObject.transform.position;
            deathEffect.Play();
            deathSound.transform.position = gameObject.transform.position;
            deathSound.Play();
            gameObject.SetActive(false);
            Invoke("ReloadScene", loadDelay);
            hasDied = true;
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
