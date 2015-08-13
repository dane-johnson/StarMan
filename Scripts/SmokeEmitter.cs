using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SmokeEmitter : MonoBehaviour {
	public GameObject smokePrefab;
	//private float lastEmission;

	void Start(){
		EmitSmoke ();
		//lastEmission = Time.time;
	}

	void Update(){
		//if (Time.time - lastEmission > 0.5f) {
		if (Random.value > .95f){
			EmitSmoke ();
			//lastEmission = Time.time;
		}
	}

	private void EmitSmoke(){
		GameObject mySmoke = (GameObject)Instantiate (smokePrefab, transform.position, Quaternion.identity);
		GameObject parent = GameObject.Find ("SmokeParent");
		if (parent != null) {
			mySmoke.transform.SetParent (parent.transform);
		}
	}
}
