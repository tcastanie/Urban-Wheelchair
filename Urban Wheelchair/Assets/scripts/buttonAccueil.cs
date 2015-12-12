using UnityEngine;
using System.Collections;

public class buttonAccueil : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {

    }

    public void loadLevel() {
        //Debug.Log("button clicked");
        varGlobales.isCamFauteuil = true;
        if (varGlobales.isFirstTime) {
            varGlobales.moneyStart = 0;
        } else {
            varGlobales.moneyStart = 80000;
        }
        varGlobales.etatJeu = 1;
        Application.LoadLevel("mainScene");
    }
}
