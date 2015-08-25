using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public GameObject grenadePrefab;

	void FixedUpdate(){
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddTorque(Input.GetAxis("Horizontal") * -speed);
	}

	void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			DropGrenade ();
		}
	}

	private void DropGrenade(){
		GameObject myGrenade = Instantiate (grenadePrefab);
		myGrenade.transform.position = transform.position;
	}
}
