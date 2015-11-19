﻿using UnityEngine;
using System.Collections;


public class changeCamera : MonoBehaviour {
	
	public Camera cameraFauteuil;
	public Camera cameraPlan;

	// Use this for initialization
	void Start () {
		cameraFauteuil.enabled = true;
		cameraPlan.enabled = false;

        Cursor.visible = !cameraFauteuil.enabled;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C)) {
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
