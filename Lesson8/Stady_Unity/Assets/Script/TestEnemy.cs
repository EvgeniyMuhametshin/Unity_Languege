using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    public float _speed;
    public float _stoppDistance;
    public float _retreadDistance;

    private float _timeBtwShoot;
    public float _startTimeBtwShoot;

    public GameObject _project;
    public Transform _player;

    
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;//Движение
        _timeBtwShoot = _startTimeBtwShoot;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, _player.position) > _stoppDistance)//Движение
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);//Движение
        }
        else if (Vector3.Distance(transform.position, _player.position) < _stoppDistance && Vector3.Distance(transform.position, _player.position) > _retreadDistance)//Движение
        {
            transform.position = this.transform.position;//Движение
        }
        else if (Vector3.Distance(transform.position, _player.position) < _retreadDistance)//Движение
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.position, -_speed * Time.deltaTime);//Движение
        }

        if (_timeBtwShoot <= 0)
        {
            Instantiate(_project, transform.position, Quaternion.identity);
            _timeBtwShoot = _startTimeBtwShoot;
        }
        else
        {
            _timeBtwShoot -= Time.deltaTime;
        }
    }
}
