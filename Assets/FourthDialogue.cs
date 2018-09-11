using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourthDialogue : MonoBehaviour {
	GameObject dialogue;
	Text npc_q;
	Text answer1;
	Text answer2;
	GameObject dia_panel;


	void Start () {
		dialogue = GameObject.Find ("Dialogue4");
		npc_q = GameObject.Find ("NPC_Question4").GetComponent<Text>();
		answer1 = GameObject.Find ("Answer14").GetComponent<Text>();
		answer2 = GameObject.Find ("Answer24").GetComponent<Text>();
		dia_panel = GameObject.Find ("NPC_panel4");

		dialogue.SetActive (false);
		dia_panel.SetActive (false);
	}

	void OnTriggerEnter (Collider player) {
		if (player.tag == "Player") {
			transform.LookAt (player.transform.position);
			//print (player.transform.position);
			dialogue.SetActive (true);
			dia_panel.SetActive (true);
			npc_q.text = "What are you going to do?";
			answer1.text = "This movement is an ideological one. Actions will come later on when our collective voices are heard by authorities. ";
			answer2.text = "Whatever it take. We will start with words, but move to force if we must.";
		}
	}
	void OnTriggerStay(Collider player) {
		if (player.tag == "Player") {
			transform.LookAt (player.transform.position);
		}
	}

	void OnTriggerExit(Collider player){
		if (player.tag == "Player") {

			playerScore.score+=FourthResponse.score;
			//print ("Score: " + ThirdResponse.score);

			dialogue.SetActive (false);
			dia_panel.SetActive (false);
			try{
				FourthResponse.npc_r.text="";
			}
			catch(System.Exception e){
			}

		}
	}

}



