using UnityEngine;
using System.Collections;

public class trottoirOnClick : MonoBehaviour {

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
}
