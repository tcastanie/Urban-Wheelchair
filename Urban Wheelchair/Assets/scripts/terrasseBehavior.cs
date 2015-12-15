using UnityEngine;
using System.Collections;

public class terrasseBehavior : MonoBehaviour {

    public GameObject terrasseBad;
    public GameObject terrasseGood;
    int idLoc;

    GameObject tBadLoc;
    GameObject tGoodLoc;

    void Start() {
        varGlobales.etatTravaux = 0;
        idLoc = 0;

        //Les trois objets sont instanciés, seul le good est activé, les autres désactivés
        tBadLoc = (GameObject)Instantiate(terrasseBad, transform.position, transform.rotation);
        tGoodLoc = (GameObject)Instantiate(terrasseGood, transform.position, transform.rotation);
        tBadLoc.transform.parent = transform;
        tGoodLoc.transform.parent = transform;
        tBadLoc.SetActive(true);
        tGoodLoc.SetActive(false);
    }

    void Update() {
        if (idLoc != varGlobales.etatTerrasse) {
            switch (varGlobales.etatTerrasse) {
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
                    Debug.LogError("etatTerrasse :" + varGlobales.etatTerrasse);
                    break;
            }
        }
    }
}
