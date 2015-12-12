using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cameraMenu : MonoBehaviour {

    public Transform target;
    public GameObject score;

	// Use this for initialization
	void Start () {
        varGlobales.etatJeu = 0;
        if (varGlobales.tempsBest == 999) {
            score.GetComponent<Text>().text = "Ton record s'affichera ici !";
        } else {
            score.GetComponent<Text>().text = varGlobales.tempsBest.ToString() + " secondes !";
        }

    }
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.up, 30 * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("quit");
            Application.Quit();
        }
    }
}
