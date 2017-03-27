using UnityEngine;
using System.Collections;

public class hidden : MonoBehaviour {
	public float req,star;
	public float x;
	// Use this for initialization
	void Start () {
		star = Time.time;
		req = Time.time + 5.0f;
		gameObject.GetComponent<Renderer> ().enabled = false;
		//gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > req) {
			gameObject.GetComponent<Renderer> ().enabled = true;
		} 
	}
}
