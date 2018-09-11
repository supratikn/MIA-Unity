using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {
	float pScore = 0.0f;

	void OnGUI(){
		pScore = playerScore.score;
		string eScoreText = pScore.ToString ();

		GUI.Box (new Rect (10,10, 150, 50),"PLAYER SCORE");
		GUI.Label (new Rect (75, 30, 25, 25), eScoreText);
	}

}
