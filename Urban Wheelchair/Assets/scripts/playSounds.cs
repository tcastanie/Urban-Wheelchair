using UnityEngine;
using System.Collections;

public class playSounds : MonoBehaviour {


    public AudioSource soundStart;
	
	void Update () {
        if (varGlobales.isCamFauteuil) {
            if (Input.GetKeyDown("z")) {
                soundStart.Play();
            }
            if (Input.GetKeyUp("z")) {
                soundStart.Stop();
            }
        }
    }
}
