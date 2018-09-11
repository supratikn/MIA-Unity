using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ThirdResponse : MonoBehaviour {
	static public Text npc_r;
	static public GameObject dia;
	static public int score;

	// Use this for initialization
	void Start () {
		npc_r = GameObject.Find ("NPC_Response3").GetComponent<Text>();
		dia = GameObject.Find ("Dialogue3");

	}
	public void Answer1(){

		dia.SetActive (false);
		npc_r.text = "I guess, we are all same, in a way.";
		score = 1;
	}

	public void Answer2(){
		dia.SetActive (false);
		npc_r.text = "Why should I even listen to you?";
		score = -1;
	}
}

