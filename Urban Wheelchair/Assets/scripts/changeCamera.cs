using UnityEngine;
using System.Collections;


public class changeCamera : MonoBehaviour {
	
	public Camera cameraFauteuil;
	public Camera cameraPlan;

	// Use this for initialization
	void Start () {
		cameraFauteuil.enabled = true;
		cameraPlan.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C)) {
			cameraFauteuil.enabled = !cameraFauteuil.enabled;
			cameraPlan.enabled = !cameraPlan.enabled;
		}
	}
}
