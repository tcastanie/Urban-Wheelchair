using UnityEngine;
using System.Collections;
using System;
using UnityEditor;

public class AssignMaterial : ScriptableWizard {
	public bool runRecursively =  true;
	public Material theMaterial;
	String strHelp = "Select Game Objects";
	GameObject[] gos;
	
	void OnWizardUpdate (){
		helpString = strHelp;
		isValid = (theMaterial != null);
	}
	
	void OnWizardCreate (){
		gos = Selection.gameObjects;
		foreach (GameObject go in gos){
			changeMaterial(go);
		}
	}

	void changeMaterial(GameObject go){
		if (go.GetComponent<Renderer> ()) {
			go.GetComponent<Renderer> ().material = theMaterial;
		}
		if (runRecursively == true) {
			for(int i = 0; i < go.transform.GetChildCount(); i++){
				changeMaterial(go.transform.GetChild(i).gameObject);
			}
		}
	}

	[MenuItem ("Custom/Assign Material", false, 4)]
	static void assignMaterial(){
		ScriptableWizard.DisplayWizard ("Assign Material", typeof(AssignMaterial), "Assign");
	}
}