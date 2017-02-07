using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cacca : MonoBehaviour {
	public Rigidbody rb;
	private float posX;
	public GameObject ball;
	// Use this for initialization
	void Start () {
		GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			transform.Translate (Vector3.left*2);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			transform.Translate (Vector3.right*2);
		}
	
	
	}
}
