using UnityEngine;
using System.Collections;

public class SmokeColorChooser : MonoBehaviour {

	public Sprite[] smokeSprites;

	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();

		//Now lets pick a random color
		int nSmokeSprite = (int)(Random.value * smokeSprites.Length);
		Sprite mySprite = smokeSprites [nSmokeSprite];

		//Make it our Sprite
		sr.sprite = mySprite;
	}
}
