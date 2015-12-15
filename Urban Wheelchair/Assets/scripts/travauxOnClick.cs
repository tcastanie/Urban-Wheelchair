using UnityEngine;
using System.Collections;

public class travauxOnClick : MonoBehaviour {

    void OnMouseDown() {
        if (!varGlobales.isCamFauteuil) {
            if (varGlobales.etatTravaux == 0) {
                varGlobales.etatTravaux += 1;
            }
            else {
                varGlobales.etatTravaux = 0;
            }
        }
    }

    void OnMouseEnter() {
        if (varGlobales.etatJeu == 1 && !varGlobales.isCamFauteuil) {
            switch (varGlobales.etatTravaux) {
                case 0:
                    varGlobales.currentExp = varGlobales.expTravauxBad;
                    varGlobales.moneyTravaux = varGlobales.prixTravauxBad;
                    break;
                case 1:
                    varGlobales.currentExp = varGlobales.expTravauxGood;
                    varGlobales.moneyTravaux = varGlobales.prixTravauxGood;
                    break;
            }
        }
    }
}
