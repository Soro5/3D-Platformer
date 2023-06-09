using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
	public int secondsInTime;

	void Update()
	{
		if (secondsInTime > 0) 
		{
			StartCoroutine(Second());
		}
		else
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
	private IEnumerator Second()
	{
		yield return new WaitForSeconds(1);
		secondsInTime -= 1;
	}
}
