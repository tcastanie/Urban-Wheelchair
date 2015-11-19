using UnityEngine;
using System.Collections;

public class camFollowPlayer : MonoBehaviour {

	public GameObject player;
    public Camera cameraPlan;

    public int hauteurCamera;

    //La camera-plan suit le joueur au-dessus
    
	void Start () {
		transform.position = new Vector3(player.transform.position.x, 10, player.transform.position.z);
        cameraPlan.orthographicSize = hauteurCamera;
    }
	
	void Update () {
        if (varGlobales.isCamFauteuil){
            transform.position = new Vector3(player.transform.position.x, 10, player.transform.position.z);
            cameraPlan.orthographicSize = hauteurCamera;
        }
	}
}
