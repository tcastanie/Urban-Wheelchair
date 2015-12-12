using UnityEngine;
using System.Collections;

public class trottoirOnClick : MonoBehaviour {

    void Start() {
        varGlobales.moneyEsc = 0;
    }

    void OnMouseDown() {
        if (!varGlobales.isCamFauteuil) {
            if (varGlobales.etatTrottoir == 0 || varGlobales.etatTrottoir == 1) {
                varGlobales.etatTrottoir += 1;
            }
            else {
                varGlobales.etatTrottoir = 0;
            }
            //Debug.Log(varGlobales.etatTrottoir);
        }
    }

    void OnMouseEnter() {
        if (varGlobales.etatJeu == 1 && !varGlobales.isCamFauteuil) {
            switch (varGlobales.etatTrottoir) {
                case 0:
                    varGlobales.currentExp = varGlobales.expTrottoirBad;
                    varGlobales.moneyTrottoir = varGlobales.prixTrottoirBad;
                    break;
                case 1:
                    varGlobales.currentExp = varGlobales.expTrottoirBien;
                    varGlobales.moneyTrottoir = varGlobales.prixTrottoirBien;
                    break;
                case 2:
                    varGlobales.currentExp = varGlobales.expTrottoirMieux;
                    varGlobales.moneyTrottoir = varGlobales.prixTrottoirMieux;
                    break;
            }
            //Debug.Log("rampe hovered");
        }
    }
}
