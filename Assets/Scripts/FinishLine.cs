using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadTime = 2f;
    [SerializeField] ParticleSystem finishDetector;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            finishDetector.Play();
            Invoke("reloadScene", reloadTime);
            
        }
        
    }

    void reloadScene() {
        SceneManager.LoadScene(0);
    }
    
}
