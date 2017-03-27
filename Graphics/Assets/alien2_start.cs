using UnityEngine;
using System.Collections;

public class alien2_start : MonoBehaviour {
	public float req;
	public float star;
	public Animator anim;
	// Use this for initialization
	void Start () {
		star = Time.time;
		req = Time.time + 18.0f;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Time.time > req)) 
		{
			anim.SetTrigger ("secondStart");
		}
		//Debug.Log(Time.time - star);
	}
}
