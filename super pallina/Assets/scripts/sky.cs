using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sky : MonoBehaviour {

	public Material material1;
	public Material material2;
	public float duration = 2.0f;

	// Use this for initialization
	void Start () {


		RenderSettings.skybox = material1;

	}
	
	// Update is called once per frame
	void Update () {
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
		RenderSettings.skybox.Lerp (material1, material2, lerp);
	}
}
