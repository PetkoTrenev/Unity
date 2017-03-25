using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	private int count;

	public float speed; // this variable is in the inspector
	public Text countText;
	public Text winText;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	// before physics calculations
	// everything with physics goes in here
	void FixedUpdate() 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");	
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rb.AddForce (movement * speed);

	}

	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.CompareTag("Pick Up")) 
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
		}
	}

	void SetCountText() {
		countText.text = "Count: " + count.ToString ();
		if (count >= 6) {
			winText.text = "You win!";
		}
	}

}
