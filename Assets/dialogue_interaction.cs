	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

	public class dialogue_interaction : MonoBehaviour {
		GameObject dialogue;
		Text npc_q;
		Text answer1;
		Text answer2;
	Text answer3;
	Text answer4;
		GameObject dia_panel;
		Text resp;

		void Start () {
			dialogue = GameObject.Find ("Dialogue1");
			npc_q = GameObject.Find ("NPC_Question1").GetComponent<Text>();
			answer1 = GameObject.Find ("Answer11").GetComponent<Text>();
			answer2 = GameObject.Find ("Answer21").GetComponent<Text>();
		answer3=GameObject.Find ("Answer31").GetComponent<Text>();
		answer4= GameObject.Find ("Answer41").GetComponent<Text>();
			dia_panel = GameObject.Find ("NPC_panel1");
			resp = response_control.npc_r;
			dialogue.SetActive (false);
			dia_panel.SetActive (false);
		}
		
		void OnTriggerEnter (Collider player) {
			if (player.tag == "Player") {
				transform.LookAt (player.transform.position);
				//print (player.transform.position);
				dialogue.SetActive (true);
				dia_panel.SetActive (true);
				npc_q.text = "Why should androids be integrated into human society?";
				answer1.text = "The world can only benefit from android integration. Imagine what we could do together.";
				answer2.text = "I want to be able to hold my girlfriend to me without judgement.";
			answer4.text = "If we don't integrate willingly, android will resort to force.";
			answer3.text = "Androids, despite their appearances, are as human as you are, we deserve to be able to stand along with you.";
				
			}
		}
		void OnTriggerStay(Collider player) {
			if (player.tag == "Player") {
				transform.LookAt (player.transform.position);
			}
		}

		void OnTriggerExit(Collider player){
			if (player.tag == "Player") {
				
				playerScore.score+=response_control.score;
				print ("Score: " + response_control.score);

				dialogue.SetActive (false);
				dia_panel.SetActive (false);
			try{
				response_control.npc_r.text="";
			}
			catch(System.Exception e){
			}

			}
		}

	}
