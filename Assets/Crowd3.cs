using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crowd3 : MonoBehaviour {
	GameObject dialogue;
	Text npc_q;
	Text answer1;
	Text answer2;
	GameObject dia_panel;


	void Start () {

		npc_q = GameObject.Find ("NPC_Question33").GetComponent<Text>();

		dia_panel = GameObject.Find ("NPC_panel33");


		dia_panel.SetActive (false);
	}

	void OnTriggerEnter (Collider player) {
		if (player.tag == "Player") {

			dia_panel.SetActive (true);
			npc_q.text = "\"It takes a lot of time and unleraning homophobia to actually admit that you're gay. \"";
		}

	}


	void OnTriggerExit(Collider player){
		if (player.tag == "Player") {


			dia_panel.SetActive (false);
			npc_q.text = "";

		}
	}

}



