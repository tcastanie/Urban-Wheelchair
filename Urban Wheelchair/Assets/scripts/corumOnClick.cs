using UnityEngine;
using System.Collections;

public class corumOnClick : MonoBehaviour {

    void OnMouseDown() {
        if (!varGlobales.isCamFauteuil) {
            if (varGlobales.etatCorum == 0) {
                varGlobales.etatCorum += 1;
            }
            else {
                varGlobales.etatCorum = 0;
            }
        }
    }

    void OnMouseEnter() {
        if (varGlobales.etatJeu == 1 && !varGlobales.isCamFauteuil) {
            switch (varGlobales.etatCorum) {
                case 0:
                    varGlobales.currentExp = varGlobales.expCorumBad;
                    varGlobales.moneyCorum = varGlobales.prixCorumBad;
                    break;
                case 1:
                    varGlobales.currentExp = varGlobales.expCorumGood;
                    varGlobales.moneyCorum = varGlobales.prixCorumGood;
                    break;
            }
        }
    }
}
