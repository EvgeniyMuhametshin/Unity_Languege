using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
	[SerializeField] private AudioSource _audioSource;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			_audioSource.Play();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			_audioSource.Play();
		}
	}
}
