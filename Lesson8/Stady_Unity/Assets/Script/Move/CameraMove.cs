using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject _player;
    private Vector3 _offSet;

    // Start is called before the first frame update
    void Start()
    {
        _offSet = transform.position - _player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _player.transform.position + _offSet;
    }
}
