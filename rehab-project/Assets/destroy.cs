﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class destroy : MonoBehaviour {

//	void onCollisionEnter(Collision collision)
//	{
//		Debug.Log ("DESTROY before collision!");
//		IHandModel hand = collision.gameObject.GetComponentInParent<IHandModel>();
//		if (hand != null) 
//		{
//			Debug.Log ("DESTROY before destroy!");
//			Destroy (this.gameObject);
//			Debug.Log ("DESTROY after destroy!");
//		}
//		Debug.Log ("DESTROY!");

//		if (collision.gameObject.CompareTag ("Hand_Right")) 
//		{
//			this.gameObject.SetActive (false);
//						Debug.Log ("DESTROY after destroy!");
//		}


//	}

//	void OnTriggerEnter(Collider other){
//		FingerModel finger = other.GetComponentInParent<FingerModel>();
//		if(finger){
//			this.GetComponent<DisableObject> ().enabled = true;
//		}
//	}

	public ParticleSystem kaboom;

	void Start () {
	}

	void Update () {
	}

	public void PrintInfo () {
		print (this);
	}

	public void DestroyWrapper() {
		ParticleSystem explosioneffect = Instantiate(kaboom) as ParticleSystem;
		explosioneffect.transform.position = transform.position;
		explosioneffect.loop = false;
		explosioneffect.Play ();
		Destroy (explosioneffect.gameObject, explosioneffect.duration);
		Destroy (this.gameObject);
	}

	public void StartDestroyCountdown() {
		Invoke ("DestroyWrapper", 3);
	}
}
