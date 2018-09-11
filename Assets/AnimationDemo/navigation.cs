using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigation : MonoBehaviour {
	public float speed = 7.0f;
	public Animator animation;
	Rigidbody rig;
    public bool onStage;

	void Start(){
		animation = GetComponent<Animator> ();
		rig = gameObject.GetComponent<Rigidbody> ();
        onStage = false;
	}

	void Update () {
		float r = Input.GetAxis ("Horizontal") *30* Time.deltaTime;
		transform.Rotate (Vector3.up, r , Space.Self);

		//		float z = Input.GetAxis ("Vertical") *Time.deltaTime*speed;
		//		transform.Translate (0, 0, z);
		float z = Input.GetAxis ("Vertical");
		//print (z);
		if (z > 0.3) {
			animation.SetBool ("walk", true);
			animation.SetBool ("walkBack", false);
		} else if (z < -0.3) {
			animation.SetBool ("walkBack", true);
			animation.SetBool ("walk", false);
		} else{
			animation.SetBool ("walkBack",false);
			animation.SetBool ("walk", false);
		}
	
		if(Input.GetKeyDown("space")){
			rig.AddForce(Vector3.down *15000);
			rig.useGravity = true;
		}
	}
}

