using UnityEngine;
using System.Collections;

public class rampeBehavior : MonoBehaviour {

    public GameObject escalier;
    public GameObject rampe;
    public GameObject rampeEscalier;
    int idLoc;

    GameObject escalierLoc;
    GameObject rampeLoc;
    GameObject rampeEscLoc;

    void Start() {
        varGlobales.etatRampe = 0;
        idLoc = 0;

        //Les trois objets sont instanciés, seul l'escalier est activé, les autres désactivés
        escalierLoc = (GameObject)Instantiate(escalier, transform.position, transform.rotation);
        rampeLoc = (GameObject)Instantiate(rampe, transform.position, transform.rotation);
        rampeEscLoc = (GameObject)Instantiate(rampeEscalier, transform.position, transform.rotation);
        escalierLoc.transform.parent = transform;
        rampeLoc.transform.parent = transform;
        rampeEscLoc.transform.parent = transform;
        escalierLoc.SetActive(true);
        rampeLoc.SetActive(false);
        rampeEscLoc.SetActive(false);
    }

    void Update() {
        if (idLoc != varGlobales.etatRampe) {
            switch (varGlobales.etatRampe) {
                // dès qu'on désactive un objet, on désactive les autres
                case 0:
                    //Instantiate(escalier, transform.position, transform.rotation);
                    //Destroy(rampe);
                    //Destroy(rampeEscalier);
                    escalierLoc.SetActive(true);
                    rampeLoc.SetActive(false);
                    rampeEscLoc.SetActive(false);
                    idLoc = 0;
                    break;
                case 1:
                    //Destroy(GameObject.Find("escalier(Clone)"));
                    //Destroy(GameObject.Find("rampeEscalier(Clone)"));
                    //GameObject rampeLoc = (GameObject)Instantiate(rampe, transform.position, transform.rotation);
                    //rampeLoc.transform.parent = transform;
                    //rampeLoc.SetActive(true);
                    escalierLoc.SetActive(false);
                    rampeLoc.SetActive(true);
                    rampeEscLoc.SetActive(false);
                    idLoc = 1;
                    break;
                case 2:
                    //Instantiate(rampeEscalier, transform.position, transform.rotation);
                    //Destroy(escalier);
                    //Destroy(rampe);
                    escalierLoc.SetActive(false);
                    rampeLoc.SetActive(false);
                    rampeEscLoc.SetActive(true);
                    idLoc = 2;
                    break;
                default:
                    Debug.LogError("etatRampe :" + varGlobales.etatRampe);
                    break;
            }
        }
    }
}
