using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private Vector3 _directionMouse;

    private void Start()
	{

	}

	void Update()
    {
        _direction.x = Input.GetAxis("Vertical");
        _direction.z = Input.GetAxis("Horizontal");
        _directionMouse.y = Input.GetAxis("Mouse Y");
        _directionMouse.x = Input.GetAxis("Mouse X");
    }

	private void FixedUpdate()
	{
        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
	}
}
