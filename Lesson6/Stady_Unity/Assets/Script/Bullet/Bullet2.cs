using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float _speed;

    private Transform _player;
    private Vector3 _target;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _target = new Vector3(_player.position.x, _player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);//для слежки снарядов за персонажем нужно вместо _target указать _player.position
        if (transform.position.x == _target.x && transform.position.y == _target.y)
        {
            DestroyBullet2();
        }
    }

	private void OnTriggerEnter(Collider other)
	{
        if (other.CompareTag("Player"))
        {
            DestroyBullet2();
        }
	}

	void DestroyBullet2()
    {
        Destroy(gameObject);
    }
}
