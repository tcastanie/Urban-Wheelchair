using UnityEngine;
using System.Collections;

public class trottoirBehavior : MonoBehaviour {

    public GameObject trottoirBad;
    public GameObject trottoirBien;
    public GameObject trottoirMieux;
    int idLoc;

    GameObject badLoc;
    GameObject bienLoc;
    GameObject mieuxLoc;

    void Start() {
        varGlobales.etatTrottoir = 0;
        idLoc = 0;

        //Les trois objets sont instanciés, seul le bad est activé, les autres désactivés
        badLoc = (GameObject)Instantiate(trottoirBad, transform.position, transform.rotation);
        bienLoc = (GameObject)Instantiate(trottoirBien, transform.position, transform.rotation);
        mieuxLoc = (GameObject)Instantiate(trottoirMieux, transform.position, transform.rotation);
        badLoc.transform.parent = transform;
        bienLoc.transform.parent = transform;
        mieuxLoc.transform.parent = transform;
        badLoc.SetActive(true);
        bienLoc.SetActive(false);
        mieuxLoc.SetActive(false);
    }

    void Update() {
        if (idLoc != varGlobales.etatTrottoir) {
            switch (varGlobales.etatTrottoir) {
                // dès qu'on désactive un objet, on désactive les autres
                case 0:
                    badLoc.SetActive(true);
                    bienLoc.SetActive(false);
                    mieuxLoc.SetActive(false);
                    idLoc = 0;
                    break;
                case 1:
                    badLoc.SetActive(false);
                    bienLoc.SetActive(true);
                    mieuxLoc.SetActive(false);
                    idLoc = 1;
                    break;
                case 2:
                    badLoc.SetActive(false);
                    bienLoc.SetActive(false);
                    mieuxLoc.SetActive(true);
                    idLoc = 2;
                    break;
                default:
                    Debug.LogError("etatTrottoir :" + varGlobales.etatTrottoir);
                    break;
            }
        }
    }
}
