﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotations : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private Vector3 _jump;
    [SerializeField] private float _jumps = 10;
    public float _speed = 20f;
    public float _turnspeed = 200f;
    private Vector3 _movement;

    public static MoveRotations Instance;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.forward * -_speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * -_turnspeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * _turnspeed * Time.deltaTime);

        _jump.y = Input.GetAxis("Jump");

        var jump = _jump * _jumps * Time.deltaTime;
        transform.Translate(jump);
    }

	private void Awake()
	{
        Instance = this;
	}

	private void FixedUpdate()
	{
        if (_rigidBody == null)
        {
            return;
        }

        if (_movement.magnitude < 0.01f)
        {
            return;
        }

        var velocity = _movement * (_speed * Time.deltaTime);

        _rigidBody.velocity = velocity;
	}
}
