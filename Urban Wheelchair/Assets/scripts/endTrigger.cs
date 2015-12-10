using UnityEngine;
using System.Collections;

public class endTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            //le joueur a terminé la course
            varGlobales.isFinished = true;
            varGlobales.etatJeu = 3;
            //Debug.Log("lignedarrive");
            Application.LoadLevel("recapScene");
        }
    }
}
