using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {
	public float req,star;
	public float x;

	public Animator anim;
	// Use this for initialization
	void Start () {
		star = Time.time;
		req = Time.time + 5.0f;
		anim = GetComponent<Animator> ();


	}

	// Update is called once per frame
	void Update () {
		
		if (Time.time < req || ((Time.time-star) > 17.0f && (Time.time - star) < 22.0f)) {
			transform.Translate (0, 0, 0.03f);
		}

		//Debug.Log ("time is:");
		//Debug.Log (Time.time - star); 
	}
}
