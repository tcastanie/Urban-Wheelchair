using UnityEngine;
using System.Collections;

public class colliderCage : MonoBehaviour {
    
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = new Vector3(122, 13, -7);
        }
        //Destroy(other.gameObject);
    }
}
