using UnityEngine;
using System.Collections;

public class chase : MonoBehaviour {

	public Transform player;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(Vector3.Distance(player.position,this.transform.position) < 10000){
			Vector3 direction = player.position - this.transform.position;
			this.transform.rotation = Quaternion.Slerp (this.player.transform.rotation, Quaternion.LookRotation (direction), 0.2f);
		}
	}
}
