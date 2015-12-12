using UnityEngine;
using System.Collections;

public class rampeOnClick : MonoBehaviour {

    void OnMouseDown() {
        if (!varGlobales.isCamFauteuil) {
            if (varGlobales.etatRampe == 0 || varGlobales.etatRampe == 1) {
                varGlobales.etatRampe += 1;
            }
            else {
                varGlobales.etatRampe = 0;
            }
            //Debug.Log(varGlobales.etatRampe);
        }
    }

    void OnMouseEnter() {
        if(varGlobales.etatJeu == 1 && !varGlobales.isCamFauteuil) {
            switch (varGlobales.etatRampe) {
                case 0:
                    varGlobales.currentExp = varGlobales.expEscalier;
                    varGlobales.moneyEsc = varGlobales.prixEsc;
                    break;
                case 1:
                    varGlobales.currentExp = varGlobales.expRampe;
                    varGlobales.moneyEsc = varGlobales.prixRampe;
                    break;
                case 2:
                    varGlobales.currentExp = varGlobales.expRampeEsc;
                    varGlobales.moneyEsc = varGlobales.prixRampeEsc;
                    break;
            }
            //Debug.Log("rampe hovered");
        }
    }
}
