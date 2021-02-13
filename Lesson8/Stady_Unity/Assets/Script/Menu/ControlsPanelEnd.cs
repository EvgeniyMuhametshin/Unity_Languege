using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsPanelEnd : MonoBehaviour
{
	public void PlayPressed()
	{
		SceneManager.LoadScene("Level1");
	}

	public void ExitPressed()
	{
		Application.Quit();
		Debug.Log("Exit pressed");
	}
}
