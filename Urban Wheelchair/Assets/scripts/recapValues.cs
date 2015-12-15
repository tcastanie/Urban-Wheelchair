using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class recapValues : MonoBehaviour {


    public GameObject textTemps;
    public GameObject textTempsPrec;
    public GameObject textArgentDep;
    public GameObject textArgentRest;
    public GameObject textRecord;

    // Use this for initialization
    void Start () {

        if (varGlobales.tempsActuel < varGlobales.tempsBest) {
            varGlobales.tempsBest = (int) varGlobales.tempsActuel;
        }

        string sTemps = varGlobales.tempsActuel.ToString();
        string sTempsPrec = varGlobales.tempsLast.ToString();
        string sArgentDep = (varGlobales.moneyStart-varGlobales.moneyCurrent).ToString();
        string sArgentRest = varGlobales.moneyCurrent.ToString();
        string sTempsRecord = varGlobales.tempsBest.ToString();

        textTemps.GetComponent<Text>().text = "Temps de la course : " + sTemps + " secondes";
        textTempsPrec.GetComponent<Text>().text = "Temps precedent : " + sTempsPrec + " secondes";
        textArgentDep.GetComponent<Text>().text = "Argent depense : " + sArgentDep + " euros";
        textArgentRest.GetComponent<Text>().text = "Argent restant : " + sArgentRest + " euros";
        textRecord.GetComponent<Text>().text = "Record absolu : " + sTempsRecord + " secondes";
    }
	
	// Update is called once per frame
	void Update () {
        Cursor.visible = true;
    }
}
