using UnityEngine;
using System.Collections;

public class GrenadeController : MonoBehaviour {

	public float explosionRadius;
	public float detonationMagnitude;

	private float startTime;
	private bool isExploding;
	private AudioSource sound;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		sound = GetComponent<AudioSource> ();
		isExploding = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - startTime > 5 && !isExploding) {
			Explode ();
		}
	}

	void FixedUpdate(){
		if(isExploding && !sound.isPlaying){
			Destroy(gameObject);
		}
	}

	private void Explode(){
		GameObject[] baddies = GameObject.FindGameObjectsWithTag ("Baddie");
		GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
		GameObject[] grenades = GameObject.FindGameObjectsWithTag("Grenade");

		GameObject[] items = Utilities.CombineGameObjectArrays(baddies, players, grenades);

		foreach (GameObject item in items) {
			float magnitude = Vector2.Distance(transform.position, item.transform.position);

			if(item != gameObject && magnitude < explosionRadius){
				item.GetComponent<Rigidbody2D>().AddForce((item.transform.position - transform.position).normalized * ((explosionRadius - magnitude) / explosionRadius) * detonationMagnitude);
			}
		}
		sound.Play ();
		transform.rotation = Quaternion.identity;
		GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
		GetComponent<Animator>().enabled = true;
		isExploding = true;
	}
}
