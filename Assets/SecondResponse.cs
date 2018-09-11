using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SecondResponse : MonoBehaviour {
	static public Text npc_r;
	static public GameObject dia;
	static public int score;

	// Use this for initialization
	void Start () {
		npc_r = GameObject.Find ("NPC_Response2").GetComponent<Text>();
		dia = GameObject.Find ("Dialogue2");

	}
	public void Answer1(){

		dia.SetActive (false);
		npc_r.text = "We must all be strong!";
		score = 1;
	}

	public void Answer2(){
		dia.SetActive (false);
		npc_r.text = "I bet some things still scare you. ";
		score = -1;
	}
}

