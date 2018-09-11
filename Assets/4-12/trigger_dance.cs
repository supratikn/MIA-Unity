using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_dance : MonoBehaviour {
	Animator dancing_Ani;//
	public Texture BoxTexture;
	bool inTrigger;
	void Start () {
		dancing_Ani = GetComponent<Animator> ();///
		inTrigger = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		dancing_Ani.SetBool ("Dance", true);///
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();

		inTrigger = true;
	}

	void OnTriggerExit (Collider other) {
		dancing_Ani.SetBool ("Dance", false);////
		AudioSource audio = GetComponent<AudioSource>();
		audio.Pause();

		inTrigger = false;
	}

	void OnGUI(){
		if (inTrigger) {
			GUI.Box(new Rect (Screen.width - 300,50, 500, 200), BoxTexture, GUIStyle.none);
			GUI.Box(new Rect (Screen.width - 280,80, 100,100), "Hey, Remy! How are you?", GUIStyle.none);
		}
	}
}
