using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Move controls Class.
/// </summary>
public class moveControls : MonoBehaviour {

	public bool moveUp;
	public bool moveRight;
	public bool moveDown;
	public bool moveLeft;
	public bool moveJump;

	void Start () {
		moveUp		= false;
		moveRight	= false;
		moveDown	= false;
		moveLeft	= false;
		moveJump	= false;
	}
	void Update () {
	
		if (
			Input.GetKeyDown (KeyCode.W) ||
			Input.GetKeyDown (KeyCode.UpArrow)) {

			moveUp = true;
		} else {
			moveUp = false;
		}

		if (
			Input.GetKeyDown (KeyCode.D) ||
			Input.GetKeyDown (KeyCode.RightArrow)) {

			moveRight = true;
		} else {
			moveRight = false;
		}

		if (
			Input.GetKeyDown (KeyCode.S) ||
			Input.GetKeyDown (KeyCode.DownArrow)) {

			moveDown = true;
		} else {
			moveDown = false;
		}

		if (
			Input.GetKeyDown (KeyCode.A) ||
			Input.GetKeyDown (KeyCode.LeftArrow)) {

			moveLeft = true;
		} else {
			moveLeft = false;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			moveJump = true;
		} else {
			moveJump = false;
		}
	}
}
