using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private Transform _rootTrans;
    [SerializeField] private float _speed;
    private Transform _player;

    void Start()
    {
        _player = MoveRotations.Instance.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_player == null || _rootTrans == null)
            return;
        var speed = (_player.position - transform.position).normalized * (_speed * Time.deltaTime);
        _rootTrans.Translate(speed);
    }

    void SetSpeed(float speed)
    {
        _speed = speed;
    }
}
