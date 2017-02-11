using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_cubes : MonoBehaviour {

	private bool trigger;
	private float duration;

	public float startPosition;
	private float endPosition;

	static float t;

	// Use this for initialization
	void Start () {
		trigger = false;
		duration = 8.0f;

		startPosition = transform.localPosition.z;
		endPosition	= transform.localPosition.z - 3f;

		t = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (trigger) {
			t += Time.deltaTime;

			transform.localPosition = new Vector3 (
				transform.localPosition.x,
				transform.localPosition.y,
				Mathf.Lerp (
					startPosition,
					endPosition,
					t * duration
				)
			);
		}

		if (transform.localPosition.z == endPosition) {
		}
	}

	void OnTriggerEnter(Collider collision){

		if (collision.gameObject.tag == "Player" && transform.localPosition.z != endPosition) {
			Debug.Log ("Cube entered");
			trigger = true;
			t = 0.0f;
		}
	}
}
