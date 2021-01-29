using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotations : MonoBehaviour
{
    public float _speed = 20f;
    public float _turnspeed = 200f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.forward * -_speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * -_turnspeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * _turnspeed * Time.deltaTime);
    }
}
