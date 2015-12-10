﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class time : MonoBehaviour {

    public GameObject textTemps;
    public GameObject textArgent;

    bool porte;

    // Use this for initialization
    void Start () {
        varGlobales.tempsActuel = 0;
        string sTemps = varGlobales.tempsActuel.ToString();
        textTemps.GetComponent<Text>().text = sTemps.PadLeft(3, '0');

        string sArgent = varGlobales.moneyCurrent.ToString().PadLeft(6, '0');
        textArgent.GetComponent<Text>().text = sArgent;

        porte = true;

        varGlobales.moneyCurrent = varGlobales.moneyStart;
        if(varGlobales.isFirstTime) {
            textArgent.GetComponent<Text>().text = " ";
        } else {
            textArgent.GetComponent<Text>().text = sArgent + " euros";
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (varGlobales.isCamFauteuil && porte) {
            StartCoroutine(timer());
            porte = false;
        }
        Debug.Log(varGlobales.moneyStart);
        Debug.Log(varGlobales.moneyCurrent);

        string sArgent = varGlobales.moneyCurrent.ToString().PadLeft(6, '0');
        if (varGlobales.isFirstTime) {
            textArgent.GetComponent<Text>().text = " ";
        } else {
            textArgent.GetComponent<Text>().text = sArgent + " euros";
        }

    }


    IEnumerator timer() {
        while (!varGlobales.isFinished) {
            yield return new WaitForSeconds(1);
            varGlobales.tempsActuel += 1;
            string sTemps = varGlobales.tempsActuel.ToString();
            textTemps.GetComponent<Text>().text = sTemps.PadLeft(3, '0');
        }
    }
}
/*  TODO timer
    var timerText : UI.Text;
    var canvasObj : GameObject;
    var child : Transform;


    function Start () {
        canvasObj = GameObject.Find("Canvas");
        child =  canvasObj.transform.Find("txtTemps");
        timerText = child.GetComponent(UI.Text);
        TimerTick();
        timerText.text = "Temps :" + GlobVar.currentTime.ToString();
    }

    function TimerTick() {
        while(GlobVar.currentTime > 0) {
            yield WaitForSeconds(1);    //attendre 1 seconde

            GlobVar.currentTime--;
            timerText.text = "Temps :" + GlobVar.currentTime.ToString();
        }
        
        // game over and restart
        Application.LoadLevel("Terrain");
    }
*/
