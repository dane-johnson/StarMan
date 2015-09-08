using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public GameObject grenadePrefab;
	public Text text;

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
		text.text = string.Format("{0,5:N1}%",((Time.time - lastGrenadeTime > 3.0f) ? 100.0f : (Time.time - lastGrenadeTime) * 100 / 3));
	}

	private void DropGrenade(){
		GameObject myGrenade = Instantiate (grenadePrefab);
		myGrenade.transform.position = transform.position;
	}
}
