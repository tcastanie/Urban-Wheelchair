using UnityEngine;
using System.Collections;

public class camFollowPlayer : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(player.transform.position.x,10,player.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.transform.position.x,10,player.transform.position.z);
	}
}
