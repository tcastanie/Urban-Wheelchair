using UnityEngine;
using System.Collections;


public class changeCamera : MonoBehaviour {
	
	public Camera cameraFauteuil;
	public Camera cameraPlan;

    public AudioSource bipGood;
    public AudioSource bipBad;

    bool porte;

	// Use this for initialization
	void Start () {
        varGlobales.etatJeu = 1;
		cameraFauteuil.enabled = varGlobales.isCamFauteuil;
		cameraPlan.enabled = !varGlobales.isCamFauteuil;

        Cursor.visible = !cameraFauteuil.enabled;

        GetComponent<CharacterController>().enabled = varGlobales.isCamFauteuil;
        GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = varGlobales.isCamFauteuil;
        GetComponent<AudioSource>().enabled = varGlobales.isCamFauteuil;

        porte = true;
    }
	
	// Update is called once per frame
	void Update () {
        Cursor.visible = !varGlobales.isCamFauteuil;

        if(varGlobales.moneyCurrent < 0) {
            varGlobales.isMoneyNegative = true;
        } else {
            varGlobales.isMoneyNegative = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && porte && !varGlobales.isCamFauteuil) {
            if (!varGlobales.isMoneyNegative) {
                bipGood.Play();
                porte = false;
                cameraFauteuil.enabled = !cameraFauteuil.enabled;
                cameraPlan.enabled = !cameraPlan.enabled;
                varGlobales.isCamFauteuil = !varGlobales.isCamFauteuil;

                //Debug.Log(varGlobales.isCamFauteuil);
                GetComponent<CharacterController>().enabled = varGlobales.isCamFauteuil;
                GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = varGlobales.isCamFauteuil;
                GetComponent<AudioSource>().enabled = varGlobales.isCamFauteuil;
            }
            else {
                //play sound biiiip
                bipBad.Play();
            }
            
        }
	}
}
