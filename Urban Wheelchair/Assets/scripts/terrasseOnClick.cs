using UnityEngine;
using System.Collections;

public class terrasseOnClick : MonoBehaviour {

    void OnMouseDown() {
        if (!varGlobales.isCamFauteuil) {
            if (varGlobales.etatTerrasse == 0) {
                varGlobales.etatTerrasse += 1;
            }
            else {
                varGlobales.etatTerrasse = 0;
            }
        }
    }

    void OnMouseEnter() {
        if (varGlobales.etatJeu == 1 && !varGlobales.isCamFauteuil) {
            switch (varGlobales.etatTerrasse) {
                case 0:
                    varGlobales.currentExp = varGlobales.expTerrasseBad;
                    varGlobales.moneyTerrasse = varGlobales.prixTerrasseBad;
                    break;
                case 1:
                    varGlobales.currentExp = varGlobales.expTerrasseGood;
                    varGlobales.moneyTerrasse = varGlobales.prixTerrasseGood;
                    break;
            }
        }
    }
}
