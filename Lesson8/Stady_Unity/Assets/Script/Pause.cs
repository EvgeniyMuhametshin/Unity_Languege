using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool _pause = false;
    public GameObject _object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!_pause)
            {
                Time.timeScale = 0;
                _pause = true;
                _object.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                _pause = false;
                _object.SetActive(false);
            }
        }
    }
}
