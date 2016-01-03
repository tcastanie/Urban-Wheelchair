using UnityEngine;
using System.Collections;

public class justdoit : MonoBehaviour {

    public AudioSource doit;



    void OnTriggerEnter(Collider other) {
        if (varGlobales.isCamFauteuil) {
            doit.Play();
        }

    }
}
