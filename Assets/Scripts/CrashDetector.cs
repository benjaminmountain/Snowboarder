using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadTime = 0.5f;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Ground") {
           Invoke("reloadScene", reloadTime);
        }
    }

    void reloadScene() {
        SceneManager.LoadScene(0);
    }
}
