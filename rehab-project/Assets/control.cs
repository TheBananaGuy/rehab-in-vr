using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

	public Transform sparkle;

	// Use this for initialization
	void Start () {
		sparkle.GetComponent<ParticleSystem>().enableEmission = false;
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "Hand_Left") {
			sparkle.GetComponent<ParticleSystem>().enableEmission = true;
			StartCoroutine (stopSparkles());
		}
	}

	IEnumerator stopSparkles()
	{
		yield return new WaitForSeconds (.4f);
		sparkle.GetComponent<ParticleSystem>().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
