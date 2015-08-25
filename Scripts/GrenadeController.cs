using UnityEngine;
using System.Collections;

public class GrenadeController : MonoBehaviour {

	public float explosionRadius;
	public float detonationMagnitude;

	private float startTime;

	// Use this for initialization
	void Start () {

		startTime = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - startTime > 5) {
			Explode ();
		}
	}

	private void Explode(){
		GameObject[] baddies = GameObject.FindGameObjectsWithTag ("Baddie");

		foreach (GameObject baddie in baddies) {
			float magnitude = Vector2.Distance(transform.position, baddie.transform.position);

			if(magnitude < explosionRadius){
				baddie.GetComponent<Rigidbody2D>().AddForce((baddie.transform.position - transform.position).normalized * ((explosionRadius - magnitude) / explosionRadius) * detonationMagnitude);
			}
		}
		AudioSource sound = GetComponent<AudioSource> ();
		sound.Play ();
		Destroy (gameObject);
	}
}
