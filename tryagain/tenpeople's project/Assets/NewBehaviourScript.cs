using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

	public void Reload()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene ().name);
	}
}
