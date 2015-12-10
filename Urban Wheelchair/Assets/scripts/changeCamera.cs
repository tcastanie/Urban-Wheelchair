using UnityEngine;
using System.Collections;


public class changeCamera : MonoBehaviour {
	
	public Camera cameraFauteuil;
	public Camera cameraPlan;

    bool porte;

	// Use this for initialization
	void Start () {
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
		if (Input.GetKeyDown(KeyCode.Space) && porte && !varGlobales.isCamFauteuil) {
            porte = false;
			cameraFauteuil.enabled = !cameraFauteuil.enabled;
            cameraPlan.enabled = !cameraPlan.enabled;
            varGlobales.isCamFauteuil = !varGlobales.isCamFauteuil;

            Cursor.visible = !varGlobales.isCamFauteuil;

            //Debug.Log(varGlobales.isCamFauteuil);
            GetComponent<CharacterController>().enabled = varGlobales.isCamFauteuil;
            GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = varGlobales.isCamFauteuil;
            GetComponent<AudioSource>().enabled = varGlobales.isCamFauteuil;
            
        }
	}
}
