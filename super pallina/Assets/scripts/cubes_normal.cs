using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubes_normal : MonoBehaviour {

	public Material material1;
	public Material material2;
	public float duration = 2.0f;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Random", 0, 4);
		rend = GetComponent <Renderer>();
		rend.material = material1;
	}
	
	// Update is called once per frame
	void Update () {
		//float lerp = Mathf.PingPong (Time.time, duration) / duration;
		//rend.material.Lerp (material1, material2, lerp);
	}

	void Random (){
	//	Random.Range (2.0f, 3.0f);
	}
}
