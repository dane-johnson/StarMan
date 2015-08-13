using UnityEngine;
using System.Collections;

public class Float : MonoBehaviour {

	private float creationTime;
	private float dx, dy;

	void Start(){
		creationTime = Time.time;
	}

	void FixedUpdate () {
		if (Time.time - creationTime > 3) {
			Destroy (gameObject);
			return;
		}
		dx = Mathf.Sin (Time.time) * 0.001f;
		dy += 0.0001f;
		transform.position = new Vector2 (transform.position.x + dx, transform.position.y + dy);
	}
}
