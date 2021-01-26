using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpowner : MonoBehaviour
{
    [SerializeField] private GameObject _mine;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(_mine, transform.position, Quaternion.identity);
        }
    }
}
