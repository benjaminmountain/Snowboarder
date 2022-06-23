using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadTime = 0.5f;
    [SerializeField] ParticleSystem crashDetector;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Ground") {
            crashDetector.Play();
           Invoke("reloadScene", reloadTime);
        }
    }

    void reloadScene() {
        SceneManager.LoadScene(0);
    }
}
