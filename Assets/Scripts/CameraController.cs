using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		// LateUpdate runs every from but only after everthing in update method has been called.
		// so it'll capture the fact that the player has already moved positions.
		transform.position = player.transform.position + offset;

	}
}
