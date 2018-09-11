using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpeechController : MonoBehaviour {

	static public GameObject sp;


	// Use this for initialization
	void Start () {
		sp = GameObject.Find ("Speech");
	}

	public void good(){
		MicScript.counter += 1;
		MicScript.cPanel.SetActive (true);

		if (MicScript.counter > 3) {
			if (playerScore.score >=-1 && playerScore.score<=1)
				SceneManager.LoadScene ("EndScene2");
			else if (playerScore.score > 1)
				SceneManager.LoadScene ("EndScene1");
			else
				SceneManager.LoadScene ("EndScene3"); 


			return;
		}
		MicScript.cPanel.SetActive (true);

		MicScript.good.text = MicScript.goodOptions [MicScript.counter];
		MicScript.bad.text = MicScript.badOptions [MicScript.counter];
		MicScript.cResp.text = MicScript.crowd [Random.Range(0,3)];

		playerScore.score += 1;

	}

	public void bad(){
		MicScript.cPanel.SetActive (true);
		MicScript.counter += 1;

		if (MicScript.counter > 3) {
			if (playerScore.score >=-1 && playerScore.score<=1)
				SceneManager.LoadScene ("EndScene2");
			else if (playerScore.score > 1)
				SceneManager.LoadScene ("EndScene1");
			else
				SceneManager.LoadScene ("EndScene3"); 


			return;
		}
			

		MicScript.cPanel.SetActive (true);

		MicScript.good.text = MicScript.goodOptions [MicScript.counter];
		MicScript.bad.text = MicScript.badOptions [MicScript.counter];
		MicScript.cResp.text = MicScript.crowd [Random.Range(0,3)];

		playerScore.score -= 1;

	}



}
