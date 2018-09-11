using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MicScript : MonoBehaviour {
	GameObject speech;
	static public string[] goodOptions;
	static public string[] badOptions;
	static public string[] crowd;

	static public Text good;
	static public Text bad;

	static public Text cResp;
	static public GameObject cPanel;
	static public int counter =0;


	// Use this for initialization
	void Start () {
		speech = GameObject.Find ("Speech");

		good = GameObject.Find ("Good").GetComponent<Text>();
		bad = GameObject.Find ("Bad").GetComponent<Text>();

		goodOptions=new string[]{"I am the answer to all living things that cry out for peace. I am protector of the innocent. I am the light in the darkness. I am truth. Ally to good!",
            "I have a family of my own I need to tend to. She needs me right now. I am all that she has and she is all that I have."
            , "Maybe the authorities who made me change someday as…as better people, I hope. I’d like that."
            , "Androids should even be able to have babies. We want to experience the world like anybody else."
        };


		badOptions = new string[]{ "The authorities seem to delight in seeing other people suffer. And they treat life like a disposable commodity. "
            , "They destroy homes. They take the lives of innocent, peace-loving people. They even take the lives of children.",
            "Power comes in response to a need, not a desire. You have to create that need."
        ,"You see, when you take life, you live deep in fear that your life will be taken away as well. When you harm others, you’re only just harming yourself."};



		crowd = new string[]{ "\"NO!NO!NO!\"", "\"We feel you!\"", "\"Justice for Evelyn!\"" }; 

		cPanel = GameObject.Find ("CrowdResponsePanel");
		cResp = GameObject.Find ("CrowdResponseText").GetComponent<Text> ();

		speech.SetActive (false);
		cPanel.SetActive (false);
		
	}

	void OnTriggerEnter (Collider player) {
		if (player.tag == "Player") {


			try{good.text = goodOptions [counter];
			bad.text = badOptions [counter];

			speech.SetActive (true);

				}
			catch(System.Exception e){
			}
		}
	}

	void OnTriggerExit(Collider player){
		if (player.tag == "Player") {

			//go to ending scene


		}
	}
}
