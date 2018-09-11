using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdDialogue : MonoBehaviour {
	GameObject dialogue;
	Text npc_q;
	Text answer1;
	Text answer2;
	Text answer3;
	GameObject dia_panel;


	void Start () {
		dialogue = GameObject.Find ("Dialogue3");
		npc_q = GameObject.Find ("NPC_Question3").GetComponent<Text>();
		answer1 = GameObject.Find ("Answer13").GetComponent<Text>();
		answer2 = GameObject.Find ("Answer23").GetComponent<Text>();
		answer3 = GameObject.Find ("Answer33").GetComponent<Text> ();
		dia_panel = GameObject.Find ("NPC_panel3");

		dialogue.SetActive (false);
		dia_panel.SetActive (false);
	}

	void OnTriggerEnter (Collider player) {
		if (player.tag == "Player") {
			transform.LookAt (player.transform.position);
			//print (player.transform.position);
			dialogue.SetActive (true);
			dia_panel.SetActive (true);
			npc_q.text = "Why should we listen to you? You're dating a human! Don't you think that's wrong? ";
			answer1.text = "Sex, race, human, or android do not matter, we are still people of the same world. Everyone should be free to do as they wish.";
			answer2.text = "No, you're the one who's wrong.";
			answer3.text = "How is my relationship different than a straight one? A human to human one? Why is it even relevant to dispute?";
		}
	}
	void OnTriggerStay(Collider player) {
		if (player.tag == "Player") {
			transform.LookAt (player.transform.position);
		}
	}

	void OnTriggerExit(Collider player){
		if (player.tag == "Player") {

			playerScore.score+=ThirdResponse.score;
			//print ("Score: " + ThirdResponse.score);

			dialogue.SetActive (false);
			dia_panel.SetActive (false);
			try{
				ThirdResponse.npc_r.text="";
			}
			catch(System.Exception e){
			}

		}
	}

}

