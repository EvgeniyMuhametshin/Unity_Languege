using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsPlayerMove : MonoBehaviour
{
	public float _speed;
	public float _rotSpeed;

	static Animator _anim;

	private void Start()
	{
		_anim = GetComponent<Animator>();
	}

	private void Update()
	{
		var z = Input.GetAxis("Vertical") * _speed;
		var y = Input.GetAxis("Horizontal") * _speed;

		transform.Translate(0, 0, z);
		transform.Rotate(0, y, 0);

		if (Input.GetKey(KeyCode.W))
		{
			_anim.SetBool("isWalking", true);
			_anim.SetBool("isIdle", false);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			_anim.SetBool("isWalking", true);
			_anim.SetBool("isIdle", false);

		}
		else if (Input.GetKey(KeyCode.A))
		{
			_anim.SetBool("isWalking", true);
			_anim.SetBool("isIdle", false);

		}
		else if (Input.GetKey(KeyCode.D))
		{
			_anim.SetBool("isWalking", true);
			_anim.SetBool("isIdle", false);

		}
		else
		{
			_anim.SetBool("isWalking", false);
			_anim.SetBool("isIdle", true);
		}
	}
}
