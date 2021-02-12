using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuveEnemy : MonoBehaviour
{
    [SerializeField] private Transform _rootTrans;
    [SerializeField] private float _speed;
    private Transform _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = MoveRotations.Instance.transform;
    }

    private void FixedUpdate()
    {
        if (_player == null || _rootTrans == null)
            return;
        var speed = (_player.position - transform.position).normalized * (_speed * Time.deltaTime);
        _rootTrans.Translate(speed);
    }

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
}
