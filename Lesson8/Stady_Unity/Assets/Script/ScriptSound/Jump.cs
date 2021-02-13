using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			_audioSource.Play();
		}
	}
}
