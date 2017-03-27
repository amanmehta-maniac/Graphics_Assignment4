using UnityEngine;
using System.Collections;

public class footsteps : MonoBehaviour {
	private AudioSource bhootAUD;
	public GameObject human_model;
	// Use this for initialization
	void Start () {
		human_model = GameObject.Find ("human_model");
		bhootAUD = human_model.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("z")) {
			bhootAUD.enabled = !bhootAUD.enabled;
		}
	}
}
