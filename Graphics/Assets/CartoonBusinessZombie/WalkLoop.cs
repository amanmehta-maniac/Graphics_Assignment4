using UnityEngine;
using System.Collections;

public class WalkLoop : MonoBehaviour {

	float req = 0f;
	float offset = 5.0f;
	static Animator anim;
	// Use this for initialization
	void Start () {
		req = Time.time + offset;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("time : ");
		Debug.Log (Time.time);
		Debug.Log ("curr : ");
		Debug.Log (req);
		Debug.Log ("if: ");
		Debug.Log (Time.time > req);
		if (Time.time > req) {
			anim.SetTrigger ("goIdle");
		}
	}
}
/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onOff : MonoBehaviour {
	public GameObject hand;
	public GameObject alien1;
	public GameObject alien2;
	public GameObject alien3;
	public GameObject alien4;
	public GameObject alien5;
	public GameObject alien6;	
	public GameObject alien7;
	public GameObject alien8;
	public GameObject bandi;
	public GameObject total;
	public GameObject bhoot;
	public GameObject dragon;
	public GameObject cam;
	private int gone;
	private Animator animAlien1;
	private Animator animAlien2;
	private Animator animAlien3;
	private Animator animAlien4;
	private Animator animAlien5;
	private Animator animAlien6;
	private Animator animAlien7;
	private Animator animAlien8;
	private AudioSource bhootAUD;
	private AudioSource dragonROAR;
	private AudioSource cams;
	private int flag = 0;
	private Animator animBANDI;
	public float x, y, z;
	public float xangle, yangle, zangle;
	Vector3 temp,temp2;
	// Use this for initialization
	void Start () {
		//hand = GameObject.Find("Particle System");
		animAlien3 = alien3.GetComponent<Animator>();
		animAlien4 = alien4.GetComponent<Animator>();
		animAlien5 = alien5.GetComponent<Animator>();
		animAlien6 = alien6.GetComponent<Animator>();
		animAlien7 = alien7.GetComponent<Animator>();
		animAlien8 = alien8.GetComponent<Animator>();
		animAlien1 = alien1.GetComponent<Animator>();
		animAlien2 = alien2.GetComponent<Animator>();
		animBANDI = bandi.GetComponent<Animator> ();
		bhootAUD = bhoot.GetComponent<AudioSource> ();
		dragonROAR = dragon.GetComponent<AudioSource> ();
		cams = cam.GetComponent<AudioSource> ();
	}
	IEnumerator aftertime(float time)
	{
		yield return new WaitForSeconds (time);
	}
	// Update is called once per frame
	void Update () {
		
		temp = total.transform.position;
		temp2 = total.transform.eulerAngles;
		//Debug.Log (temp);
		if (Input.GetKeyDown ("space")) {
			Debug.Log("l");
			gone = 1;
			hand.SetActive(true);	
			//aftertime (1);
			//alien1.transform.Rotate (90, 0, 0);
			//alien1.GetComponent<Animator>
			alien2.transform.Rotate (90, 0, 0);
			alien3.transform.Rotate (90, 0, 0);
			alien4.transform.Rotate (90, 0, 0);
			alien5.transform.Rotate (90, 0, 0);
			alien6.transform.Rotate (90, 0, 0);
			alien7.transform.Rotate (90, 0, 0);
			alien8.transform.Rotate (90, 0, 0);
			flag = 1;
			animBANDI.enabled = !animBANDI.enabled;
			cams.enabled = !cams.enabled;
		}
		if (Input.GetKeyUp ("space")) {
			flag = 0;
			//total.transform.eulerAngles.y;
			total.transform.rotation = Quaternion.Euler(0,180,0);
			animBANDI.enabled = !animBANDI.enabled;
			//total.transform.position = temp;
			//total.transform.eulerAngles = temp2;
		}
		if (flag == 1) {
			bandi.transform.Rotate (0, 45, 0);
		}
		if(Input.GetKeyDown("z")){
			Debug.Log ("asd");
			bhootAUD.enabled = !bhootAUD.enabled;
		}
		if(Input.GetKeyDown("x")){
			dragonROAR.enabled = !dragonROAR.enabled;
		}
		aftertime (100000);
		animAlien2.SetInteger ("gone", gone);
		animAlien3.SetInteger ("gone", gone);
		animAlien4.SetInteger ("gone", gone);
		animAlien5.SetInteger ("gone", gone);
		animAlien6.SetInteger ("gone", gone);
		animAlien7.SetInteger ("gone", gone);
		animAlien8.SetInteger ("gone", gone);

		animAlien1.SetInteger ("gone", gone);

	}
}*/