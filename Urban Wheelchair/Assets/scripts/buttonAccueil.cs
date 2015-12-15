using UnityEngine;
using System.Collections;

public class buttonAccueil : MonoBehaviour {

    public void loadLevel() {
        //Debug.Log("button clicked");
        varGlobales.isCamFauteuil = true;
        if (varGlobales.isFirstTime) {
            varGlobales.moneyStart = 0;
        } else {
            varGlobales.moneyStart = 30000;
        }
        varGlobales.etatJeu = 1;
        Application.LoadLevel("mainScene");
    }
}
