using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BulletTR : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Obstacle"))
		{
			Destroy(gameObject);
		}

		if (other.gameObject.CompareTag("Enemy"))
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}
