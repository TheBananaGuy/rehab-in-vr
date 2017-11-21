using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Frog : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform endPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setEndPoint(Transform t)
    {
        endPoint = t;
        agent.destination = endPoint.position;
        agent.isStopped = false;
    }
}
