using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class response_control : MonoBehaviour {
	static public Text npc_r;
	static public GameObject dia;
	static public int score;

	// Use this for initialization
	void Start () {
		npc_r = GameObject.Find ("NPC_Response1").GetComponent<Text>();
		dia = GameObject.Find ("Dialogue1");

	}
	public void Answer1(){
		dia.SetActive (false);
		npc_r.text = "I never really thought of it that way.";
		score = 1;
	}

	public void Answer2(){
		dia.SetActive (false);
		npc_r.text = "How is that a good reason?";
		score = -1;
	}
}
