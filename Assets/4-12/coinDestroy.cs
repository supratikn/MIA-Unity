using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinDestroy : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		Destroy (gameObject);
	}
}
