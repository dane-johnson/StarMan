using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public GameObject grenadePrefab;

	private float lastGrenadeTime;

	void Start(){
		lastGrenadeTime = Time.time - 3.0f;
	}

	void FixedUpdate(){
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddTorque(Input.GetAxis("Horizontal") * -speed);
	}

	void Update(){
		if (Input.GetButtonDown ("Fire1") && Time.time - lastGrenadeTime > 3.0f) {
			DropGrenade ();
			lastGrenadeTime = Time.time;
		}
	}

	private void DropGrenade(){
		GameObject myGrenade = Instantiate (grenadePrefab);
		myGrenade.transform.position = transform.position;
	}
}
