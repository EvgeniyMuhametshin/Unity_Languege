using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    [SerializeField] private float _jumps = 10;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private Vector3 _jump;

    private void Start()
	{
       
	}

	void Update()
    {
        _direction.x = Input.GetAxis("Vertical");
        _direction.z = Input.GetAxis("Horizontal");

        _jump.y = Input.GetAxis("Jump");
    }

	private void FixedUpdate()
	{
        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
        var jump = _jump * _jumps * Time.deltaTime;
        transform.Translate(jump);
	}

    
}

