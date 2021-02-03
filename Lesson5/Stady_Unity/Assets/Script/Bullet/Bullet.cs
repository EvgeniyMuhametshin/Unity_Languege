using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Vector3 _dir;
    [SerializeField] private float _speed = 20;
    [SerializeField] private Transform _rootTrans;

    public void SetDirections(Vector3 direction)
    {
        _dir = direction.normalized;
    }

	private void FixedUpdate()
	{
        if (_rootTrans == null)
            return;

        _rootTrans.Translate(_dir * (Time.deltaTime * _speed));
	}
}
