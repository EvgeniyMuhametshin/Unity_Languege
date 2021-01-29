using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private List<GameObject> Enemy;
    [SerializeField] private float _period = 3;
    [SerializeField] private float _halfRage = 20;
    [SerializeField] private float _height = 10;

    private float _lastSpawn = 0;

    // Update is called once per frame
   public void Start()
    {
        if (Time.time > _lastSpawn + _period)
        {
            _lastSpawn = Time.time;
            var enemy = Enemy[Random.Range(0, Enemy.Count)];
            var position = new Vector3(Random.Range(-_halfRage, _halfRage), _height, Random.Range(-_halfRage, _halfRage));
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
}
