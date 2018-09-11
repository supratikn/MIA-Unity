using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crowd4 : MonoBehaviour {
	GameObject dialogue;
	Text npc_q;
	Text answer1;
	Text answer2;
	GameObject dia_panel;


	void Start () {

		npc_q = GameObject.Find ("NPC_Question44").GetComponent<Text>();

		dia_panel = GameObject.Find ("NPC_panel44");


		dia_panel.SetActive (false);
	}

	void OnTriggerEnter (Collider player) {
		if (player.tag == "Player") {

			dia_panel.SetActive (true);
			npc_q.text = "\"   Never be bullied into silence. Never allow yourself to be made a victim.   \"";
		}

	}


	void OnTriggerExit(Collider player){
		if (player.tag == "Player") {


			dia_panel.SetActive (false);
			npc_q.text = "";

		}
	}

}



