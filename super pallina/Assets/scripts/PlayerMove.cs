using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public moveControls mC;
	public float moveSpeed;
	public Rigidbody Rb;
//	public GameObject tower;
	private float xPosition;
//	private float rotation;
	public float drift;
	public float rotationDrift;
	public float jumpForce;
//	private bool moveCheck;
	private bool jumpOn;
	private TrailRenderer trail;

	// Use this for initialization
	void Start () {
		
		Rb = GetComponent <Rigidbody> ();
		xPosition = Rb.position.x;
		jumpOn = true;


	}
	void Update(){
		
		// Movimento a Sx
		if (mC.moveLeft) {
			
			// Se la posizione NON e' -4 
			// sposta la pallina
			if (xPosition != -4) {
				//moveCheck = true;
				xPosition -= 2;
//				Debug.Log (xPosition);
			} else {
				
			// Altrimenti controlla se 
			// la variabile moveCheck
			// e' falsa e ruota la colonna
				/*
				if (!moveCheck) {
					xPosition = 4;
					rotation -= 90;
					Debug.Log (rotation);
				}
				*/
			}
		}

		// Movimento a Dx
		if (mC.moveRight) {

			// Se la posizione NON e' 4 
			// sposta la pallina
			if (xPosition != 4) {
				//moveCheck = true;
				xPosition += 2;
//				Debug.Log (xPosition);
			} else {
				
			// Altrimenti controlla se 
			// la variabile moveCheck
			// e' falsa e ruota la colonna
				/*
				if (!moveCheck) {
					xPosition = -4;
					rotation += 90;
					Debug.Log (rotation);
				}
				*/
			}
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		//moveCheck = false;

		Vector3 pos = Rb.position;
		pos.x = Mathf.MoveTowards (pos.x, xPosition, drift * Time.deltaTime);
		Rb.position = pos;

//		Vector3 rot = tower.transform.eulerAngles;
		// così il rb gira a seconda dell'angolo
//		float angle = Mathf.MoveTowardsAngle (tower.transform.eulerAngles.y, rotation, rotationDrift * Time.deltaTime);
		//l'angolo è uguale all'interpolazione da il punto in cui si trova al target
//		tower.transform.eulerAngles = new Vector3(0,angle,0);
	    //il punto in cui si trova è uguale a sto vector3
	
		//salto
		if(mC.moveJump && jumpOn){
			Rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);
			//jumpOn = false;
		}
	}

	void OnTriggerEnter(Collider collision){
		
		if (collision.gameObject.tag == "jumpPick" && !jumpOn) {
			Debug.Log ("jump enabled");
			jumpOn = true;
		}
	} 
}
