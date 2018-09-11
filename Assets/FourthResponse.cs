using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FourthResponse : MonoBehaviour {
	static public Text npc_r;
	static public GameObject dia;
	static public int score;

	// Use this for initialization
	void Start () {
		npc_r = GameObject.Find ("NPC_Response4").GetComponent<Text>();
		dia = GameObject.Find ("Dialogue4");

	}
	public void Answer1(){

		dia.SetActive (false);
		npc_r.text = "Everybody should come together!";
		score = 1;
	}

	public void Answer2(){
		dia.SetActive (false);
		npc_r.text = "Then you're just as bad as the ones who hurt you.";
		score = -1;
	}
}

