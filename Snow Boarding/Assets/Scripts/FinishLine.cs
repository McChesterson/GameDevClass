using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public AudioSource finishSound;
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        finishEffect.Play();
        finishSound.Play();
        Invoke("ReloadScene", loadDelay);
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
