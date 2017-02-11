using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickObject : MonoBehaviour {

	private bool reduce;
	private float duration;

	public Vector3 originalScale;
	public Vector3 endScale;

	static float t;

	// Use this for initialization
	void Start () {
		reduce = false;
		duration = 8.0f;

		originalScale = new Vector3 (1, 1, 1);
		endScale = new Vector3 (0, 0, 0);

		t = 0.0f;
	}

	// Update is called once per frame
	void Update () {

		// Controlla se la variabile reduce
		// e' vera e fa partire l'animazione
		if(reduce) {
			t += Time.deltaTime;

			transform.localScale = Vector3.Lerp(
				originalScale,
				endScale,
				t * duration
			);
		}

		// Quando raggiunge dimensione 0
		// l'oggetto si distrugge
		if (transform.localScale == endScale) {
			Destroy (this.gameObject);
		}

	}

	void OnTriggerEnter (Collider collision) {
		if(collision.gameObject.tag == "Player") {
			reduce = true;
			t = 0.0f;
		}
	}
}
