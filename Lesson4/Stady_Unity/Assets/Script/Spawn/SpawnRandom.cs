using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnRandom : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemies;
    [SerializeField] private float _period = 3;
    [SerializeField] private float _halfRage = 20;
    [SerializeField] private float _height = 10;

    private float _lastSpawn = 0;

    void Update()
    {
        if (Time.time > _lastSpawn + _period)
        {
            _lastSpawn = Time.time;
            var enemy = _enemies[Random.Range(0, _enemies.Count)];
            var position = new Vector3(Random.Range(-_halfRage, _halfRage), _height, Random.Range(-_halfRage,_halfRage));
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
}
