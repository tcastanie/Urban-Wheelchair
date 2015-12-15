using UnityEngine;
using System.Collections;

public class travauxBehavior : MonoBehaviour {

    public GameObject travauxBad;
    public GameObject travauxGood;
    int idLoc;

    GameObject tBadLoc;
    GameObject tGoodLoc;

    void Start() {
        varGlobales.etatTravaux = 0;
        idLoc = 0;

        //Les trois objets sont instanciés, seul le good est activé, les autres désactivés
        tBadLoc = (GameObject)Instantiate(travauxBad, transform.position, transform.rotation);
        tGoodLoc = (GameObject)Instantiate(travauxGood, transform.position, transform.rotation);
        tBadLoc.transform.parent = transform;
        tGoodLoc.transform.parent = transform;
        tBadLoc.SetActive(true);
        tGoodLoc.SetActive(false);
    }

    void Update() {
        if (idLoc != varGlobales.etatTravaux) {
            switch (varGlobales.etatTravaux) {
                // dès qu'on désactive un objet, on désactive les autres
                case 0:
                    tBadLoc.SetActive(true);
                    tGoodLoc.SetActive(false);
                    idLoc = 0;
                    break;
                case 1:
                    tBadLoc.SetActive(false);
                    tGoodLoc.SetActive(true);
                    idLoc = 1;
                    break;
                default:
                    Debug.LogError("etatTravaux :" + varGlobales.etatTravaux);
                    break;
            }
        }
    }
}
