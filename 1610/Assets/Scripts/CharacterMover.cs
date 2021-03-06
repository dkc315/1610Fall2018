﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

	private CharacterController controller;
	public float Gravity;
	public float MoveSpeed;
	public float JumpSpeed;
	private Vector3 position, rotation;
	
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	void Update ()
	{
		position.y -= Gravity * Time.deltaTime;
		controller.Move(position * Time.deltaTime);

		rotation.Set(0, Input.GetAxis("Horizontal"), 0);
		transform.Rotate(rotation);
		
		
		if (controller.isGrounded)
		{
			position.Set(0, 0, MoveSpeed * Input.GetAxis("Vertical"));
            position = transform.TransformDirection(position);
			
			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
		}
	}
}
