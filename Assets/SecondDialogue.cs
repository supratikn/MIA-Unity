using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondDialogue : MonoBehaviour {
	GameObject dialogue;
	Text npc_q;
	Text answer1;
	Text answer2;
	GameObject dia_panel;


	void Start () {
		dialogue = GameObject.Find ("Dialogue2");
		npc_q = GameObject.Find ("NPC_Question2").GetComponent<Text>();
		answer1 = GameObject.Find ("Answer12").GetComponent<Text>();
		answer2 = GameObject.Find ("Answer22").GetComponent<Text>();
		dia_panel = GameObject.Find ("NPC_panel2");

		dialogue.SetActive (false);
		dia_panel.SetActive (false);
	}

	void OnTriggerEnter (Collider player) {
		if (player.tag == "Player") {
			transform.LookAt (player.transform.position);
			//print (player.transform.position);
			dialogue.SetActive (true);
			dia_panel.SetActive (true);
			npc_q.text = "Where do you find the courage to stand up and do this?";
			answer2.text = "My experiences and ideas must be shared. It is not a matter of courage but of duty. ";
			answer1.text = "I'm not afraid of anything, not even public speaking.";
		}
	}
	void OnTriggerStay(Collider player) {
		if (player.tag == "Player") {
			transform.LookAt (player.transform.position);
		}
	}

	void OnTriggerExit(Collider player){
		if (player.tag == "Player") {

			playerScore.score+=SecondResponse.score;
			//print ("Score: " + ThirdResponse.score);

			dialogue.SetActive (false);
			dia_panel.SetActive (false);
			try{
				SecondResponse.npc_r.text="";
			}
			catch(System.Exception e){
			}

		}
	}

}



