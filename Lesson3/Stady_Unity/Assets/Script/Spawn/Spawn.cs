using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject _template;
    [SerializeField] Vector3 _position;

    // Update is called once per frame
    public void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(_template, transform, true);
        }
    }
}
