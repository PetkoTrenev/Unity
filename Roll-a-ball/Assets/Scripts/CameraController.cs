using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position; // calucates the distance of the camera to the object

	}
	
	// Update is called once per frame, but after all objects have been processed in Update()
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
