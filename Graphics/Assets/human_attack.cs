using UnityEngine;
using System.Collections;

public class human_attack : MonoBehaviour {
	public float req;

	public Animator anim;
	// Use this for initialization
	void Start () {
		req = Time.time + 5.0f;
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > req) {
			anim.SetTrigger ("goAttack");
		}
	
	}
}
