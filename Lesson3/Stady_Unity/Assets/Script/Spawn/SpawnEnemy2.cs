using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy2 : MonoBehaviour
{
    [SerializeField] public Transform _spavPos;
    [SerializeField] public GameObject _enemy;
    [SerializeField] private float _timeSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Repead()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        int _zero = 3;
        for (int i = 0; i < _zero; i++)
        {
            yield return new WaitForSeconds(0);
            Instantiate(_enemy, _spavPos.position, Quaternion.identity);
            Repead();
        }
    }
}
