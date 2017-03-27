using UnityEngine;
using System.Collections;

public class run : MonoBehaviour {

	public float req;

	public Animator anim;
	// Use this for initialization
	void Start () {
		//Debug.Log ("in start");
		req = Time.time + 1.0f;
		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
		//Debug.Log ("in update");
		//Debug.Log(Input.GetKey("space"));
		if(Input.GetKey("space")) {
			anim.SetTrigger ("toAttack");
			//Debug.Log ("after setting");
		}

	}
}
