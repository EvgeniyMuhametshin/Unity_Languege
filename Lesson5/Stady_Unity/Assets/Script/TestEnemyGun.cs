using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyGun : MonoBehaviour
{
    private float _timeBtwShoot;
    public float _startTimeBtwShoot;

    public GameObject _project;

    // Start is called before the first frame update
    void Start()
    {
        _timeBtwShoot = _startTimeBtwShoot;
    }

    // Update is called once per frame
    void Update()
    {
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
