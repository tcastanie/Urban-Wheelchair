using UnityEngine;
using System.Collections;

public class corumBehavior : MonoBehaviour {

    public GameObject corumBad;
    public GameObject corumGood;
    int idLoc;

    GameObject cBadLoc;
    GameObject cGoodLoc;

    void Start() {
        varGlobales.etatCorum = 0;
        idLoc = 0;

        //Les trois objets sont instanciés, seul le good est activé, les autres désactivés
        cBadLoc = (GameObject)Instantiate(corumBad, transform.position, transform.rotation);
        cGoodLoc = (GameObject)Instantiate(corumGood, transform.position, transform.rotation);
        cBadLoc.transform.parent = transform;
        cGoodLoc.transform.parent = transform;
        cBadLoc.SetActive(true);
        cGoodLoc.SetActive(false);
    }

    void Update() {
        if (idLoc != varGlobales.etatCorum) {
            switch (varGlobales.etatCorum) {
                // dès qu'on désactive un objet, on désactive les autres
                case 0:
                    cBadLoc.SetActive(true);
                    cGoodLoc.SetActive(false);
                    idLoc = 0;
                    break;
                case 1:
                    cBadLoc.SetActive(false);
                    cGoodLoc.SetActive(true);
                    idLoc = 1;
                    break;
                default:
                    Debug.LogError("etatCorum :" + varGlobales.etatCorum);
                    break;
            }
        }
    }
}
