using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour {
	public float velocity = 20;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = new Vector3 (0.0f, 0.0f, velocity);

	}
	void OnTriggerEnter(){
		//rb.velocity = new Vector3 (0.0f, 0.0f, -1);
		velocity = velocity* -1;
		rb.velocity = new Vector3 (0.0f, 0.0f, velocity);
	}
}
