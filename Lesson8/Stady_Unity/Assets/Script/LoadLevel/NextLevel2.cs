using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour
{
    public int _level;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider _other)
	{
        if (_other.tag == "Player")
        {
            //Application.LoadLevel(_level); Ну не понял, вроде как устарело????
            SceneManager.LoadScene(_level);
        }
	}
}
