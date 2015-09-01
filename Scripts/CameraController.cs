using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public float bufferX;
	public float bufferY;

	void Update(){
		//Make a box, and follow if outside the box
		if(player.transform.position.x > transform.position.x + bufferX){
			transform.position = new Vector3(player.transform.position.x - bufferX,
			                                 transform.position.y,
			                                 transform.position.z);
		} else if(player.transform.position.x < transform.position.x - bufferX){
			transform.position = new Vector3(player.transform.position.x + bufferX,
			                                 transform.position.y,
			                                 transform.position.z);
		}
		if(player.transform.position.y > transform.position.y + bufferY){
			transform.position = new Vector3(transform.position.x,
			                                 player.transform.position.y - bufferY,
			                                 transform.position.z);
		} else if(player.transform.position.y < transform.position.y - bufferY){
			transform.position = new Vector3(transform.position.x,
			                                 player.transform.position.y + bufferY,
			                                 transform.position.z);
		}
	}
}
