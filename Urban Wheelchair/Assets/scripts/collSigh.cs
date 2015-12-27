using UnityEngine;
using System.Collections;

public class collSigh : MonoBehaviour {

    public AudioSource sigh;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            sigh.Play();
        }
        //Destroy(other.gameObject);
    }
}
