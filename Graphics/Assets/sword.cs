using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {
	private AudioSource bhootAUD;
	public GameObject human_model;
	// Use this for initialization
	void Start () {
		human_model = GameObject.Find ("Skeleton");
		bhootAUD = human_model.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("s")) {
			bhootAUD.enabled = !bhootAUD.enabled;
		}
	}
}
