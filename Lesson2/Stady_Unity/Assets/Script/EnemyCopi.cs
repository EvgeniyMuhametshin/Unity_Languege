using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCopi : MonoBehaviour
{
    [SerializeField] private float _time;

    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < 2; y++)
        {
            for (int x = 0; x < 2; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.AddComponent<Rigidbody>();
                cube.transform.position = new Vector3(1, 7, -4);
            }
        }
        _time = Time.deltaTime * 1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
