using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    [SerializeField] private Transform _rootTrans;
    [SerializeField] private Bullet _bullet;
    [SerializeField] Vector3 _offset = new Vector3(0, 1, 0);
    [SerializeField] private float _shootPeriod = .5f;

    private float _lastShoot;

	private void Update()
	{
        if (_bullet == null || _rootTrans == null)
            return;

        if (Input.GetButtonDown("Fire2"))
        {
            if (Time.time < _lastShoot + _shootPeriod)
                return;
            _lastShoot = Time.time;

            var instance = Instantiate(_bullet, transform.position + _offset, Quaternion.identity);
            instance.SetDirections(_rootTrans.forward);
        }
	}
}
