﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour
{
	private NavMeshAgent agent;
	public Transform Destination;
	public GameAction Action;
	
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
	{
		if (Destination != null) agent.destination = Destination.position;
	}
}
