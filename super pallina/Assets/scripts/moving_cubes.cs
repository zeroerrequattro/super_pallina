using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_cubes : MonoBehaviour {

	private bool trigger;
	public float maximum; 
	static float t = 0.0f;

	// Use this for initialization
	void Start () {
		trigger = false;
		maximum = transform.position.z - 3f;
	}
	
	// Update is called once per frame
	void Update () {
		if (trigger == true){
			
			transform.position = new Vector3(
				transform.position.x,
				transform.position.y,
				Mathf.Lerp(
					transform.position.z,
					maximum,
					t
				)
			);

			t += 0.3f * Time.deltaTime;
		}
	}

	void OnTriggerEnter(Collider collision){

		if (collision.gameObject.tag == "Player") {
			Debug.Log ("Cube entered");
			trigger = true;
		}
	}
}
