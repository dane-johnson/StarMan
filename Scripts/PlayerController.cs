using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	void FixedUpdate(){
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddTorque(Input.GetAxis("Horizontal") * -speed);

	}
}
